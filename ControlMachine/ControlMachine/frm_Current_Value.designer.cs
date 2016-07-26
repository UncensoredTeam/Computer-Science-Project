namespace ControlMachine
{
    partial class frm_Current_Value
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Address64bit = new System.Windows.Forms.Label();
            this.lbl_Address16bit = new System.Windows.Forms.Label();
            this.lbl_64Address = new System.Windows.Forms.Label();
            this.lbl_16Address = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_status_value = new System.Windows.Forms.Label();
            this.lbl_Current = new System.Windows.Forms.Label();
            this.lbl_current_value = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_limit_load = new System.Windows.Forms.Label();
            this.btn_set_limit_load = new System.Windows.Forms.Button();
            this.txt_limit_load = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lim_of_load = new System.Windows.Forms.Label();
            this.lbl_preLimitValue = new System.Windows.Forms.Label();
            this.lbl_preLimit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_On_Off = new System.Windows.Forms.Button();
            this.realTimeSample1 = new ControlMachine.RealTimeSample();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Address64bit
            // 
            this.lbl_Address64bit.AutoSize = true;
            this.lbl_Address64bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Address64bit.Location = new System.Drawing.Point(10, 9);
            this.lbl_Address64bit.Name = "lbl_Address64bit";
            this.lbl_Address64bit.Size = new System.Drawing.Size(115, 16);
            this.lbl_Address64bit.TabIndex = 1;
            this.lbl_Address64bit.Text = "64 bit Address :";
            // 
            // lbl_Address16bit
            // 
            this.lbl_Address16bit.AutoSize = true;
            this.lbl_Address16bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Address16bit.Location = new System.Drawing.Point(303, 13);
            this.lbl_Address16bit.Name = "lbl_Address16bit";
            this.lbl_Address16bit.Size = new System.Drawing.Size(115, 16);
            this.lbl_Address16bit.TabIndex = 2;
            this.lbl_Address16bit.Text = "16 bit Address :";
            // 
            // lbl_64Address
            // 
            this.lbl_64Address.AutoSize = true;
            this.lbl_64Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_64Address.Location = new System.Drawing.Point(131, 11);
            this.lbl_64Address.Name = "lbl_64Address";
            this.lbl_64Address.Size = new System.Drawing.Size(62, 16);
            this.lbl_64Address.TabIndex = 3;
            this.lbl_64Address.Text = "Unknow";
            // 
            // lbl_16Address
            // 
            this.lbl_16Address.AutoSize = true;
            this.lbl_16Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_16Address.Location = new System.Drawing.Point(423, 14);
            this.lbl_16Address.Name = "lbl_16Address";
            this.lbl_16Address.Size = new System.Drawing.Size(62, 16);
            this.lbl_16Address.TabIndex = 4;
            this.lbl_16Address.Text = "Unknow";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_status.Location = new System.Drawing.Point(509, 13);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(66, 18);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Status :";
            // 
            // lbl_status_value
            // 
            this.lbl_status_value.AutoSize = true;
            this.lbl_status_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_status_value.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_status_value.Location = new System.Drawing.Point(581, 9);
            this.lbl_status_value.Name = "lbl_status_value";
            this.lbl_status_value.Size = new System.Drawing.Size(57, 33);
            this.lbl_status_value.TabIndex = 6;
            this.lbl_status_value.Text = "Off";
            // 
            // lbl_Current
            // 
            this.lbl_Current.AutoSize = true;
            this.lbl_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Current.Location = new System.Drawing.Point(486, 322);
            this.lbl_Current.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_Current.Name = "lbl_Current";
            this.lbl_Current.Size = new System.Drawing.Size(157, 25);
            this.lbl_Current.TabIndex = 8;
            this.lbl_Current.Text = "Current Value";
            // 
            // lbl_current_value
            // 
            this.lbl_current_value.AutoSize = true;
            this.lbl_current_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_current_value.ForeColor = System.Drawing.Color.Lime;
            this.lbl_current_value.Location = new System.Drawing.Point(61, 21);
            this.lbl_current_value.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_current_value.Name = "lbl_current_value";
            this.lbl_current_value.Size = new System.Drawing.Size(185, 42);
            this.lbl_current_value.TabIndex = 9;
            this.lbl_current_value.Text = "0.00 Amp";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_limit_load
            // 
            this.lbl_limit_load.AutoSize = true;
            this.lbl_limit_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_limit_load.Location = new System.Drawing.Point(486, 151);
            this.lbl_limit_load.Name = "lbl_limit_load";
            this.lbl_limit_load.Size = new System.Drawing.Size(229, 25);
            this.lbl_limit_load.TabIndex = 10;
            this.lbl_limit_load.Text = "Setting Limit of Load";
            // 
            // btn_set_limit_load
            // 
            this.btn_set_limit_load.Location = new System.Drawing.Point(162, 83);
            this.btn_set_limit_load.Name = "btn_set_limit_load";
            this.btn_set_limit_load.Size = new System.Drawing.Size(75, 39);
            this.btn_set_limit_load.TabIndex = 12;
            this.btn_set_limit_load.Text = "Set";
            this.btn_set_limit_load.UseVisualStyleBackColor = true;
            this.btn_set_limit_load.Click += new System.EventHandler(this.btn_set_limit_load_Click);
            // 
            // txt_limit_load
            // 
            this.txt_limit_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_limit_load.Location = new System.Drawing.Point(116, 45);
            this.txt_limit_load.Name = "txt_limit_load";
            this.txt_limit_load.Size = new System.Drawing.Size(62, 22);
            this.txt_limit_load.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_lim_of_load);
            this.panel1.Controls.Add(this.lbl_preLimitValue);
            this.panel1.Controls.Add(this.lbl_preLimit);
            this.panel1.Controls.Add(this.btn_set_limit_load);
            this.panel1.Controls.Add(this.txt_limit_load);
            this.panel1.Location = new System.Drawing.Point(511, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 129);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(184, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Amp";
            // 
            // lbl_lim_of_load
            // 
            this.lbl_lim_of_load.AutoSize = true;
            this.lbl_lim_of_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_lim_of_load.Location = new System.Drawing.Point(9, 45);
            this.lbl_lim_of_load.Name = "lbl_lim_of_load";
            this.lbl_lim_of_load.Size = new System.Drawing.Size(101, 16);
            this.lbl_lim_of_load.TabIndex = 15;
            this.lbl_lim_of_load.Text = "Current Limit :";
            // 
            // lbl_preLimitValue
            // 
            this.lbl_preLimitValue.AutoSize = true;
            this.lbl_preLimitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_preLimitValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_preLimitValue.Location = new System.Drawing.Point(128, 16);
            this.lbl_preLimitValue.Name = "lbl_preLimitValue";
            this.lbl_preLimitValue.Size = new System.Drawing.Size(62, 16);
            this.lbl_preLimitValue.TabIndex = 14;
            this.lbl_preLimitValue.Text = "Unknow";
            // 
            // lbl_preLimit
            // 
            this.lbl_preLimit.AutoSize = true;
            this.lbl_preLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_preLimit.Location = new System.Drawing.Point(9, 14);
            this.lbl_preLimit.Name = "lbl_preLimit";
            this.lbl_preLimit.Size = new System.Drawing.Size(113, 16);
            this.lbl_preLimit.TabIndex = 13;
            this.lbl_preLimit.Text = "Previous Limit :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_current_value);
            this.panel2.Location = new System.Drawing.Point(511, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 73);
            this.panel2.TabIndex = 17;
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackgroundImage = global::ControlMachine.Properties.Resources.power_restart_button;
            this.btn_Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Restart.Location = new System.Drawing.Point(673, 63);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 56);
            this.btn_Restart.TabIndex = 7;
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_On_Off
            // 
            this.btn_On_Off.BackgroundImage = global::ControlMachine.Properties.Resources.power_on_button;
            this.btn_On_Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_On_Off.Location = new System.Drawing.Point(546, 63);
            this.btn_On_Off.Name = "btn_On_Off";
            this.btn_On_Off.Size = new System.Drawing.Size(75, 56);
            this.btn_On_Off.TabIndex = 7;
            this.btn_On_Off.UseVisualStyleBackColor = true;
            this.btn_On_Off.Click += new System.EventHandler(this.btn_On_Off_Click);
            // 
            // realTimeSample1
            // 
            this.realTimeSample1.BackColor = System.Drawing.Color.White;
            this.realTimeSample1.Font = new System.Drawing.Font("Verdana", 9F);
            this.realTimeSample1.Location = new System.Drawing.Point(13, 50);
            this.realTimeSample1.Name = "realTimeSample1";
            this.realTimeSample1.Size = new System.Drawing.Size(452, 364);
            this.realTimeSample1.TabIndex = 13;
            // 
            // frm_Current_Value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(772, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_Current);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.realTimeSample1);
            this.Controls.Add(this.lbl_limit_load);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_On_Off);
            this.Controls.Add(this.lbl_status_value);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_16Address);
            this.Controls.Add(this.lbl_64Address);
            this.Controls.Add(this.lbl_Address16bit);
            this.Controls.Add(this.lbl_Address64bit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Current_Value";
            this.Text = "Current Value";
            this.Load += new System.EventHandler(this.frm_Current_Value_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lbl_Address64bit;
        private System.Windows.Forms.Label lbl_Address16bit;
        private System.Windows.Forms.Label lbl_64Address;
        private System.Windows.Forms.Label lbl_16Address;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_status_value;
        private System.Windows.Forms.Button btn_On_Off;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Label lbl_Current;
        private System.Windows.Forms.Label lbl_current_value;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_limit_load;
        private RealTimeSample realTimeSample1;
        private System.Windows.Forms.Button btn_set_limit_load;
        private System.Windows.Forms.TextBox txt_limit_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_lim_of_load;
        private System.Windows.Forms.Label lbl_preLimitValue;
        private System.Windows.Forms.Label lbl_preLimit;
        private System.Windows.Forms.Panel panel2;

    }
}

