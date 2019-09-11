namespace TestSendPostRequest
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
            this.startB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.resTB = new System.Windows.Forms.TextBox();
            this.stopB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileCounterL = new System.Windows.Forms.Label();
            this.AutoResetCB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postRequestTB = new System.Windows.Forms.TextBox();
            this.milisecondsTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BaseRecorderIDTB = new System.Windows.Forms.TextBox();
            this.NumberRecorderIDTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(373, 6);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(58, 23);
            this.startB.TabIndex = 0;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(50, 6);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(306, 20);
            this.urlTB.TabIndex = 2;
            this.urlTB.Text = "http://192.168.0.146/MvcTest/Api/UploadMdt2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File In Post Request:";
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(514, 77);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(312, 20);
            this.fileTB.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resTB
            // 
            this.resTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resTB.Location = new System.Drawing.Point(2, 113);
            this.resTB.Multiline = true;
            this.resTB.Name = "resTB";
            this.resTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resTB.Size = new System.Drawing.Size(869, 368);
            this.resTB.TabIndex = 6;
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(437, 6);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(58, 23);
            this.stopB.TabIndex = 7;
            this.stopB.Text = "Stop";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "File counter:";
            // 
            // fileCounterL
            // 
            this.fileCounterL.AutoSize = true;
            this.fileCounterL.Location = new System.Drawing.Point(858, 16);
            this.fileCounterL.Name = "fileCounterL";
            this.fileCounterL.Size = new System.Drawing.Size(13, 13);
            this.fileCounterL.TabIndex = 9;
            this.fileCounterL.Text = "0";
            // 
            // AutoResetCB
            // 
            this.AutoResetCB.AutoSize = true;
            this.AutoResetCB.Checked = true;
            this.AutoResetCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoResetCB.Location = new System.Drawing.Point(12, 32);
            this.AutoResetCB.Name = "AutoResetCB";
            this.AutoResetCB.Size = new System.Drawing.Size(252, 17);
            this.AutoResetCB.TabIndex = 10;
            this.AutoResetCB.Text = "Изпълни само 1 път действирто на таимера";
            this.AutoResetCB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "POST Request Counts";
            // 
            // postRequestTB
            // 
            this.postRequestTB.Location = new System.Drawing.Point(129, 61);
            this.postRequestTB.Name = "postRequestTB";
            this.postRequestTB.Size = new System.Drawing.Size(100, 20);
            this.postRequestTB.TabIndex = 12;
            this.postRequestTB.Text = "100";
            // 
            // milisecondsTB
            // 
            this.milisecondsTB.Location = new System.Drawing.Point(129, 87);
            this.milisecondsTB.Name = "milisecondsTB";
            this.milisecondsTB.Size = new System.Drawing.Size(100, 20);
            this.milisecondsTB.TabIndex = 13;
            this.milisecondsTB.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Timer Milisecond";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "RecorderID:";
            // 
            // BaseRecorderIDTB
            // 
            this.BaseRecorderIDTB.Location = new System.Drawing.Point(514, 48);
            this.BaseRecorderIDTB.Name = "BaseRecorderIDTB";
            this.BaseRecorderIDTB.Size = new System.Drawing.Size(94, 20);
            this.BaseRecorderIDTB.TabIndex = 16;
            this.BaseRecorderIDTB.Text = "DEV-0021";
            // 
            // NumberRecorderIDTB
            // 
            this.NumberRecorderIDTB.Location = new System.Drawing.Point(614, 48);
            this.NumberRecorderIDTB.Name = "NumberRecorderIDTB";
            this.NumberRecorderIDTB.Size = new System.Drawing.Size(94, 20);
            this.NumberRecorderIDTB.TabIndex = 17;
            this.NumberRecorderIDTB.Text = "4000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 493);
            this.Controls.Add(this.NumberRecorderIDTB);
            this.Controls.Add(this.BaseRecorderIDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.milisecondsTB);
            this.Controls.Add(this.postRequestTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AutoResetCB);
            this.Controls.Add(this.fileCounterL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.resTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox resTB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileCounterL;
        private System.Windows.Forms.CheckBox AutoResetCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postRequestTB;
        private System.Windows.Forms.TextBox milisecondsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BaseRecorderIDTB;
        private System.Windows.Forms.TextBox NumberRecorderIDTB;
    }
}

