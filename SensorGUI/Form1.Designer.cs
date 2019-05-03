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
            this.tb_database2 = new System.Windows.Forms.TextBox();
            this.tb_database3 = new System.Windows.Forms.TextBox();
            this.lbl_Soil = new System.Windows.Forms.Label();
            this.lbl_Light = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.tb_average1 = new System.Windows.Forms.TextBox();
            this.tb_average2 = new System.Windows.Forms.TextBox();
            this.tb_average3 = new System.Windows.Forms.TextBox();
            this.gb_connect = new System.Windows.Forms.GroupBox();
            this.gb_time = new System.Windows.Forms.GroupBox();
            this.cb_duration = new System.Windows.Forms.ComboBox();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_minute = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.cb_time_minute = new System.Windows.Forms.ComboBox();
            this.cb_time_hour = new System.Windows.Forms.ComboBox();
            this.btn_set_time = new System.Windows.Forms.Button();
            this.tb_timer = new System.Windows.Forms.TextBox();
            this.gb_database = new System.Windows.Forms.GroupBox();
            this.lbl_Node = new System.Windows.Forms.Label();
            this.tb_average4 = new System.Windows.Forms.TextBox();
            this.tb_database4 = new System.Windows.Forms.TextBox();
            this.gb_connect.SuspendLayout();
            this.gb_time.SuspendLayout();
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
            // gb_time
            // 
            this.gb_time.Controls.Add(this.cb_duration);
            this.gb_time.Controls.Add(this.lbl_duration);
            this.gb_time.Controls.Add(this.lbl_minute);
            this.gb_time.Controls.Add(this.lbl_hour);
            this.gb_time.Controls.Add(this.cb_time_minute);
            this.gb_time.Controls.Add(this.cb_time_hour);
            this.gb_time.Controls.Add(this.btn_set_time);
            this.gb_time.Controls.Add(this.tb_timer);
            this.gb_time.Location = new System.Drawing.Point(12, 141);
            this.gb_time.Name = "gb_time";
            this.gb_time.Size = new System.Drawing.Size(122, 297);
            this.gb_time.TabIndex = 18;
            this.gb_time.TabStop = false;
            this.gb_time.Text = "Timer Control";
            // 
            // cb_duration
            // 
            this.cb_duration.FormattingEnabled = true;
            this.cb_duration.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.cb_duration.Location = new System.Drawing.Point(51, 270);
            this.cb_duration.Name = "cb_duration";
            this.cb_duration.Size = new System.Drawing.Size(65, 21);
            this.cb_duration.TabIndex = 15;
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(6, 270);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(47, 13);
            this.lbl_duration.TabIndex = 14;
            this.lbl_duration.Text = "Duration";
            // 
            // lbl_minute
            // 
            this.lbl_minute.AutoSize = true;
            this.lbl_minute.Location = new System.Drawing.Point(6, 243);
            this.lbl_minute.Name = "lbl_minute";
            this.lbl_minute.Size = new System.Drawing.Size(39, 13);
            this.lbl_minute.TabIndex = 13;
            this.lbl_minute.Text = "Minute";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Location = new System.Drawing.Point(5, 216);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(30, 13);
            this.lbl_hour.TabIndex = 12;
            this.lbl_hour.Text = "Hour";
            // 
            // cb_time_minute
            // 
            this.cb_time_minute.FormattingEnabled = true;
            this.cb_time_minute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_time_minute.Location = new System.Drawing.Point(51, 243);
            this.cb_time_minute.Name = "cb_time_minute";
            this.cb_time_minute.Size = new System.Drawing.Size(65, 21);
            this.cb_time_minute.TabIndex = 11;
            // 
            // cb_time_hour
            // 
            this.cb_time_hour.FormattingEnabled = true;
            this.cb_time_hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_time_hour.Location = new System.Drawing.Point(51, 216);
            this.cb_time_hour.Name = "cb_time_hour";
            this.cb_time_hour.Size = new System.Drawing.Size(63, 21);
            this.cb_time_hour.TabIndex = 10;
            // 
            // btn_set_time
            // 
            this.btn_set_time.Location = new System.Drawing.Point(5, 163);
            this.btn_set_time.Name = "btn_set_time";
            this.btn_set_time.Size = new System.Drawing.Size(109, 47);
            this.btn_set_time.TabIndex = 9;
            this.btn_set_time.Text = "Set Time";
            this.btn_set_time.UseVisualStyleBackColor = true;
            this.btn_set_time.Click += new System.EventHandler(this.btn_set_time_Click);
            // 
            // tb_timer
            // 
            this.tb_timer.Location = new System.Drawing.Point(6, 19);
            this.tb_timer.Multiline = true;
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(109, 138);
            this.tb_timer.TabIndex = 8;
            // 
            // gb_database
            // 
            this.gb_database.Controls.Add(this.lbl_Node);
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
            this.gb_database.Size = new System.Drawing.Size(336, 426);
            this.gb_database.TabIndex = 19;
            this.gb_database.TabStop = false;
            // 
            // lbl_Node
            // 
            this.lbl_Node.AutoSize = true;
            this.lbl_Node.Location = new System.Drawing.Point(252, 1);
            this.lbl_Node.Name = "lbl_Node";
            this.lbl_Node.Size = new System.Drawing.Size(33, 13);
            this.lbl_Node.TabIndex = 17;
            this.lbl_Node.Text = "Node";
            // 
            // tb_average4
            // 
            this.tb_average4.Location = new System.Drawing.Point(395, 412);
            this.tb_average4.Name = "tb_average4";
            this.tb_average4.Size = new System.Drawing.Size(75, 20);
            this.tb_average4.TabIndex = 21;
            // 
            // tb_database4
            // 
            this.tb_database4.Location = new System.Drawing.Point(395, 26);
            this.tb_database4.Multiline = true;
            this.tb_database4.Name = "tb_database4";
            this.tb_database4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_database4.Size = new System.Drawing.Size(75, 380);
            this.tb_database4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.tb_average4);
            this.Controls.Add(this.tb_database4);
            this.Controls.Add(this.gb_connect);
            this.Controls.Add(this.gb_time);
            this.Controls.Add(this.gb_database);
            this.Name = "Form1";
            this.Text = "SensorGui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_connect.ResumeLayout(false);
            this.gb_connect.PerformLayout();
            this.gb_time.ResumeLayout(false);
            this.gb_time.PerformLayout();
            this.gb_database.ResumeLayout(false);
            this.gb_database.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_connect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_connect;
        private System.IO.Ports.SerialPort uart;
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
        private System.Windows.Forms.GroupBox gb_time;
        private System.Windows.Forms.GroupBox gb_database;
        private System.Windows.Forms.TextBox tb_average4;
        private System.Windows.Forms.TextBox tb_database4;
        private System.Windows.Forms.Label lbl_Node;
        private System.Windows.Forms.TextBox tb_timer;
        private System.Windows.Forms.Button btn_set_time;
        private System.Windows.Forms.ComboBox cb_time_hour;
        private System.Windows.Forms.ComboBox cb_time_minute;
        private System.Windows.Forms.ComboBox cb_duration;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_minute;
        private System.Windows.Forms.Label lbl_hour;
    }
}

