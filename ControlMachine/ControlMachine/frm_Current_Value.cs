using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlMachine
{
    public partial class frm_Current_Value : Form
    {
        private string Address64bit;
        private string Address16bit;
        private string status_value;
        private DelegateCurrent delegateCurrent = new DelegateCurrent(frm_main.getCurrentValue);
        private byte statusControl;
        private int INDEX;
        private zigbeeConnect con = new zigbeeConnect();
        public frm_Current_Value(string Add64bit,string Add16bit,string status,int idx)
        {
            InitializeComponent();
            Address64bit = Add64bit;
            Address16bit = Add16bit;
            status_value = status;
            // realTimeSample1
            
            INDEX = idx;
        }
      
        
        private void frm_Current_Value_Load(object sender, EventArgs e)
        {
            lbl_64Address.Text = Address64bit;
            lbl_16Address.Text = Address16bit;
            lbl_status_value.Text = status_value;
           
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] data = delegateCurrent(INDEX);
            lbl_status_value.Text = data[0];
            float current = float.Parse(data[1]);
            lbl_current_value.Text = String.Format("{0:F2} Amp",current);
            this.realTimeSample1.CurrentValue = current*100;

            float pre_lim = float.Parse(data[2]);
            lbl_preLimitValue.Text = String.Format("{0:F2} Amp", pre_lim);

            if (lbl_status_value.Text == "Off")
            {

                btn_On_Off.BackgroundImage = Properties.Resources.power_on_button;
                statusControl = 0x01;
                btn_On_Off.Enabled = true;
                btn_Restart.Enabled = true;
                btn_set_limit_load.Enabled = true;
                lbl_status_value.ForeColor = Color.Gray;
            }
            else if (lbl_status_value.Text == "On")
            {

                btn_On_Off.BackgroundImage = Properties.Resources.power_off_button;
                statusControl = 0x00;
                btn_On_Off.Enabled = true;
                btn_Restart.Enabled = true;
                btn_set_limit_load.Enabled = true;
                lbl_status_value.ForeColor = Color.BlueViolet;
            }
            else if (lbl_status_value.Text == "Overload")
            {
                
                btn_On_Off.BackgroundImage = Properties.Resources.power_on_button;
                statusControl = 0x01;
                btn_Restart.Enabled = true;
                btn_set_limit_load.Enabled = false;
                lbl_status_value.ForeColor = Color.Red;
            }
            else if (lbl_status_value.Text == "Unavailable")
            {
                
                btn_On_Off.Enabled = false;
                btn_Restart.Enabled = false;
                btn_set_limit_load.Enabled = false;
                lbl_status_value.ForeColor = Color.FromArgb(250, 145, 7);
            }
        }

       

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            
            con.controlFrame(lbl_64Address.Text, lbl_16Address.Text, 0x03);
            
        }

        private void btn_set_limit_load_Click(object sender, EventArgs e)
        {
            txt_limit_load.Text.Trim();
            if (txt_limit_load.Text != "")
            {
                float lim;
                Boolean ck = Single.TryParse(txt_limit_load.Text,out lim);
                if (ck != false)
                {
                    lim = lim * 100;
                    byte HB = Convert.ToByte(Math.Floor(lim / 256));
                    byte LB = Convert.ToByte(lim % 256);
                    
                    con.setLimitLoad(lbl_64Address.Text, lbl_16Address.Text, HB, LB);
                }
                else
                {
                    MessageBox.Show("ต้องใส่ค่าเป็นตัวเลขเท่านั้น", "หยุด!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("ห้ามเป็นค่าว่าง","หยุด!!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

            
        }

        private void btn_On_Off_Click(object sender, EventArgs e)
        {
            
            con.controlFrame(lbl_64Address.Text, lbl_16Address.Text, statusControl);
                       
            
        }
    }
}
