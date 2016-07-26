using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
namespace ControlMachine
{
    public delegate string[] DelegateCurrent(int IDX);
    public partial class frm_main : Form
    {
        
        public static ListView lsv_node = new ListView();
        public zigbeeConnect con = new zigbeeConnect();
        private Thread th;
        
        public frm_main()
        {
            
            InitializeComponent();
            //lsv_node แบบ static
            lsv_node.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address64bit,
            this.Address16bit,
            this.NodeStatus});
            lsv_node.FullRowSelect = true;
            lsv_node.GridLines = true;
            lsv_node.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lsv_node.Location = new System.Drawing.Point(12, 108);
            lsv_node.Name = "lsv_node";
            lsv_node.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lsv_node.Size = new System.Drawing.Size(627, 299);
            lsv_node.TabIndex = 0;
            lsv_node.UseCompatibleStateImageBehavior = false;
            lsv_node.View = System.Windows.Forms.View.Details;
            lsv_node.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsv_node_MouseDoubleClick);
            this.Controls.Add(lsv_node);
            th = new Thread(new ThreadStart(addCurrentValue));
        }

        public static string[] getCurrentValue(int IDX)
        {
            string[] data = new string[3];
            data[0] = lsv_node.Items[IDX].SubItems[2].Text;
            data[1] = lsv_node.Items[IDX].SubItems[3].Text;
            data[2] = lsv_node.Items[IDX].SubItems[5].Text;
            return data;
        }

        
        
        

        private void btn_start_port_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (cbo_port_name.Text == "" || cbo_baud_rate.Text == "")
                {
                    MessageBox.Show("กรุณาเลือก Port และ Baud Rate ด้วย","หยุด!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    con.openPort(cbo_port_name.Text, Convert.ToInt32(cbo_baud_rate.Text));
                    btn_start_port.Enabled = false;
                    btn_stop_port.Enabled = true;
                    
                    if (this.th.ThreadState == ThreadState.Suspended)
                    {
                        this.th.Resume();
                    }
                    else
                    {
                        
                        this.th.Start();
                        
                        
                    }

                    
                    
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void addItemToListView(ListViewItem item) 
        {
            bool ck = false;
            if (lsv_node.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    foreach (ListViewItem itemRow in lsv_node.Items)
                    {
                        if (!(itemRow.SubItems[1].Text.Equals(item.SubItems[1].Text)))
                        {
                            int signal = Int32.Parse(itemRow.SubItems[4].Text);
                            signal += 1;
                            itemRow.SubItems[4].Text = signal.ToString();
                            if (signal > 30)
                            {
                                itemRow.SubItems[2].Text = "Unavailable";
                                itemRow.SubItems[3].Text = "0";
                            }
                        }
                        else if (itemRow.SubItems[1].Text.Equals(item.SubItems[1].Text))
                        {
                            
                                itemRow.SubItems[0].Text = item.SubItems[0].Text;
                                itemRow.SubItems[1].Text = item.SubItems[1].Text;
                                itemRow.SubItems[2].Text = item.SubItems[2].Text;
                                itemRow.SubItems[3].Text = item.SubItems[3].Text;
                                itemRow.SubItems[4].Text = "0";
                                itemRow.SubItems[5].Text = item.SubItems[5].Text;
                                ck = true;
                        }
                        
                    }
                    if (!(item.SubItems[1].Text.Equals("")) && ck == false)
                    {
                        lsv_node.Items.Add(item);
                    }
                }));
            }
            
            
        }

        public float getCurrentData(byte h,byte l)
        {
            return Convert.ToSingle(((h * 256) + l) / 100.00);
        }

        private void addCurrentValue()
        {
            
            while (true)
            {
                
                List<byte> temp = new List<byte>();
                temp = con.recivePacket();
                
                if (temp.Count == 0)
                {
                    string[] it = { "","", "","","" };
                    ListViewItem item = new ListViewItem(it);
                    addItemToListView(item);
                }
                else if (temp.Count == 21)
                {

                    string Address64bit = "";
                    for (int i = 4; i <= 11; i++)
                    {
                        Address64bit += String.Format("{0:X}", temp[i]) + " ";
                    }

                    Address64bit = Address64bit.Trim();
                    string Address16bit = String.Format("{0:X}", temp[12]) + " " + String.Format("{0:X}", temp[13]);

                    string Status = null;
                    if (temp[15] == 0x00)
                    {
                        Status = "Off";
                    }
                    else if (temp[15] == 0x01)
                    {
                        Status = "On";
                    }
                    else if (temp[15] == 0x02)
                    {
                        Status = "Overload";
                    }
                    float current = getCurrentData(temp[16], temp[17]);
                    float limit = getCurrentData(temp[18],temp[19]);
                    string[] it = { Address64bit, Address16bit, Status, Convert.ToString(current), "0", Convert.ToString(limit) };
                    ListViewItem item = new ListViewItem(it);
                    addItemToListView(item);

                }
                                       

                Thread.Sleep(200);//350
            }
            
        }

        
        
        private void btn_stop_port_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.th.ThreadState == ThreadState.Running || this.th.ThreadState == ThreadState.WaitSleepJoin)
                {
                    this.th.Suspend();
                    
                    con.closePort();
                    btn_start_port.Enabled = true;
                    btn_stop_port.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lsv_node_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string address64 = lsv_node.SelectedItems[0].SubItems[0].Text;
            string address16 = lsv_node.SelectedItems[0].SubItems[1].Text;
            string status = lsv_node.SelectedItems[0].SubItems[2].Text;
            int index = lsv_node.SelectedIndices[0];
            frm_Current_Value frm_cur = new frm_Current_Value(address64,address16,status,index);
            frm_cur.Visible = true;
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th.ThreadState == System.Threading.ThreadState.Suspended)
            {

                th.Resume();
            }
            th.Abort();
        }

        private void frm_main_Shown(object sender, EventArgs e)
        {
            cbo_port_name.Items.AddRange(con.getAvailablePort());
            cbo_baud_rate.Items.Add("9600");
            cbo_baud_rate.SelectedIndex = 0;
            while (true)
            {
                if (cbo_port_name.Items.Count <= 0)
                {
                    if (MessageBox.Show("ไม่มี Serial Port ที่จะสามารถเปิดใช้งานได้", "ผิดพลาด!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                    {
                        cbo_port_name.Items.AddRange(con.getAvailablePort());
                    }
                    else
                    {
                        this.Close();
                        break;
                    }
                }
                else
                {
                    cbo_port_name.SelectedIndex = 0;
                    break;
                }
            }
        }
  
    }
    
}
