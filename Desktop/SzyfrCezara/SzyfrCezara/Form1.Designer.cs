namespace SzyfrCezara
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
            label1 = new Label();
            polePrzedSzyfrem = new TextBox();
            label2 = new Label();
            polePrzesuniecie = new TextBox();
            label3 = new Label();
            poleZaszyfrowane = new TextBox();
            buttonZaszyfruj = new Button();
            buttonZapisz = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 0;
            label1.Text = "Tekst Jawny";
            // 
            // polePrzedSzyfrem
            // 
            polePrzedSzyfrem.Location = new Point(146, 81);
            polePrzedSzyfrem.Name = "polePrzedSzyfrem";
            polePrzedSzyfrem.Size = new Size(266, 24);
            polePrzedSzyfrem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 114);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 2;
            label2.Text = "Przesuniecie";
            // 
            // polePrzesuniecie
            // 
            polePrzesuniecie.Location = new Point(268, 111);
            polePrzesuniecie.Name = "polePrzesuniecie";
            polePrzesuniecie.Size = new Size(110, 24);
            polePrzesuniecie.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 197);
            label3.Name = "label3";
            label3.Size = new Size(170, 17);
            label3.TabIndex = 4;
            label3.Text = "Tekst Zaszyfrowany";
            // 
            // poleZaszyfrowane
            // 
            poleZaszyfrowane.Enabled = false;
            poleZaszyfrowane.Location = new Point(146, 229);
            poleZaszyfrowane.Name = "poleZaszyfrowane";
            poleZaszyfrowane.Size = new Size(266, 24);
            poleZaszyfrowane.TabIndex = 5;
            // 
            // buttonZaszyfruj
            // 
            buttonZaszyfruj.Location = new Point(213, 151);
            buttonZaszyfruj.Name = "buttonZaszyfruj";
            buttonZaszyfruj.Size = new Size(116, 29);
            buttonZaszyfruj.TabIndex = 6;
            buttonZaszyfruj.Text = "Zaszyfruj";
            buttonZaszyfruj.UseVisualStyleBackColor = true;
            buttonZaszyfruj.Click += buttonZaszyfruj_Click;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(188, 277);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(170, 29);
            buttonZapisz.TabIndex = 7;
            buttonZapisz.Text = "Zapisz do pliku";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(buttonZapisz);
            Controls.Add(buttonZaszyfruj);
            Controls.Add(poleZaszyfrowane);
            Controls.Add(label3);
            Controls.Add(polePrzesuniecie);
            Controls.Add(label2);
            Controls.Add(polePrzedSzyfrem);
            Controls.Add(label1);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "Szyfr Cezara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox polePrzedSzyfrem;
        private Label label2;
        private TextBox polePrzesuniecie;
        private Label label3;
        private TextBox poleZaszyfrowane;
        private Button buttonZaszyfruj;
        private Button buttonZapisz;
    }
}
