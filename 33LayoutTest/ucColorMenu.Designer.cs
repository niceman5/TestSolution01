﻿namespace _33LayoutTest
{
    partial class ucColorMenu
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.cDialogColor = new System.Windows.Forms.ColorDialog();
            this.flMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flMenu
            // 
            this.flMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flMenu.Controls.Add(this.label1);
            this.flMenu.Controls.Add(this.pColor);
            this.flMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flMenu.Location = new System.Drawing.Point(0, 0);
            this.flMenu.Name = "flMenu";
            this.flMenu.Size = new System.Drawing.Size(135, 480);
            this.flMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Select";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.White;
            this.pColor.Location = new System.Drawing.Point(10, 45);
            this.pColor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(100, 25);
            this.pColor.TabIndex = 1;
            this.pColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pColor_MouseClick);
            // 
            // ucColorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flMenu);
            this.Name = "ucColorMenu";
            this.Size = new System.Drawing.Size(135, 480);
            this.Load += new System.EventHandler(this.ucColorMenu_Load);
            this.flMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.ColorDialog cDialogColor;
    }
}
