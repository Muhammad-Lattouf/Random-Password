namespace Random_txt_1
{
    partial class Form1
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
            this.buttonFond = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.richTextBoxLength = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFond
            // 
            this.buttonFond.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFond.Location = new System.Drawing.Point(12, 147);
            this.buttonFond.Name = "buttonFond";
            this.buttonFond.Size = new System.Drawing.Size(358, 45);
            this.buttonFond.TabIndex = 0;
            this.buttonFond.Text = "أوجد";
            this.buttonFond.UseVisualStyleBackColor = true;
            this.buttonFond.Click += new System.EventHandler(this.buttonFond_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(12, 12);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPassword.Size = new System.Drawing.Size(358, 128);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonDelet
            // 
            this.buttonDelet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelet.Location = new System.Drawing.Point(376, 147);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(74, 45);
            this.buttonDelet.TabIndex = 3;
            this.buttonDelet.Text = "حذف";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // richTextBoxLength
            // 
            this.richTextBoxLength.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLength.Location = new System.Drawing.Point(376, 60);
            this.richTextBoxLength.Name = "richTextBoxLength";
            this.richTextBoxLength.Size = new System.Drawing.Size(74, 81);
            this.richTextBoxLength.TabIndex = 4;
            this.richTextBoxLength.Text = "";
            this.richTextBoxLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxLength_KeyDown);
            this.richTextBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxLength_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "ادخل طول\r\n   الكلمة";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(462, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxLength);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonFond);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password";
            this.Load += new System.EventHandler(this.RandomPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFond;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.RichTextBox richTextBoxLength;
        private System.Windows.Forms.Label label1;
    }
}

