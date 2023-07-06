namespace Explicitloading
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbMarkalar = new ComboBox();
            label1 = new Label();
            lstModeller = new ListBox();
            Modeller = new Label();
            SuspendLayout();
            // 
            // cmbMarkalar
            // 
            cmbMarkalar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarkalar.FormattingEnabled = true;
            cmbMarkalar.Location = new Point(36, 86);
            cmbMarkalar.Name = "cmbMarkalar";
            cmbMarkalar.Size = new Size(166, 23);
            cmbMarkalar.TabIndex = 0;
            cmbMarkalar.SelectedIndexChanged += cmbMarkalar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Marka seçiniz:";
            // 
            // lstModeller
            // 
            lstModeller.FormattingEnabled = true;
            lstModeller.ItemHeight = 15;
            lstModeller.Location = new Point(36, 150);
            lstModeller.Name = "lstModeller";
            lstModeller.Size = new Size(634, 304);
            lstModeller.TabIndex = 2;
            // 
            // Modeller
            // 
            Modeller.AutoSize = true;
            Modeller.Location = new Point(36, 132);
            Modeller.Name = "Modeller";
            Modeller.Size = new Size(54, 15);
            Modeller.TabIndex = 3;
            Modeller.Text = "Modeller";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 471);
            Controls.Add(Modeller);
            Controls.Add(lstModeller);
            Controls.Add(label1);
            Controls.Add(cmbMarkalar);
            Name = "Form1";
            Text = "Araba Markaları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMarkalar;
        private Label label1;
        private ListBox lstModeller;
        private Label Modeller;
    }
}