namespace _36LinkedListSortedList
{
    partial class Form1
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
            this.mcSchedule = new System.Windows.Forms.MonthCalendar();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mcSchedule
            // 
            this.mcSchedule.Location = new System.Drawing.Point(18, 18);
            this.mcSchedule.MaxSelectionCount = 1;
            this.mcSchedule.Name = "mcSchedule";
            this.mcSchedule.TabIndex = 0;
            this.mcSchedule.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcSchedule_DateChanged);
            // 
            // txtSchedule
            // 
            this.txtSchedule.Location = new System.Drawing.Point(18, 192);
            this.txtSchedule.Multiline = true;
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(220, 146);
            this.txtSchedule.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(18, 347);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(220, 28);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "일정 등록하기";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lstSchedule
            // 
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.Location = new System.Drawing.Point(250, 18);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(352, 355);
            this.lstSchedule.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 398);
            this.Controls.Add(this.lstSchedule);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.txtSchedule);
            this.Controls.Add(this.mcSchedule);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcSchedule;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.ListBox lstSchedule;
    }
}

