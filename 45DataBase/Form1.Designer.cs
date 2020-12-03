namespace _45DataBase
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDBLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDBLoad);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가져오기";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(6, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(538, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.Location = new System.Drawing.Point(550, 16);
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(87, 23);
            this.btnDBLoad.TabIndex = 1;
            this.btnDBLoad.Text = "DB Load";
            this.btnDBLoad.UseVisualStyleBackColor = true;
            this.btnDBLoad.Click += new System.EventHandler(this.btnDBLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEx1);
            this.groupBox2.Controls.Add(this.btnEx2);
            this.groupBox2.Controls.Add(this.btnEx3);
            this.groupBox2.Controls.Add(this.txtQuery);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(7, 48);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(632, 166);
            this.txtQuery.TabIndex = 0;
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(551, 19);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(87, 23);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "예제3";
            this.btnEx3.UseVisualStyleBackColor = true;
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(458, 19);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(87, 23);
            this.btnEx2.TabIndex = 3;
            this.btnEx2.Text = "예제2";
            this.btnEx2.UseVisualStyleBackColor = true;
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(365, 19);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(87, 23);
            this.btnEx1.TabIndex = 4;
            this.btnEx1.Text = "예제1";
            this.btnEx1.UseVisualStyleBackColor = true;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(563, 326);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(87, 23);
            this.btnExec.TabIndex = 5;
            this.btnExec.Text = "실행";
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgData);
            this.groupBox3.Location = new System.Drawing.Point(13, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 335);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결과";
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(7, 19);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 23;
            this.dgData.Size = new System.Drawing.Size(619, 310);
            this.dgData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 702);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDBLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgData;
    }
}

