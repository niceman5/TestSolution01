namespace _42.ListTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNo = new System.Windows.Forms.ListBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.lstChangeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChangeOld = new System.Windows.Forms.TextBox();
            this.txtChangeNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChnageList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(99, 22);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(97, 48);
            this.numPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(62, 20);
            this.numPosition.TabIndex = 3;
            this.numPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(135, 91);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 27);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "List";
            // 
            // lstNo
            // 
            this.lstNo.FormattingEnabled = true;
            this.lstNo.Location = new System.Drawing.Point(29, 157);
            this.lstNo.Name = "lstNo";
            this.lstNo.Size = new System.Drawing.Size(41, 303);
            this.lstNo.TabIndex = 7;
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(76, 157);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(157, 303);
            this.lstList.TabIndex = 8;
            // 
            // lstChangeList
            // 
            this.lstChangeList.FormattingEnabled = true;
            this.lstChangeList.Location = new System.Drawing.Point(269, 157);
            this.lstChangeList.Name = "lstChangeList";
            this.lstChangeList.Size = new System.Drawing.Size(157, 303);
            this.lstChangeList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ChangeList";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "검사";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "수정";
            // 
            // txtChangeOld
            // 
            this.txtChangeOld.Location = new System.Drawing.Point(307, 22);
            this.txtChangeOld.Name = "txtChangeOld";
            this.txtChangeOld.Size = new System.Drawing.Size(100, 20);
            this.txtChangeOld.TabIndex = 13;
            // 
            // txtChangeNew
            // 
            this.txtChangeNew.Location = new System.Drawing.Point(307, 51);
            this.txtChangeNew.Name = "txtChangeNew";
            this.txtChangeNew.Size = new System.Drawing.Size(100, 20);
            this.txtChangeNew.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "List Detail";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(307, 91);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 27);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // txtList
            // 
            this.txtList.Enabled = false;
            this.txtList.Location = new System.Drawing.Point(494, 51);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(265, 20);
            this.txtList.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ChnageList Detail";
            // 
            // txtChnageList
            // 
            this.txtChnageList.Enabled = false;
            this.txtChnageList.Location = new System.Drawing.Point(494, 269);
            this.txtChnageList.Name = "txtChnageList";
            this.txtChnageList.Size = new System.Drawing.Size(265, 20);
            this.txtChnageList.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.txtChnageList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChangeNew);
            this.Controls.Add(this.txtChangeOld);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstChangeList);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.lstNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNo;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.ListBox lstChangeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChangeOld;
        private System.Windows.Forms.TextBox txtChangeNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChnageList;
    }
}

