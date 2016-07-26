namespace ControlMachine
{
    partial class frm_main
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_port_name = new System.Windows.Forms.Label();
            this.cbo_port_name = new System.Windows.Forms.ComboBox();
            this.cbo_baud_rate = new System.Windows.Forms.ComboBox();
            this.lbl_baud_rate = new System.Windows.Forms.Label();
            this.Address64bit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address16bit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NodeStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_stop_port = new System.Windows.Forms.Button();
            this.btn_start_port = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_port_name
            // 
            this.lbl_port_name.AutoSize = true;
            this.lbl_port_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_port_name.Location = new System.Drawing.Point(24, 25);
            this.lbl_port_name.Name = "lbl_port_name";
            this.lbl_port_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_port_name.TabIndex = 0;
            this.lbl_port_name.Text = "Port Name";
            // 
            // cbo_port_name
            // 
            this.cbo_port_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_port_name.FormattingEnabled = true;
            this.cbo_port_name.Location = new System.Drawing.Point(27, 58);
            this.cbo_port_name.Name = "cbo_port_name";
            this.cbo_port_name.Size = new System.Drawing.Size(121, 21);
            this.cbo_port_name.TabIndex = 1;
            // 
            // cbo_baud_rate
            // 
            this.cbo_baud_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_baud_rate.FormattingEnabled = true;
            this.cbo_baud_rate.Items.AddRange(new object[] {
            "9600"});
            this.cbo_baud_rate.Location = new System.Drawing.Point(249, 60);
            this.cbo_baud_rate.Name = "cbo_baud_rate";
            this.cbo_baud_rate.Size = new System.Drawing.Size(131, 21);
            this.cbo_baud_rate.TabIndex = 2;
            // 
            // lbl_baud_rate
            // 
            this.lbl_baud_rate.AutoSize = true;
            this.lbl_baud_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_baud_rate.Location = new System.Drawing.Point(246, 25);
            this.lbl_baud_rate.Name = "lbl_baud_rate";
            this.lbl_baud_rate.Size = new System.Drawing.Size(95, 20);
            this.lbl_baud_rate.TabIndex = 3;
            this.lbl_baud_rate.Text = "Baud Rate";
            // 
            // Address64bit
            // 
            this.Address64bit.Text = "64 bit Address";
            this.Address64bit.Width = 250;
            // 
            // Address16bit
            // 
            this.Address16bit.Text = "16 bit Address";
            this.Address16bit.Width = 250;
            // 
            // NodeStatus
            // 
            this.NodeStatus.Text = "Status";
            this.NodeStatus.Width = 131;
            // 
            // btn_stop_port
            // 
            this.btn_stop_port.BackgroundImage = global::ControlMachine.Properties.Resources.stop_button;
            this.btn_stop_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop_port.Enabled = false;
            this.btn_stop_port.Location = new System.Drawing.Point(563, 25);
            this.btn_stop_port.Name = "btn_stop_port";
            this.btn_stop_port.Size = new System.Drawing.Size(75, 55);
            this.btn_stop_port.TabIndex = 5;
            this.btn_stop_port.UseVisualStyleBackColor = true;
            this.btn_stop_port.Click += new System.EventHandler(this.btn_stop_port_Click);
            // 
            // btn_start_port
            // 
            this.btn_start_port.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_port.BackgroundImage = global::ControlMachine.Properties.Resources.start_button;
            this.btn_start_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start_port.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start_port.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_start_port.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_start_port.Location = new System.Drawing.Point(432, 25);
            this.btn_start_port.Name = "btn_start_port";
            this.btn_start_port.Size = new System.Drawing.Size(75, 56);
            this.btn_start_port.TabIndex = 4;
            this.btn_start_port.UseVisualStyleBackColor = false;
            this.btn_start_port.Click += new System.EventHandler(this.btn_start_port_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(651, 419);
            this.Controls.Add(this.btn_stop_port);
            this.Controls.Add(this.btn_start_port);
            this.Controls.Add(this.lbl_baud_rate);
            this.Controls.Add(this.cbo_baud_rate);
            this.Controls.Add(this.cbo_port_name);
            this.Controls.Add(this.lbl_port_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Shown += new System.EventHandler(this.frm_main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_port_name;
        private System.Windows.Forms.ComboBox cbo_port_name;
        private System.Windows.Forms.ComboBox cbo_baud_rate;
        private System.Windows.Forms.Label lbl_baud_rate;
        private System.Windows.Forms.ColumnHeader Address64bit;
        private System.Windows.Forms.ColumnHeader Address16bit;
        private System.Windows.Forms.ColumnHeader NodeStatus;
        private System.Windows.Forms.Button btn_start_port;
        private System.Windows.Forms.Button btn_stop_port;
        
        
    }
}

