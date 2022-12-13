
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
            this.reserveTime = new System.Windows.Forms.Label();
            this.userSelectSeat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 55);
            this.button2.TabIndex = 36;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "예약하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(241, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 29);
            this.label16.TabIndex = 34;
            this.label16.Text = "좌석";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(214, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 29);
            this.label15.TabIndex = 33;
            this.label15.Text = "배정시간";
            // 
            // reserveTime
            // 
            this.reserveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reserveTime.Location = new System.Drawing.Point(334, 150);
            this.reserveTime.Name = "reserveTime";
            this.reserveTime.Size = new System.Drawing.Size(255, 40);
            this.reserveTime.TabIndex = 31;
            this.reserveTime.Text = "배정 시간";
            // 
            // userSelectSeat
            // 
            this.userSelectSeat.AutoSize = true;
            this.userSelectSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userSelectSeat.Location = new System.Drawing.Point(334, 186);
            this.userSelectSeat.Name = "userSelectSeat";
            this.userSelectSeat.Size = new System.Drawing.Size(74, 20);
            this.userSelectSeat.TabIndex = 30;
            this.userSelectSeat.Text = "선택한 좌석";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(238, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 42);
            this.label4.TabIndex = 29;
            this.label4.Text = "예약 확인";
            // 
            // roomName
            // 
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roomName.Location = new System.Drawing.Point(286, 102);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(255, 40);
            this.roomName.TabIndex = 37;
            this.roomName.Text = "열람실";
            // 
            // 열람실예약
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.reserveTime);
            this.Controls.Add(this.userSelectSeat);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        public System.Windows.Forms.Label reserveTime;
        public System.Windows.Forms.Label userSelectSeat;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label roomName;
    }
}