namespace koreankeyboard
{
    partial class Form2
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
            this.grbox = new System.Windows.Forms.GroupBox();
            this.stbtn = new System.Windows.Forms.Button();
            this.clbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grbox
            // 
            this.grbox.Location = new System.Drawing.Point(12, 10);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(617, 371);
            this.grbox.TabIndex = 2;
            this.grbox.TabStop = false;
            this.grbox.Text = "groupBox1";
            // 
            // stbtn
            // 
            this.stbtn.Location = new System.Drawing.Point(437, 399);
            this.stbtn.Name = "stbtn";
            this.stbtn.Size = new System.Drawing.Size(75, 23);
            this.stbtn.TabIndex = 0;
            this.stbtn.Text = "시작";
            this.stbtn.UseVisualStyleBackColor = true;
            this.stbtn.Click += new System.EventHandler(this.stbtn_Click);
            // 
            // clbtn
            // 
            this.clbtn.Location = new System.Drawing.Point(554, 399);
            this.clbtn.Name = "clbtn";
            this.clbtn.Size = new System.Drawing.Size(75, 23);
            this.clbtn.TabIndex = 1;
            this.clbtn.Text = "닫기";
            this.clbtn.UseVisualStyleBackColor = true;
            this.clbtn.Click += new System.EventHandler(this.clbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 434);
            this.Controls.Add(this.stbtn);
            this.Controls.Add(this.clbtn);
            this.Controls.Add(this.grbox);
            this.Name = "Form2";
            this.Text = "한컴타자연습";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.Button stbtn;
        private System.Windows.Forms.Button clbtn;
    }
}