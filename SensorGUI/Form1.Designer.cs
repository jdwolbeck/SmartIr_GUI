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
            this.tb_database = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tb_average = new System.Windows.Forms.TextBox();
            this.btn_website = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_website_response = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_connect
            // 
            this.tb_connect.Location = new System.Drawing.Point(127, 418);
            this.tb_connect.Name = "tb_connect";
            this.tb_connect.Size = new System.Drawing.Size(121, 20);
            this.tb_connect.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 391);
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
            this.cb_connect.Location = new System.Drawing.Point(127, 391);
            this.cb_connect.Name = "cb_connect";
            this.cb_connect.Size = new System.Drawing.Size(121, 21);
            this.cb_connect.TabIndex = 2;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(12, 12);
            this.tb_database.Multiline = true;
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(236, 373);
            this.tb_database.TabIndex = 3;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(254, 12);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(90, 23);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // tb_average
            // 
            this.tb_average.Location = new System.Drawing.Point(254, 54);
            this.tb_average.Name = "tb_average";
            this.tb_average.Size = new System.Drawing.Size(90, 20);
            this.tb_average.TabIndex = 5;
            // 
            // btn_website
            // 
            this.btn_website.Location = new System.Drawing.Point(254, 80);
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(90, 49);
            this.btn_website.TabIndex = 6;
            this.btn_website.Text = "Send to Website";
            this.btn_website.UseVisualStyleBackColor = true;
            this.btn_website.Click += new System.EventHandler(this.btn_website_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Running Average";
            // 
            // tb_website_response
            // 
            this.tb_website_response.Location = new System.Drawing.Point(254, 135);
            this.tb_website_response.Multiline = true;
            this.tb_website_response.Name = "tb_website_response";
            this.tb_website_response.Size = new System.Drawing.Size(336, 215);
            this.tb_website_response.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_website_response);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_website);
            this.Controls.Add(this.tb_average);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.cb_connect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_connect);
            this.Name = "Form1";
            this.Text = "SensorGui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_connect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_connect;
        private System.IO.Ports.SerialPort uart;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tb_average;
        private System.Windows.Forms.Button btn_website;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_website_response;
    }
}

