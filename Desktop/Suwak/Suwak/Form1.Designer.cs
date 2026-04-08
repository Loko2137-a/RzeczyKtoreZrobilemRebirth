namespace Suwak
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
            Paleta = new Label();
            SuwakB = new TrackBar();
            SuwakG = new TrackBar();
            SuawkR = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelB = new Label();
            labelG = new Label();
            labelR = new Label();
            LabelWartosci = new Label();
            ((System.ComponentModel.ISupportInitialize)SuwakB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuwakG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuawkR).BeginInit();
            SuspendLayout();
            // 
            // Paleta
            // 
            Paleta.BorderStyle = BorderStyle.FixedSingle;
            Paleta.Location = new Point(150, 96);
            Paleta.Name = "Paleta";
            Paleta.Size = new Size(200, 120);
            Paleta.TabIndex = 0;
            // 
            // SuwakB
            // 
            SuwakB.AutoSize = false;
            SuwakB.LargeChange = 1;
            SuwakB.Location = new Point(50, 73);
            SuwakB.Maximum = 255;
            SuwakB.Name = "SuwakB";
            SuwakB.RightToLeftLayout = true;
            SuwakB.Size = new Size(400, 20);
            SuwakB.TabIndex = 1;
            SuwakB.TickStyle = TickStyle.None;
            SuwakB.Value = 255;
            SuwakB.Scroll += SuwakB_Scroll;
            // 
            // SuwakG
            // 
            SuwakG.AutoSize = false;
            SuwakG.LargeChange = 1;
            SuwakG.Location = new Point(50, 47);
            SuwakG.Maximum = 255;
            SuwakG.Name = "SuwakG";
            SuwakG.RightToLeftLayout = true;
            SuwakG.Size = new Size(400, 20);
            SuwakG.TabIndex = 2;
            SuwakG.TickStyle = TickStyle.None;
            SuwakG.Value = 255;
            SuwakG.Scroll += SuwakG_Scroll;
            // 
            // SuawkR
            // 
            SuawkR.AutoSize = false;
            SuawkR.LargeChange = 1;
            SuawkR.Location = new Point(50, 21);
            SuawkR.Maximum = 255;
            SuawkR.Name = "SuawkR";
            SuawkR.RightToLeftLayout = true;
            SuawkR.Size = new Size(400, 20);
            SuawkR.TabIndex = 3;
            SuawkR.TickStyle = TickStyle.None;
            SuawkR.Value = 255;
            SuawkR.Scroll += SuawkR_Scroll;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 4;
            label2.Text = "R";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 5;
            label3.Text = "G";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 6;
            label4.Text = "B";
            // 
            // labelB
            // 
            labelB.Font = new Font("Segoe UI", 7F);
            labelB.Location = new Point(447, 73);
            labelB.Name = "labelB";
            labelB.Size = new Size(29, 20);
            labelB.TabIndex = 7;
            labelB.Text = "255";
            // 
            // labelG
            // 
            labelG.Font = new Font("Segoe UI", 7F);
            labelG.Location = new Point(447, 47);
            labelG.Name = "labelG";
            labelG.Size = new Size(29, 20);
            labelG.TabIndex = 8;
            labelG.Text = "255";
            // 
            // labelR
            // 
            labelR.Font = new Font("Segoe UI", 7F);
            labelR.Location = new Point(447, 21);
            labelR.Name = "labelR";
            labelR.Size = new Size(29, 20);
            labelR.TabIndex = 9;
            labelR.Text = "255";
            // 
            // LabelWartosci
            // 
            LabelWartosci.AutoSize = true;
            LabelWartosci.Location = new Point(183, 224);
            LabelWartosci.Name = "LabelWartosci";
            LabelWartosci.Size = new Size(129, 20);
            LabelWartosci.TabIndex = 10;
            LabelWartosci.Text = "RGB (255,255,255)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(482, 253);
            Controls.Add(LabelWartosci);
            Controls.Add(labelR);
            Controls.Add(labelG);
            Controls.Add(labelB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SuawkR);
            Controls.Add(SuwakG);
            Controls.Add(SuwakB);
            Controls.Add(Paleta);
            Name = "Form1";
            Text = "Paleta RGB";
            ((System.ComponentModel.ISupportInitialize)SuwakB).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuwakG).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuawkR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Paleta;
        private TrackBar SuwakB;
        private TrackBar SuwakG;
        private TrackBar SuawkR;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelB;
        private Label labelG;
        private Label labelR;
        private Label LabelWartosci;
    }
}
