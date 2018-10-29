namespace Interface
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
            this.btnAndra = new System.Windows.Forms.Button();
            this.tbAndra = new System.Windows.Forms.TextBox();
            this.lbAndra = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(249, 123);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(75, 23);
            this.btnAndra.TabIndex = 1;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            // 
            // tbAndra
            // 
            this.tbAndra.Location = new System.Drawing.Point(13, 123);
            this.tbAndra.Name = "tbAndra";
            this.tbAndra.Size = new System.Drawing.Size(170, 20);
            this.tbAndra.TabIndex = 2;
            // 
            // lbAndra
            // 
            this.lbAndra.FormattingEnabled = true;
            this.lbAndra.Location = new System.Drawing.Point(13, 13);
            this.lbAndra.Name = "lbAndra";
            this.lbAndra.Size = new System.Drawing.Size(311, 95);
            this.lbAndra.TabIndex = 3;
            this.lbAndra.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 161);
            this.Controls.Add(this.lbAndra);
            this.Controls.Add(this.tbAndra);
            this.Controls.Add(this.btnAndra);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.TextBox tbAndra;
        private System.Windows.Forms.ListBox lbAndra;
    }
}