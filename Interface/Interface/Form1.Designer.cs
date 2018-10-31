namespace Interface
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
            this.components = new System.ComponentModel.Container();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.btnLaggTillKat = new System.Windows.Forms.Button();
            this.btnTaBortKat = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblPoddInfo = new System.Windows.Forms.Label();
            this.lblInfoPodd = new System.Windows.Forms.Label();
            this.tbPodd = new System.Windows.Forms.TextBox();
            this.cbTidInt = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.btnLaggTillPodd = new System.Windows.Forms.Button();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.lbPoddAvsnitt = new System.Windows.Forms.ListBox();
            this.lblPoddcast = new System.Windows.Forms.Label();
            this.btnAndraKat = new System.Windows.Forms.Button();
            this.lvPodcast = new System.Windows.Forms.ListView();
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 20;
            this.lbKategori.Location = new System.Drawing.Point(634, 52);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.ScrollAlwaysVisible = true;
            this.lbKategori.Size = new System.Drawing.Size(349, 144);
            this.lbKategori.TabIndex = 0;
            this.lbKategori.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(634, 215);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(349, 26);
            this.tbKategori.TabIndex = 1;
            // 
            // btnLaggTillKat
            // 
            this.btnLaggTillKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillKat.Location = new System.Drawing.Point(636, 257);
            this.btnLaggTillKat.Name = "btnLaggTillKat";
            this.btnLaggTillKat.Size = new System.Drawing.Size(99, 29);
            this.btnLaggTillKat.TabIndex = 2;
            this.btnLaggTillKat.Text = "Lägg till";
            this.btnLaggTillKat.UseVisualStyleBackColor = true;
            this.btnLaggTillKat.Click += new System.EventHandler(this.btnLaggTillKat_Click);
            // 
            // btnTaBortKat
            // 
            this.btnTaBortKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKat.Location = new System.Drawing.Point(762, 257);
            this.btnTaBortKat.Name = "btnTaBortKat";
            this.btnTaBortKat.Size = new System.Drawing.Size(99, 29);
            this.btnTaBortKat.TabIndex = 3;
            this.btnTaBortKat.Text = "Ta bort";
            this.btnTaBortKat.UseVisualStyleBackColor = true;
            this.btnTaBortKat.Click += new System.EventHandler(this.btnTaBortKat_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(632, 28);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(85, 22);
            this.lblKategori.TabIndex = 4;
            this.lblKategori.Text = "Kategori";
            this.lblKategori.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPoddInfo
            // 
            this.lblPoddInfo.AutoSize = true;
            this.lblPoddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoddInfo.Location = new System.Drawing.Point(632, 318);
            this.lblPoddInfo.Name = "lblPoddInfo";
            this.lblPoddInfo.Size = new System.Drawing.Size(93, 22);
            this.lblPoddInfo.TabIndex = 5;
            this.lblPoddInfo.Text = "Poddcast";
            // 
            // lblInfoPodd
            // 
            this.lblInfoPodd.AutoSize = true;
            this.lblInfoPodd.Location = new System.Drawing.Point(632, 355);
            this.lblInfoPodd.Name = "lblInfoPodd";
            this.lblInfoPodd.Size = new System.Drawing.Size(174, 20);
            this.lblInfoPodd.TabIndex = 6;
            this.lblInfoPodd.Text = "Beskrivning av avsnittet";
            this.lblInfoPodd.Click += new System.EventHandler(this.lblInfoPodd_Click);
            // 
            // tbPodd
            // 
            this.tbPodd.Location = new System.Drawing.Point(186, 215);
            this.tbPodd.Name = "tbPodd";
            this.tbPodd.Size = new System.Drawing.Size(112, 26);
            this.tbPodd.TabIndex = 8;
            // 
            // cbTidInt
            // 
            this.cbTidInt.FormattingEnabled = true;
            this.cbTidInt.Location = new System.Drawing.Point(321, 212);
            this.cbTidInt.Name = "cbTidInt";
            this.cbTidInt.Size = new System.Drawing.Size(121, 28);
            this.cbTidInt.TabIndex = 9;
            this.cbTidInt.SelectedIndexChanged += new System.EventHandler(this.cbTidInt_SelectedIndexChanged);
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(464, 212);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 28);
            this.cbKategori.TabIndex = 10;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // btnLaggTillPodd
            // 
            this.btnLaggTillPodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillPodd.Location = new System.Drawing.Point(381, 254);
            this.btnLaggTillPodd.Name = "btnLaggTillPodd";
            this.btnLaggTillPodd.Size = new System.Drawing.Size(75, 32);
            this.btnLaggTillPodd.TabIndex = 11;
            this.btnLaggTillPodd.Text = "Lägg till";
            this.btnLaggTillPodd.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortPodd.Location = new System.Drawing.Point(492, 254);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(93, 32);
            this.btnTaBortPodd.TabIndex = 12;
            this.btnTaBortPodd.Text = "Ta bort";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            // 
            // lbPoddAvsnitt
            // 
            this.lbPoddAvsnitt.FormattingEnabled = true;
            this.lbPoddAvsnitt.ItemHeight = 20;
            this.lbPoddAvsnitt.Location = new System.Drawing.Point(63, 318);
            this.lbPoddAvsnitt.Name = "lbPoddAvsnitt";
            this.lbPoddAvsnitt.ScrollAlwaysVisible = true;
            this.lbPoddAvsnitt.Size = new System.Drawing.Size(522, 164);
            this.lbPoddAvsnitt.TabIndex = 13;
            this.lbPoddAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lblPoddcast
            // 
            this.lblPoddcast.AutoSize = true;
            this.lblPoddcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoddcast.Location = new System.Drawing.Point(63, 292);
            this.lblPoddcast.Name = "lblPoddcast";
            this.lblPoddcast.Size = new System.Drawing.Size(93, 22);
            this.lblPoddcast.TabIndex = 15;
            this.lblPoddcast.Text = "Poddcast";
            // 
            // btnAndraKat
            // 
            this.btnAndraKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndraKat.Location = new System.Drawing.Point(886, 257);
            this.btnAndraKat.Name = "btnAndraKat";
            this.btnAndraKat.Size = new System.Drawing.Size(99, 29);
            this.btnAndraKat.TabIndex = 17;
            this.btnAndraKat.Text = "Ändra";
            this.btnAndraKat.UseVisualStyleBackColor = true;
            this.btnAndraKat.Click += new System.EventHandler(this.btnAndraKat_Click);
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.lvPodcast.Location = new System.Drawing.Point(42, 18);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(541, 178);
            this.lvPodcast.TabIndex = 18;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            this.lvPodcast.SelectedIndexChanged += new System.EventHandler(this.lvPodcast_SelectedIndexChanged);
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 157;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            this.Frekvens.Width = 61;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 26);
            this.textBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 520);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvPodcast);
            this.Controls.Add(this.btnAndraKat);
            this.Controls.Add(this.lblPoddcast);
            this.Controls.Add(this.lbPoddAvsnitt);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.btnLaggTillPodd);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbTidInt);
            this.Controls.Add(this.tbPodd);
            this.Controls.Add(this.lblInfoPodd);
            this.Controls.Add(this.lblPoddInfo);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnTaBortKat);
            this.Controls.Add(this.btnLaggTillKat);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.lbKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKategori;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button btnLaggTillKat;
        private System.Windows.Forms.Button btnTaBortKat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblPoddInfo;
        private System.Windows.Forms.Label lblInfoPodd;
        private System.Windows.Forms.TextBox tbPodd;
        private System.Windows.Forms.ComboBox cbTidInt;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button btnLaggTillPodd;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.ListBox lbPoddAvsnitt;
        private System.Windows.Forms.Label lblPoddcast;
        private System.Windows.Forms.Button btnAndraKat;
        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

