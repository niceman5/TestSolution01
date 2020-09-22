namespace DataTable01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.rdoSexFemale = new System.Windows.Forms.RadioButton();
            this.rdoSexMan = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgViewInfo = new System.Windows.Forms.DataGridView();
            this.btnViewDataDelete = new System.Windows.Forms.Button();
            this.cboViewClass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppend);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.rdoSexFemale);
            this.groupBox1.Controls.Add(this.rdoSexMan);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록하기";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(221, 141);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 9;
            this.btnAppend.Text = "등록";
            this.btnAppend.UseVisualStyleBackColor = true;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(96, 112);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(200, 20);
            this.txtRef.TabIndex = 8;
            // 
            // rdoSexFemale
            // 
            this.rdoSexFemale.AutoSize = true;
            this.rdoSexFemale.Location = new System.Drawing.Point(164, 88);
            this.rdoSexFemale.Name = "rdoSexFemale";
            this.rdoSexFemale.Size = new System.Drawing.Size(53, 17);
            this.rdoSexFemale.TabIndex = 7;
            this.rdoSexFemale.TabStop = true;
            this.rdoSexFemale.Text = "여자";
            this.rdoSexFemale.UseVisualStyleBackColor = true;
            // 
            // rdoSexMan
            // 
            this.rdoSexMan.AutoSize = true;
            this.rdoSexMan.Location = new System.Drawing.Point(96, 89);
            this.rdoSexMan.Name = "rdoSexMan";
            this.rdoSexMan.Size = new System.Drawing.Size(53, 17);
            this.rdoSexMan.TabIndex = 6;
            this.rdoSexMan.TabStop = true;
            this.rdoSexMan.Text = "남자";
            this.rdoSexMan.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 20);
            this.txtName.TabIndex = 5;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반",
            "4반",
            ""});
            this.cboClass.Location = new System.Drawing.Point(96, 33);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(71, 21);
            this.cboClass.TabIndex = 4;
            this.cboClass.Text = "1반";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "특기 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "반 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgViewInfo);
            this.groupBox2.Controls.Add(this.btnViewDataDelete);
            this.groupBox2.Controls.Add(this.cboViewClass);
            this.groupBox2.Location = new System.Drawing.Point(31, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용확인";
            // 
            // dgViewInfo
            // 
            this.dgViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInfo.Location = new System.Drawing.Point(17, 52);
            this.dgViewInfo.Name = "dgViewInfo";
            this.dgViewInfo.RowTemplate.Height = 23;
            this.dgViewInfo.Size = new System.Drawing.Size(719, 192);
            this.dgViewInfo.TabIndex = 11;
            // 
            // btnViewDataDelete
            // 
            this.btnViewDataDelete.Location = new System.Drawing.Point(661, 23);
            this.btnViewDataDelete.Name = "btnViewDataDelete";
            this.btnViewDataDelete.Size = new System.Drawing.Size(75, 23);
            this.btnViewDataDelete.TabIndex = 10;
            this.btnViewDataDelete.Text = "삭제";
            this.btnViewDataDelete.UseVisualStyleBackColor = true;
            // 
            // cboViewClass
            // 
            this.cboViewClass.FormattingEnabled = true;
            this.cboViewClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반",
            "4반"});
            this.cboViewClass.Location = new System.Drawing.Point(17, 25);
            this.cboViewClass.Name = "cboViewClass";
            this.cboViewClass.Size = new System.Drawing.Size(91, 21);
            this.cboViewClass.TabIndex = 0;
            this.cboViewClass.Text = "1반";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.RadioButton rdoSexFemale;
        private System.Windows.Forms.RadioButton rdoSexMan;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboViewClass;
        private System.Windows.Forms.Button btnViewDataDelete;
        private System.Windows.Forms.DataGridView dgViewInfo;
    }
}

