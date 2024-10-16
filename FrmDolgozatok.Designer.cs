namespace WFA24101601
{
    partial class FrmDolgozatok
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
            lblUI01 = new Label();
            tbNev = new TextBox();
            btnAdatbevitel = new Button();
            rtbDolgozatok = new RichTextBox();
            lblUI02 = new Label();
            tbPontszam = new TextBox();
            lblUI03 = new Label();
            lblAtlag = new Label();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(60, 32);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(49, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Név:";
            // 
            // tbNev
            // 
            tbNev.Location = new Point(122, 29);
            tbNev.Name = "tbNev";
            tbNev.Size = new Size(241, 32);
            tbNev.TabIndex = 0;
            // 
            // btnAdatbevitel
            // 
            btnAdatbevitel.Location = new Point(12, 122);
            btnAdatbevitel.Name = "btnAdatbevitel";
            btnAdatbevitel.Size = new Size(351, 41);
            btnAdatbevitel.TabIndex = 2;
            btnAdatbevitel.Text = "Adatbevitel";
            btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // rtbDolgozatok
            // 
            rtbDolgozatok.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtbDolgozatok.Location = new Point(12, 169);
            rtbDolgozatok.Name = "rtbDolgozatok";
            rtbDolgozatok.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbDolgozatok.Size = new Size(351, 207);
            rtbDolgozatok.TabIndex = 100;
            rtbDolgozatok.TabStop = false;
            rtbDolgozatok.Text = "";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 77);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(97, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Pontszám:";
            // 
            // tbPontszam
            // 
            tbPontszam.Location = new Point(122, 74);
            tbPontszam.Name = "tbPontszam";
            tbPontszam.Size = new Size(241, 32);
            tbPontszam.TabIndex = 1;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUI03.Location = new Point(12, 393);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(148, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "átlagpontszám:";
            // 
            // lblAtlag
            // 
            lblAtlag.AutoSize = true;
            lblAtlag.Location = new Point(166, 393);
            lblAtlag.Name = "lblAtlag";
            lblAtlag.Size = new Size(71, 25);
            lblAtlag.TabIndex = 0;
            lblAtlag.Text = "##.###";
            // 
            // FrmDolgozatok
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 437);
            Controls.Add(rtbDolgozatok);
            Controls.Add(btnAdatbevitel);
            Controls.Add(tbPontszam);
            Controls.Add(tbNev);
            Controls.Add(lblUI03);
            Controls.Add(lblAtlag);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmDolgozatok";
            Text = "Dolgozatok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbNev;
        private Button btnAdatbevitel;
        private RichTextBox rtbDolgozatok;
        private Label lblUI02;
        private TextBox tbPontszam;
        private Label lblUI03;
        private Label lblAtlag;
    }
}
