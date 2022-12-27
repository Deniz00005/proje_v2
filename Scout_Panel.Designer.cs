namespace proje_v1
{
    partial class Scout_Panel
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
            this.components = new System.ComponentModel.Container();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new proje_v1.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new proje_v1.DataSet1TableAdapters.adminTableAdapter();
            this.futbolcuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.futbolcuTableAdapter = new proje_v1.DataSet1TableAdapters.futbolcuTableAdapter();
            this.backBut = new System.Windows.Forms.Button();
            this.exitBut2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolcuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // futbolcuBindingSource
            // 
            this.futbolcuBindingSource.DataMember = "futbolcu";
            this.futbolcuBindingSource.DataSource = this.dataSet1;
            // 
            // futbolcuTableAdapter
            // 
            this.futbolcuTableAdapter.ClearBeforeFill = true;
            // 
            // backBut
            // 
            this.backBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.backBut.Location = new System.Drawing.Point(439, 547);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(323, 51);
            this.backBut.TabIndex = 7;
            this.backBut.Text = "Geri";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // exitBut2
            // 
            this.exitBut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.exitBut2.Location = new System.Drawing.Point(39, 547);
            this.exitBut2.Name = "exitBut2";
            this.exitBut2.Size = new System.Drawing.Size(323, 51);
            this.exitBut2.TabIndex = 8;
            this.exitBut2.Text = "Çıkış";
            this.exitBut2.UseVisualStyleBackColor = true;
            this.exitBut2.Click += new System.EventHandler(this.exitBut2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button1.Location = new System.Drawing.Point(109, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 130);
            this.button1.TabIndex = 9;
            this.button1.Text = "Futbolcu Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button2.Location = new System.Drawing.Point(309, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 130);
            this.button2.TabIndex = 10;
            this.button2.Text = "Futbolcu Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button3.Location = new System.Drawing.Point(518, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 130);
            this.button3.TabIndex = 11;
            this.button3.Text = "Futbolcu Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button4.Location = new System.Drawing.Point(109, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 130);
            this.button4.TabIndex = 12;
            this.button4.Text = "Futbolcu Tarat";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button5.Location = new System.Drawing.Point(309, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(389, 130);
            this.button5.TabIndex = 13;
            this.button5.Text = "Futbolcuları Listele";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Scout_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBut2);
            this.Controls.Add(this.backBut);
            this.Name = "Scout_Panel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolcuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DataSet1TableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource futbolcuBindingSource;
        private DataSet1TableAdapters.futbolcuTableAdapter futbolcuTableAdapter;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button exitBut2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}