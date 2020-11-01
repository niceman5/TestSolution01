namespace _42.TreeViewTest
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
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTreeLoad = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCommand = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvLocation = new System.Windows.Forms.TreeView();
            this.btnCallapse = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTreeLoad);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(509, 21);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(260, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // btnTreeLoad
            // 
            this.btnTreeLoad.Location = new System.Drawing.Point(292, 19);
            this.btnTreeLoad.Name = "btnTreeLoad";
            this.btnTreeLoad.Size = new System.Drawing.Size(25, 23);
            this.btnTreeLoad.TabIndex = 2;
            this.btnTreeLoad.Text = "T";
            this.btnTreeLoad.UseVisualStyleBackColor = true;
            this.btnTreeLoad.Click += new System.EventHandler(this.btnTreeLoad_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(62, 22);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(224, 20);
            this.txtSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lstCommand);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tvLocation);
            this.groupBox2.Controls.Add(this.btnCallapse);
            this.groupBox2.Controls.Add(this.btnExtend);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "V\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "File";
            // 
            // lstCommand
            // 
            this.lstCommand.FormattingEnabled = true;
            this.lstCommand.Location = new System.Drawing.Point(359, 49);
            this.lstCommand.Name = "lstCommand";
            this.lstCommand.Size = new System.Drawing.Size(410, 95);
            this.lstCommand.TabIndex = 5;
            this.lstCommand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCommand_MouseClick);
            this.lstCommand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCommand_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Commad";
            // 
            // tvLocation
            // 
            this.tvLocation.Location = new System.Drawing.Point(9, 49);
            this.tvLocation.Name = "tvLocation";
            this.tvLocation.Size = new System.Drawing.Size(308, 229);
            this.tvLocation.TabIndex = 3;
            this.tvLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvLocation_MouseDoubleClick);
            // 
            // btnCallapse
            // 
            this.btnCallapse.Location = new System.Drawing.Point(160, 20);
            this.btnCallapse.Name = "btnCallapse";
            this.btnCallapse.Size = new System.Drawing.Size(75, 23);
            this.btnCallapse.TabIndex = 2;
            this.btnCallapse.Text = "Collapse";
            this.btnCallapse.UseVisualStyleBackColor = true;
            this.btnCallapse.Click += new System.EventHandler(this.btnCallapse_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(79, 20);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(75, 23);
            this.btnExtend.TabIndex = 1;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TreeNode";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(707, 368);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLog);
            this.groupBox3.Location = new System.Drawing.Point(13, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 146);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(9, 20);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(760, 121);
            this.lstLog.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(359, 183);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(410, 95);
            this.txtFile.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTreeLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnCallapse;
        private System.Windows.Forms.TreeView tvLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.TextBox txtFile;
    }
}

