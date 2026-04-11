namespace egzaminsprawdzianedesktop
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
            pictureBox1 = new PictureBox();
            przyciskprzod = new Button();
            przycisktyl = new Button();
            przyciskPobierz = new Button();
            labelWykonawca = new Label();
            labelTytul = new Label();
            labelIlosc = new Label();
            labelrokWydania = new Label();
            labelPobrania = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.obraz;
            pictureBox1.Location = new Point(155, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // przyciskprzod
            // 
            przyciskprzod.FlatAppearance.BorderSize = 0;
            przyciskprzod.FlatStyle = FlatStyle.Flat;
            przyciskprzod.Image = Properties.Resources.obraz2;
            przyciskprzod.Location = new Point(1018, 155);
            przyciskprzod.Name = "przyciskprzod";
            przyciskprzod.Size = new Size(96, 70);
            przyciskprzod.TabIndex = 1;
            przyciskprzod.UseVisualStyleBackColor = true;
            przyciskprzod.Click += przyciskprzod_Click;
            // 
            // przycisktyl
            // 
            przycisktyl.FlatAppearance.BorderSize = 0;
            przycisktyl.FlatStyle = FlatStyle.Flat;
            przycisktyl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            przycisktyl.Image = Properties.Resources.obraz3;
            przycisktyl.Location = new Point(12, 155);
            przycisktyl.Name = "przycisktyl";
            przycisktyl.Size = new Size(96, 70);
            przycisktyl.TabIndex = 2;
            przycisktyl.UseVisualStyleBackColor = true;
            przycisktyl.Click += przycisktyl_Click;
            // 
            // przyciskPobierz
            // 
            przyciskPobierz.BackColor = Color.FromArgb(97, 217, 24);
            przyciskPobierz.FlatAppearance.BorderSize = 0;
            przyciskPobierz.FlatStyle = FlatStyle.Flat;
            przyciskPobierz.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            przyciskPobierz.ForeColor = SystemColors.ControlText;
            przyciskPobierz.Location = new Point(290, 275);
            przyciskPobierz.Name = "przyciskPobierz";
            przyciskPobierz.Size = new Size(91, 41);
            przyciskPobierz.TabIndex = 3;
            przyciskPobierz.Text = "Pobierz";
            przyciskPobierz.UseVisualStyleBackColor = false;
            przyciskPobierz.Click += przyciskPobierz_Click;
            // 
            // labelWykonawca
            // 
            labelWykonawca.AutoSize = true;
            labelWykonawca.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelWykonawca.ForeColor = Color.White;
            labelWykonawca.Location = new Point(361, 33);
            labelWykonawca.Name = "labelWykonawca";
            labelWykonawca.Size = new Size(160, 67);
            labelWykonawca.TabIndex = 4;
            labelWykonawca.Text = "label1";
            // 
            // labelTytul
            // 
            labelTytul.AutoSize = true;
            labelTytul.Font = new Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Pixel);
            labelTytul.ForeColor = Color.White;
            labelTytul.Location = new Point(376, 100);
            labelTytul.Name = "labelTytul";
            labelTytul.Size = new Size(97, 41);
            labelTytul.TabIndex = 5;
            labelTytul.Text = "label1";
            // 
            // labelIlosc
            // 
            labelIlosc.AutoSize = true;
            labelIlosc.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelIlosc.ForeColor = Color.FromArgb(97, 217, 24);
            labelIlosc.Location = new Point(376, 171);
            labelIlosc.Name = "labelIlosc";
            labelIlosc.Size = new Size(65, 28);
            labelIlosc.TabIndex = 6;
            labelIlosc.Text = "label1";
            // 
            // labelrokWydania
            // 
            labelrokWydania.AutoSize = true;
            labelrokWydania.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelrokWydania.ForeColor = Color.FromArgb(97, 217, 24);
            labelrokWydania.Location = new Point(601, 172);
            labelrokWydania.Name = "labelrokWydania";
            labelrokWydania.Size = new Size(65, 28);
            labelrokWydania.TabIndex = 7;
            labelrokWydania.Text = "label1";
            // 
            // labelPobrania
            // 
            labelPobrania.AutoSize = true;
            labelPobrania.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelPobrania.ForeColor = Color.FromArgb(97, 217, 24);
            labelPobrania.Location = new Point(155, 281);
            labelPobrania.Name = "labelPobrania";
            labelPobrania.Size = new Size(65, 28);
            labelPobrania.TabIndex = 8;
            labelPobrania.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1143, 363);
            Controls.Add(labelPobrania);
            Controls.Add(labelrokWydania);
            Controls.Add(labelIlosc);
            Controls.Add(labelTytul);
            Controls.Add(labelWykonawca);
            Controls.Add(przyciskPobierz);
            Controls.Add(przycisktyl);
            Controls.Add(przyciskprzod);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "MojeDzwieki Wykonal: 00000000000";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button przyciskprzod;
        private Button przycisktyl;
        private Button przyciskPobierz;
        private Label labelWykonawca;
        private Label labelTytul;
        private Label labelIlosc;
        private Label labelrokWydania;
        private Label labelPobrania;
    }
}
