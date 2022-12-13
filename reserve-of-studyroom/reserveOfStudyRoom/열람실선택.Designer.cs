
namespace reserveOfStudyRoom
{
    partial class 열람실선택
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
            this.readingRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readingRoom
            // 
            this.readingRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readingRoom.BackColor = System.Drawing.Color.White;
            this.readingRoom.Font = new System.Drawing.Font("굴림", 9F);
            this.readingRoom.ForeColor = System.Drawing.Color.Black;
            this.readingRoom.Location = new System.Drawing.Point(-1, 0);
            this.readingRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readingRoom.Name = "readingRoom";
            this.readingRoom.Size = new System.Drawing.Size(488, 495);
            this.readingRoom.TabIndex = 8;
            this.readingRoom.TabStop = false;
            this.readingRoom.Text = "제1열람실";
            this.readingRoom.UseVisualStyleBackColor = false;
            this.readingRoom.Click += new System.EventHandler(this.readingRoom_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("굴림", 9F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(481, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 495);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "제2열람실";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // 열람실선택
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readingRoom);
            this.Name = "열람실선택";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button readingRoom;
        private System.Windows.Forms.Button button1;
    }
}