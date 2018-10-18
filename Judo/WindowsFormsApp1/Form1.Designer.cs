namespace WindowsFormsApp1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxdamer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbxherrar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tungvikt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ltungvikt = new System.Windows.Forms.Label();
            this.Mellanvikt = new System.Windows.Forms.Label();
            this.Hmellanvikt = new System.Windows.Forms.Label();
            this.Lättvikt = new System.Windows.Forms.Label();
            this.hlättvikt = new System.Windows.Forms.Label();
            this.extralättvikt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gult",
            "Orange",
            "Grönt",
            "Blått",
            "Brunt",
            "Svart"});
            this.comboBox1.Location = new System.Drawing.Point(151, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose your belt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(286, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Done!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(8, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First and lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chose your wight:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // cbxdamer
            // 
            this.cbxdamer.FormattingEnabled = true;
            this.cbxdamer.Items.AddRange(new object[] {
            "+78",
            "70-78",
            "63-70",
            "57-63",
            "52-57",
            "48-52",
            "-48"});
            this.cbxdamer.Location = new System.Drawing.Point(-1000, -1000);
            this.cbxdamer.Name = "cbxdamer";
            this.cbxdamer.Size = new System.Drawing.Size(121, 21);
            this.cbxdamer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chose your gender:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Herr",
            "Dam"});
            this.comboBox3.Location = new System.Drawing.Point(151, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbxherrar
            // 
            this.cbxherrar.FormattingEnabled = true;
            this.cbxherrar.Items.AddRange(new object[] {
            "+100",
            "90-100",
            "81-90",
            "73-81",
            "66-73",
            "60-66",
            "-60"});
            this.cbxherrar.Location = new System.Drawing.Point(-1000, -1000);
            this.cbxherrar.Name = "cbxherrar";
            this.cbxherrar.Size = new System.Drawing.Size(121, 21);
            this.cbxherrar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(-8, -218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "According to your valid information, you are going to play in:";
            // 
            // tungvikt
            // 
            this.tungvikt.AutoSize = true;
            this.tungvikt.ForeColor = System.Drawing.Color.White;
            this.tungvikt.Location = new System.Drawing.Point(-312, -175);
            this.tungvikt.Name = "tungvikt";
            this.tungvikt.Size = new System.Drawing.Size(49, 13);
            this.tungvikt.TabIndex = 12;
            this.tungvikt.Text = "Tungvikt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(295, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // Ltungvikt
            // 
            this.Ltungvikt.AutoSize = true;
            this.Ltungvikt.ForeColor = System.Drawing.Color.White;
            this.Ltungvikt.Location = new System.Drawing.Point(-55, -199);
            this.Ltungvikt.Name = "Ltungvikt";
            this.Ltungvikt.Size = new System.Drawing.Size(66, 13);
            this.Ltungvikt.TabIndex = 14;
            this.Ltungvikt.Text = "Lätt tungvikt";
            // 
            // Mellanvikt
            // 
            this.Mellanvikt.AutoSize = true;
            this.Mellanvikt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mellanvikt.Location = new System.Drawing.Point(-127, -186);
            this.Mellanvikt.Name = "Mellanvikt";
            this.Mellanvikt.Size = new System.Drawing.Size(55, 13);
            this.Mellanvikt.TabIndex = 15;
            this.Mellanvikt.Text = "Mellanvikt";
            // 
            // Hmellanvikt
            // 
            this.Hmellanvikt.AutoSize = true;
            this.Hmellanvikt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hmellanvikt.Location = new System.Drawing.Point(-229, -186);
            this.Hmellanvikt.Name = "Hmellanvikt";
            this.Hmellanvikt.Size = new System.Drawing.Size(79, 13);
            this.Hmellanvikt.TabIndex = 16;
            this.Hmellanvikt.Text = "Halv mellanvikt";
            // 
            // Lättvikt
            // 
            this.Lättvikt.AutoSize = true;
            this.Lättvikt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lättvikt.Location = new System.Drawing.Point(-302, -199);
            this.Lättvikt.Name = "Lättvikt";
            this.Lättvikt.Size = new System.Drawing.Size(42, 13);
            this.Lättvikt.TabIndex = 17;
            this.Lättvikt.Text = "Lättvikt";
            // 
            // hlättvikt
            // 
            this.hlättvikt.AutoSize = true;
            this.hlättvikt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hlättvikt.Location = new System.Drawing.Point(-44, -252);
            this.hlättvikt.Name = "hlättvikt";
            this.hlättvikt.Size = new System.Drawing.Size(63, 13);
            this.hlättvikt.TabIndex = 18;
            this.hlättvikt.Text = "Halv lättvikt";
            // 
            // extralättvikt
            // 
            this.extralättvikt.AutoSize = true;
            this.extralättvikt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.extralättvikt.Location = new System.Drawing.Point(-130, -251);
            this.extralättvikt.Name = "extralättvikt";
            this.extralättvikt.Size = new System.Drawing.Size(62, 13);
            this.extralättvikt.TabIndex = 19;
            this.extralättvikt.Text = "Extralättvikt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 287);
            this.Controls.Add(this.extralättvikt);
            this.Controls.Add(this.hlättvikt);
            this.Controls.Add(this.Lättvikt);
            this.Controls.Add(this.Hmellanvikt);
            this.Controls.Add(this.Mellanvikt);
            this.Controls.Add(this.Ltungvikt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tungvikt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxherrar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxdamer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxdamer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbxherrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tungvikt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ltungvikt;
        private System.Windows.Forms.Label Mellanvikt;
        private System.Windows.Forms.Label Hmellanvikt;
        private System.Windows.Forms.Label Lättvikt;
        private System.Windows.Forms.Label hlättvikt;
        private System.Windows.Forms.Label extralättvikt;
    }
}

