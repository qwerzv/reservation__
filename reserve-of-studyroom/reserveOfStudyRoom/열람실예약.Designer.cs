
namespace reserveOfStudyRoom
{
    partial class 열람실예약
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 69);
            this.button2.TabIndex = 36;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 69);
            this.button1.TabIndex = 35;
            this.button1.Text = "예약하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(275, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 36);
            this.label16.TabIndex = 34;
            this.label16.Text = "좌석";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(244, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 36);
            this.label15.TabIndex = 33;
            this.label15.Text = "배정시간";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(382, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 50);
            this.label13.TabIndex = 31;
            this.label13.Text = "배정 시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(382, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "선택한 좌석";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(272, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 54);
            this.label4.TabIndex = 29;
            this.label4.Text = "예약 확인";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(327, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "열람실";
            // 
            // 열람실예약
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "열람실예약";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.열람실예약_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
    }
}