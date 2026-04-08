namespace RGBEgzamin
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            panel1 = new Panel();
            label1 = new Label();
            ButtonPobierz = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(45, 162);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(716, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 255;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(45, 224);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(716, 56);
            trackBar2.TabIndex = 1;
            trackBar2.Value = 255;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(45, 286);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(716, 56);
            trackBar3.TabIndex = 2;
            trackBar3.Value = 255;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(45, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 69);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 108);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 4;
            label1.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            // 
            // ButtonPobierz
            // 
            ButtonPobierz.BackColor = Color.Peru;
            ButtonPobierz.Location = new Point(302, 331);
            ButtonPobierz.Margin = new Padding(0);
            ButtonPobierz.Name = "ButtonPobierz";
            ButtonPobierz.Size = new Size(181, 43);
            ButtonPobierz.TabIndex = 5;
            ButtonPobierz.Text = "Pobierz";
            ButtonPobierz.UseVisualStyleBackColor = false;
            ButtonPobierz.Click += ButtonPobierz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(338, 391);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "255,255,255";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ButtonPobierz);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "cwel";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Panel panel1;
        private Label label1;
        private Button ButtonPobierz;
        private Label label2;
    }
}
