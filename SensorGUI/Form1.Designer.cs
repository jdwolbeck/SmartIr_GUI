namespace SensorGUI
{
    partial class Form1
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
            this.tb_connect = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cb_connect = new System.Windows.Forms.ComboBox();
            this.uart = new System.IO.Ports.SerialPort(this.components);
            this.tb_database1 = new System.Windows.Forms.TextBox();
            this.btn_website = new System.Windows.Forms.Button();
            this.tb_website_response = new System.Windows.Forms.TextBox();
            this.tb_database2 = new System.Windows.Forms.TextBox();
            this.tb_database3 = new System.Windows.Forms.TextBox();
            this.lbl_Soil = new System.Windows.Forms.Label();
            this.lbl_Light = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.tb_average1 = new System.Windows.Forms.TextBox();
            this.tb_average2 = new System.Windows.Forms.TextBox();
            this.tb_average3 = new System.Windows.Forms.TextBox();
            this.gb_connect = new System.Windows.Forms.GroupBox();
            this.gb_website = new System.Windows.Forms.GroupBox();
            this.gb_database = new System.Windows.Forms.GroupBox();
            this.gb_connect.SuspendLayout();
            this.gb_website.SuspendLayout();
            this.gb_database.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_connect
            // 
            this.tb_connect.Location = new System.Drawing.Point(6, 72);
            this.tb_connect.Name = "tb_connect";
            this.tb_connect.Size = new System.Drawing.Size(109, 20);
            this.tb_connect.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(6, 19);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(109, 47);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cb_connect
            // 
            this.cb_connect.FormattingEnabled = true;
            this.cb_connect.Location = new System.Drawing.Point(5, 98);
            this.cb_connect.Name = "cb_connect";
            this.cb_connect.Size = new System.Drawing.Size(110, 21);
            this.cb_connect.TabIndex = 2;
            // 
            // uart
            // 
            this.uart.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.uart_DataReceived);
            // 
            // tb_database1
            // 
            this.tb_database1.Location = new System.Drawing.Point(6, 14);
            this.tb_database1.Multiline = true;
            this.tb_database1.Name = "tb_database1";
            this.tb_database1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_database1.Size = new System.Drawing.Size(75, 380);
            this.tb_database1.TabIndex = 3;
            // 
            // btn_website
            // 
            this.btn_website.Location = new System.Drawing.Point(5, 19);
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(109, 49);
            this.btn_website.TabIndex = 6;
            this.btn_website.Text = "Send to Website";
            this.btn_website.UseVisualStyleBackColor = true;
            this.btn_website.Click += new System.EventHandler(this.btn_website_Click);
            // 
            // tb_website_response
            // 
            this.tb_website_response.Location = new System.Drawing.Point(6, 74);
            this.tb_website_response.Multiline = true;
            this.tb_website_response.Name = "tb_website_response";
            this.tb_website_response.Size = new System.Drawing.Size(109, 217);
            this.tb_website_response.TabIndex = 8;
            // 
            // tb_database2
            // 
            this.tb_database2.Location = new System.Drawing.Point(87, 14);
            this.tb_database2.Multiline = true;
            this.tb_database2.Name = "tb_database2";
            this.tb_database2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_database2.Size = new System.Drawing.Size(75, 380);
            this.tb_database2.TabIndex = 9;
            // 
            // tb_database3
            // 
            this.tb_database3.Location = new System.Drawing.Point(168, 14);
            this.tb_database3.Multiline = true;
            this.tb_database3.Name = "tb_database3";
            this.tb_database3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_database3.Size = new System.Drawing.Size(75, 380);
            this.tb_database3.TabIndex = 10;
            // 
            // lbl_Soil
            // 
            this.lbl_Soil.AutoSize = true;
            this.lbl_Soil.Location = new System.Drawing.Point(6, 0);
            this.lbl_Soil.Name = "lbl_Soil";
            this.lbl_Soil.Size = new System.Drawing.Size(54, 13);
            this.lbl_Soil.TabIndex = 11;
            this.lbl_Soil.Text = "Soil Value";
            // 
            // lbl_Light
            // 
            this.lbl_Light.AutoSize = true;
            this.lbl_Light.Location = new System.Drawing.Point(87, 1);
            this.lbl_Light.Name = "lbl_Light";
            this.lbl_Light.Size = new System.Drawing.Size(60, 13);
            this.lbl_Light.TabIndex = 12;
            this.lbl_Light.Text = "Light Value";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(168, 1);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(64, 13);
            this.lbl_Temp.TabIndex = 13;
            this.lbl_Temp.Text = "Temp Value";
            // 
            // tb_average1
            // 
            this.tb_average1.Location = new System.Drawing.Point(6, 400);
            this.tb_average1.Name = "tb_average1";
            this.tb_average1.Size = new System.Drawing.Size(75, 20);
            this.tb_average1.TabIndex = 14;
            // 
            // tb_average2
            // 
            this.tb_average2.Location = new System.Drawing.Point(87, 400);
            this.tb_average2.Name = "tb_average2";
            this.tb_average2.Size = new System.Drawing.Size(75, 20);
            this.tb_average2.TabIndex = 15;
            // 
            // tb_average3
            // 
            this.tb_average3.Location = new System.Drawing.Point(168, 400);
            this.tb_average3.Name = "tb_average3";
            this.tb_average3.Size = new System.Drawing.Size(75, 20);
            this.tb_average3.TabIndex = 16;
            // 
            // gb_connect
            // 
            this.gb_connect.Controls.Add(this.btn_connect);
            this.gb_connect.Controls.Add(this.tb_connect);
            this.gb_connect.Controls.Add(this.cb_connect);
            this.gb_connect.Location = new System.Drawing.Point(12, 12);
            this.gb_connect.Name = "gb_connect";
            this.gb_connect.Size = new System.Drawing.Size(122, 123);
            this.gb_connect.TabIndex = 17;
            this.gb_connect.TabStop = false;
            this.gb_connect.Text = "Connection Control";
            // 
            // gb_website
            // 
            this.gb_website.Controls.Add(this.btn_website);
            this.gb_website.Controls.Add(this.tb_website_response);
            this.gb_website.Location = new System.Drawing.Point(12, 141);
            this.gb_website.Name = "gb_website";
            this.gb_website.Size = new System.Drawing.Size(122, 297);
            this.gb_website.TabIndex = 18;
            this.gb_website.TabStop = false;
            this.gb_website.Text = "Website Control";
            // 
            // gb_database
            // 
            this.gb_database.Controls.Add(this.tb_average3);
            this.gb_database.Controls.Add(this.tb_database1);
            this.gb_database.Controls.Add(this.tb_average2);
            this.gb_database.Controls.Add(this.lbl_Soil);
            this.gb_database.Controls.Add(this.tb_average1);
            this.gb_database.Controls.Add(this.tb_database2);
            this.gb_database.Controls.Add(this.lbl_Temp);
            this.gb_database.Controls.Add(this.lbl_Light);
            this.gb_database.Controls.Add(this.tb_database3);
            this.gb_database.Location = new System.Drawing.Point(140, 12);
            this.gb_database.Name = "gb_database";
            this.gb_database.Size = new System.Drawing.Size(249, 426);
            this.gb_database.TabIndex = 19;
            this.gb_database.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.gb_connect);
            this.Controls.Add(this.gb_website);
            this.Controls.Add(this.gb_database);
            this.Name = "Form1";
            this.Text = "SensorGui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_connect.ResumeLayout(false);
            this.gb_connect.PerformLayout();
            this.gb_website.ResumeLayout(false);
            this.gb_website.PerformLayout();
            this.gb_database.ResumeLayout(false);
            this.gb_database.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_connect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_connect;
        private System.IO.Ports.SerialPort uart;
        private System.Windows.Forms.Button btn_website;
        private System.Windows.Forms.TextBox tb_website_response;
        private System.Windows.Forms.TextBox tb_database1;
        private System.Windows.Forms.TextBox tb_database2;
        private System.Windows.Forms.TextBox tb_database3;
        private System.Windows.Forms.Label lbl_Soil;
        private System.Windows.Forms.Label lbl_Light;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.TextBox tb_average1;
        private System.Windows.Forms.TextBox tb_average2;
        private System.Windows.Forms.TextBox tb_average3;
        private System.Windows.Forms.GroupBox gb_connect;
        private System.Windows.Forms.GroupBox gb_website;
        private System.Windows.Forms.GroupBox gb_database;
    }
}

