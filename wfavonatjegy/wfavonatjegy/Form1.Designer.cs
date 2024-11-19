namespace wfavonatjegy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txkm = new System.Windows.Forms.TextBox();
            this.btszamol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbteljes = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnem = new System.Windows.Forms.RadioButton();
            this.rbigen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "lmenetjegy ára 1 km - 25ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adja meg a km-t egészre felkerekítve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // txkm
            // 
            this.txkm.Location = new System.Drawing.Point(260, 111);
            this.txkm.Name = "txkm";
            this.txkm.Size = new System.Drawing.Size(100, 20);
            this.txkm.TabIndex = 5;
            // 
            // btszamol
            // 
            this.btszamol.Location = new System.Drawing.Point(496, 138);
            this.btszamol.Name = "btszamol";
            this.btszamol.Size = new System.Drawing.Size(75, 23);
            this.btszamol.TabIndex = 8;
            this.btszamol.Text = "Számol";
            this.btszamol.UseVisualStyleBackColor = true;
            this.btszamol.Click += new System.EventHandler(this.btszamol_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbteljes
            // 
            this.rbteljes.AutoSize = true;
            this.rbteljes.Location = new System.Drawing.Point(16, 19);
            this.rbteljes.Name = "rbteljes";
            this.rbteljes.Size = new System.Drawing.Size(71, 17);
            this.rbteljes.TabIndex = 10;
            this.rbteljes.Text = "Teljes árú";
            this.rbteljes.UseVisualStyleBackColor = true;
            this.rbteljes.CheckedChanged += new System.EventHandler(this.rbteljes_CheckedChanged);
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(16, 43);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(59, 17);
            this.rb50.TabIndex = 11;
            this.rb50.TabStop = true;
            this.rb50.Text = "50%-os";
            this.rb50.UseVisualStyleBackColor = true;
            this.rb50.CheckedChanged += new System.EventHandler(this.rb50_CheckedChanged);
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.Location = new System.Drawing.Point(16, 66);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(59, 17);
            this.rb90.TabIndex = 12;
            this.rb90.TabStop = true;
            this.rb90.Text = "90%-os";
            this.rb90.UseVisualStyleBackColor = true;
            this.rb90.CheckedChanged += new System.EventHandler(this.rb90_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb50);
            this.groupBox1.Controls.Add(this.rb90);
            this.groupBox1.Controls.Add(this.rbteljes);
            this.groupBox1.Location = new System.Drawing.Point(74, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menetjegy típusa";
            // 
            // rbnem
            // 
            this.rbnem.AutoSize = true;
            this.rbnem.Location = new System.Drawing.Point(24, 30);
            this.rbnem.Name = "rbnem";
            this.rbnem.Size = new System.Drawing.Size(47, 17);
            this.rbnem.TabIndex = 13;
            this.rbnem.TabStop = true;
            this.rbnem.Text = "Nem";
            this.rbnem.UseVisualStyleBackColor = true;
            this.rbnem.CheckedChanged += new System.EventHandler(this.rbnem_CheckedChanged);
            // 
            // rbigen
            // 
            this.rbigen.AutoSize = true;
            this.rbigen.Location = new System.Drawing.Point(24, 53);
            this.rbigen.Name = "rbigen";
            this.rbigen.Size = new System.Drawing.Size(46, 17);
            this.rbigen.TabIndex = 14;
            this.rbigen.TabStop = true;
            this.rbigen.Text = "Igen";
            this.rbigen.UseVisualStyleBackColor = true;
            this.rbigen.CheckedChanged += new System.EventHandler(this.rbigen_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnem);
            this.groupBox2.Controls.Add(this.rbigen);
            this.groupBox2.Location = new System.Drawing.Point(74, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiegészítő jegy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btszamol);
            this.Controls.Add(this.txkm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menetjegy 2.verzió";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txkm;
        private System.Windows.Forms.Button btszamol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbteljes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnem;
        private System.Windows.Forms.RadioButton rbigen;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

