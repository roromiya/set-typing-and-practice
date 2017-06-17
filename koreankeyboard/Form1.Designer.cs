namespace koreankeyboard
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
            this.Numtxt = new System.Windows.Forms.TextBox();
            this.Stbtn = new System.Windows.Forms.Button();
            this.Clbtn = new System.Windows.Forms.Button();
            this.Numlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numtxt
            // 
            this.Numtxt.Location = new System.Drawing.Point(124, 21);
            this.Numtxt.Name = "Numtxt";
            this.Numtxt.Size = new System.Drawing.Size(148, 21);
            this.Numtxt.TabIndex = 0;
            // 
            // Stbtn
            // 
            this.Stbtn.Location = new System.Drawing.Point(25, 52);
            this.Stbtn.Name = "Stbtn";
            this.Stbtn.Size = new System.Drawing.Size(75, 23);
            this.Stbtn.TabIndex = 1;
            this.Stbtn.Text = "시작";
            this.Stbtn.UseVisualStyleBackColor = true;
            this.Stbtn.Click += new System.EventHandler(this.Stbtn_Click);
            // 
            // Clbtn
            // 
            this.Clbtn.Location = new System.Drawing.Point(184, 52);
            this.Clbtn.Name = "Clbtn";
            this.Clbtn.Size = new System.Drawing.Size(75, 23);
            this.Clbtn.TabIndex = 2;
            this.Clbtn.Text = "닫기";
            this.Clbtn.UseVisualStyleBackColor = true;
            this.Clbtn.Click += new System.EventHandler(this.Clbtn_Click);
            // 
            // Numlb
            // 
            this.Numlb.AutoSize = true;
            this.Numlb.Font = new System.Drawing.Font("Gulim", 13F);
            this.Numlb.Location = new System.Drawing.Point(22, 24);
            this.Numlb.Name = "Numlb";
            this.Numlb.Size = new System.Drawing.Size(86, 18);
            this.Numlb.TabIndex = 3;
            this.Numlb.Text = "문장갯수:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.Numlb);
            this.Controls.Add(this.Clbtn);
            this.Controls.Add(this.Stbtn);
            this.Controls.Add(this.Numtxt);
            this.Name = "Form1";
            this.Text = "한컴타자연습";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numtxt;
        private System.Windows.Forms.Button Stbtn;
        private System.Windows.Forms.Button Clbtn;
        private System.Windows.Forms.Label Numlb;
    }
}

