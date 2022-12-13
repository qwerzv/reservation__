
namespace reserveOfStudyRoom
{
    partial class intro
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentCertification = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.readingRoom = new System.Windows.Forms.Button();
            this.studyRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentCertification
            // 
            this.studentCertification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentCertification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.studentCertification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentCertification.Location = new System.Drawing.Point(209, 191);
            this.studentCertification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentCertification.Name = "studentCertification";
            this.studentCertification.Size = new System.Drawing.Size(368, 474);
            this.studentCertification.TabIndex = 0;
            this.studentCertification.TabStop = false;
            this.studentCertification.Text = "학생 인증";
            this.studentCertification.UseVisualStyleBackColor = false;
            this.studentCertification.Click += new System.EventHandler(this.studentCertification_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.readingRoom);
            this.panel1.Controls.Add(this.studyRoom);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 1062);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-9, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 125);
            this.label1.TabIndex = 6;
            this.label1.Text = "화면을 터치하여 선택하세요";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // readingRoom
            // 
            this.readingRoom.BackColor = System.Drawing.Color.White;
            this.readingRoom.Font = new System.Drawing.Font("굴림", 9F);
            this.readingRoom.ForeColor = System.Drawing.Color.Black;
            this.readingRoom.Location = new System.Drawing.Point(-6, 0);
            this.readingRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readingRoom.Name = "readingRoom";
            this.readingRoom.Size = new System.Drawing.Size(787, 451);
            this.readingRoom.TabIndex = 5;
            this.readingRoom.TabStop = false;
            this.readingRoom.Text = "열람실 예약하기";
            this.readingRoom.UseVisualStyleBackColor = false;
            this.readingRoom.Click += new System.EventHandler(this.readingRoom_Click);
            // 
            // studyRoom
            // 
            this.studyRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studyRoom.BackColor = System.Drawing.Color.White;
            this.studyRoom.ForeColor = System.Drawing.Color.Black;
            this.studyRoom.Location = new System.Drawing.Point(-13, 532);
            this.studyRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studyRoom.Name = "studyRoom";
            this.studyRoom.Size = new System.Drawing.Size(794, 450);
            this.studyRoom.TabIndex = 4;
            this.studyRoom.TabStop = false;
            this.studyRoom.Text = "스터디룸 예약하기";
            this.studyRoom.UseVisualStyleBackColor = false;
            this.studyRoom.Click += new System.EventHandler(this.studyRoom_Click);
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 1014);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentCertification);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "intro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.intro_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentCertification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button readingRoom;
        private System.Windows.Forms.Button studyRoom;
        private System.Windows.Forms.Label label1;
    }
}

