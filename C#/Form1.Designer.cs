namespace Pressure
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tb_COM = new System.Windows.Forms.TextBox();
            this.bt_connect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_saveFile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.tb_timer = new System.Windows.Forms.TextBox();
            this.bt_timer = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tb_COM
            // 
            this.tb_COM.Location = new System.Drawing.Point(31, 24);
            this.tb_COM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_COM.Name = "tb_COM";
            this.tb_COM.Size = new System.Drawing.Size(217, 29);
            this.tb_COM.TabIndex = 0;
            this.tb_COM.Text = "COM";
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(263, 17);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(220, 44);
            this.bt_connect.TabIndex = 1;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 138);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1410, 856);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // bt_saveFile
            // 
            this.bt_saveFile.Location = new System.Drawing.Point(988, 24);
            this.bt_saveFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_saveFile.Name = "bt_saveFile";
            this.bt_saveFile.Size = new System.Drawing.Size(457, 102);
            this.bt_saveFile.TabIndex = 4;
            this.bt_saveFile.Text = "Save File";
            this.bt_saveFile.UseVisualStyleBackColor = true;
            this.bt_saveFile.Click += new System.EventHandler(this.save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(31, 80);
            this.bt_start.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(220, 46);
            this.bt_start.TabIndex = 5;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(263, 80);
            this.bt_stop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(220, 46);
            this.bt_stop.TabIndex = 6;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // tb_timer
            // 
            this.tb_timer.Location = new System.Drawing.Point(498, 24);
            this.tb_timer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(180, 29);
            this.tb_timer.TabIndex = 7;
            // 
            // bt_timer
            // 
            this.bt_timer.Location = new System.Drawing.Point(495, 80);
            this.bt_timer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_timer.Name = "bt_timer";
            this.bt_timer.Size = new System.Drawing.Size(183, 46);
            this.bt_timer.TabIndex = 8;
            this.bt_timer.Text = "Timer";
            this.bt_timer.UseVisualStyleBackColor = true;
            this.bt_timer.Click += new System.EventHandler(this.bt_timer_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(845, 24);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(134, 102);
            this.bt_clear.TabIndex = 9;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 1022);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_timer);
            this.Controls.Add(this.tb_timer);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_saveFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.tb_COM);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tb_COM;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_saveFile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.TextBox tb_timer;
        private System.Windows.Forms.Button bt_timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bt_clear;
    }
}

