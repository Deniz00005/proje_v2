namespace proje_v1
{
    partial class Enterance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enterance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.enterBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adminBut = new System.Windows.Forms.RadioButton();
            this.scoutBut = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(60, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label2.Location = new System.Drawing.Point(177, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.userNameTxt.Location = new System.Drawing.Point(347, 183);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(323, 47);
            this.userNameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.passwordTxt.Location = new System.Drawing.Point(347, 241);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(323, 47);
            this.passwordTxt.TabIndex = 2;
            // 
            // enterBut
            // 
            this.enterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.enterBut.Location = new System.Drawing.Point(347, 376);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(323, 51);
            this.enterBut.TabIndex = 5;
            this.enterBut.Text = "Giriş";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.exitBut.Location = new System.Drawing.Point(347, 433);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(323, 51);
            this.exitBut.TabIndex = 6;
            this.exitBut.Text = "Çıkış";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label3.Location = new System.Drawing.Point(52, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oturum Türü :";
            // 
            // adminBut
            // 
            this.adminBut.AutoSize = true;
            this.adminBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.adminBut.Location = new System.Drawing.Point(359, 303);
            this.adminBut.Name = "adminBut";
            this.adminBut.Size = new System.Drawing.Size(134, 43);
            this.adminBut.TabIndex = 3;
            this.adminBut.TabStop = true;
            this.adminBut.Text = "Admin";
            this.adminBut.UseVisualStyleBackColor = true;
            // 
            // scoutBut
            // 
            this.scoutBut.AutoSize = true;
            this.scoutBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.scoutBut.Location = new System.Drawing.Point(533, 303);
            this.scoutBut.Name = "scoutBut";
            this.scoutBut.Size = new System.Drawing.Size(124, 43);
            this.scoutBut.TabIndex = 4;
            this.scoutBut.TabStop = true;
            this.scoutBut.Text = "Scout";
            this.scoutBut.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label4.Location = new System.Drawing.Point(196, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Futbolcu Takip Sistemi";
            // 
            // Enterance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scoutBut);
            this.Controls.Add(this.adminBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.enterBut);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enterance";
            this.Text = "Futbolcu Takip Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button enterBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton adminBut;
        private System.Windows.Forms.RadioButton scoutBut;
        private System.Windows.Forms.Label label4;
    }
}

