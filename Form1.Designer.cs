namespace HobbyHazi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ferfi = new System.Windows.Forms.CheckBox();
            this.no = new System.Windows.Forms.CheckBox();
            this.HozzadasG = new System.Windows.Forms.Button();
            this.MentesG = new System.Windows.Forms.Button();
            this.betoltesG = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nevbox = new System.Windows.Forms.TextBox();
            this.hobbybox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Szül. Dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kedvenc Hobby";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Új Hobby";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(90, 65);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(43, 17);
            this.ferfi.TabIndex = 6;
            this.ferfi.Text = "férfi";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(139, 65);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(38, 17);
            this.no.TabIndex = 7;
            this.no.Text = "nő";
            this.no.UseVisualStyleBackColor = true;
            // 
            // HozzadasG
            // 
            this.HozzadasG.Location = new System.Drawing.Point(130, 295);
            this.HozzadasG.Name = "HozzadasG";
            this.HozzadasG.Size = new System.Drawing.Size(75, 23);
            this.HozzadasG.TabIndex = 8;
            this.HozzadasG.Text = "Hozzáadás";
            this.HozzadasG.UseVisualStyleBackColor = true;
            this.HozzadasG.Click += new System.EventHandler(this.HozzadasG_Click);
            // 
            // MentesG
            // 
            this.MentesG.Location = new System.Drawing.Point(296, 254);
            this.MentesG.Name = "MentesG";
            this.MentesG.Size = new System.Drawing.Size(75, 23);
            this.MentesG.TabIndex = 9;
            this.MentesG.Text = "Mentés";
            this.MentesG.UseVisualStyleBackColor = true;
            this.MentesG.Click += new System.EventHandler(this.MentesG_Click);
            // 
            // betoltesG
            // 
            this.betoltesG.Location = new System.Drawing.Point(296, 295);
            this.betoltesG.Name = "betoltesG";
            this.betoltesG.Size = new System.Drawing.Size(75, 23);
            this.betoltesG.TabIndex = 10;
            this.betoltesG.Text = "Betöltés";
            this.betoltesG.UseVisualStyleBackColor = true;
            this.betoltesG.Click += new System.EventHandler(this.BetoltesG_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(104, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            // 
            // nevbox
            // 
            this.nevbox.Location = new System.Drawing.Point(90, 27);
            this.nevbox.Name = "nevbox";
            this.nevbox.Size = new System.Drawing.Size(134, 20);
            this.nevbox.TabIndex = 12;
            // 
            // hobbybox
            // 
            this.hobbybox.Location = new System.Drawing.Point(105, 256);
            this.hobbybox.Name = "hobbybox";
            this.hobbybox.Size = new System.Drawing.Size(119, 20);
            this.hobbybox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 354);
            this.Controls.Add(this.hobbybox);
            this.Controls.Add(this.nevbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.betoltesG);
            this.Controls.Add(this.MentesG);
            this.Controls.Add(this.HozzadasG);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox ferfi;
        private System.Windows.Forms.CheckBox no;
        private System.Windows.Forms.Button HozzadasG;
        private System.Windows.Forms.Button MentesG;
        private System.Windows.Forms.Button betoltesG;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nevbox;
        private System.Windows.Forms.TextBox hobbybox;
    }
}

