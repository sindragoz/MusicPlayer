namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.musicTrackBar1 = new SoundTrackBar.MusicTrackBar();
            this.nextBtn1 = new buttonPlay.NextBtn();
            this.prevBtn1 = new buttonPlay.PrevBtn();
            this.playBtn1 = new buttonPlay.PlayBtn();
            this.soundSpectrum1 = new SoundSpectrumVisualisation.SoundSpectrum();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(348, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(348, 51);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(362, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(348, 93);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(362, 23);
            this.progressBar3.TabIndex = 4;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(348, 135);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(362, 23);
            this.progressBar4.TabIndex = 5;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(348, 182);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(362, 23);
            this.progressBar5.TabIndex = 6;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(348, 224);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(362, 23);
            this.progressBar6.TabIndex = 7;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(348, 266);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(362, 23);
            this.progressBar7.TabIndex = 8;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(348, 314);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(362, 23);
            this.progressBar8.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 343);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.soundSpectrum1);
            this.panel1.Controls.Add(this.musicTrackBar1);
            this.panel1.Controls.Add(this.nextBtn1);
            this.panel1.Controls.Add(this.prevBtn1);
            this.panel1.Controls.Add(this.playBtn1);
            this.panel1.Location = new System.Drawing.Point(428, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 338);
            this.panel1.TabIndex = 15;
            // 
            // musicTrackBar1
            // 
            this.musicTrackBar1.Clr1 = System.Drawing.Color.Red;
            this.musicTrackBar1.Location = new System.Drawing.Point(16, 303);
            this.musicTrackBar1.MaximumValue = 100;
            this.musicTrackBar1.MinimumValue = 0;
            this.musicTrackBar1.Name = "musicTrackBar1";
            this.musicTrackBar1.Size = new System.Drawing.Size(384, 23);
            this.musicTrackBar1.TabIndex = 17;
            this.musicTrackBar1.Text = "musicTrackBar1";
            this.musicTrackBar1.Value = 0;
            // 
            // nextBtn1
            // 
            this.nextBtn1.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn1.Buttons_Color = System.Drawing.Color.Red;
            this.nextBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn1.Location = new System.Drawing.Point(242, 242);
            this.nextBtn1.Name = "nextBtn1";
            this.nextBtn1.Size = new System.Drawing.Size(50, 50);
            this.nextBtn1.TabIndex = 16;
            this.nextBtn1.Text = "nextBtn1";
            this.nextBtn1.UseVisualStyleBackColor = false;
            // 
            // prevBtn1
            // 
            this.prevBtn1.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn1.Buttons_Color = System.Drawing.Color.Red;
            this.prevBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn1.Location = new System.Drawing.Point(120, 242);
            this.prevBtn1.Name = "prevBtn1";
            this.prevBtn1.Size = new System.Drawing.Size(50, 50);
            this.prevBtn1.TabIndex = 15;
            this.prevBtn1.Text = "prevBtn1";
            this.prevBtn1.UseVisualStyleBackColor = false;
            // 
            // playBtn1
            // 
            this.playBtn1.BackColor = System.Drawing.Color.Transparent;
            this.playBtn1.Buttons_Color = System.Drawing.Color.Red;
            this.playBtn1.FlatAppearance.BorderSize = 0;
            this.playBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn1.Location = new System.Drawing.Point(176, 237);
            this.playBtn1.Name = "playBtn1";
            this.playBtn1.Size = new System.Drawing.Size(60, 60);
            this.playBtn1.TabIndex = 14;
            this.playBtn1.Text = "playBtn1";
            this.playBtn1.UseVisualStyleBackColor = false;
            this.playBtn1.Click += new System.EventHandler(this.playBtn1_Click);
            // 
            // soundSpectrum1
            // 
            this.soundSpectrum1.H_S_Size = 6F;
            this.soundSpectrum1.Location = new System.Drawing.Point(16, 53);
            this.soundSpectrum1.Name = "soundSpectrum1";
            this.soundSpectrum1.Size = new System.Drawing.Size(384, 173);
            this.soundSpectrum1.SpectrumColor = System.Drawing.Color.Red;
            this.soundSpectrum1.TabIndex = 18;
            this.soundSpectrum1.Text = "soundSpectrum1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
      //  private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private buttonPlay.PlayBtn playBtn1;
        private System.Windows.Forms.Panel panel1;
        private buttonPlay.PrevBtn prevBtn1;
        private buttonPlay.NextBtn nextBtn1;
        private SoundTrackBar.MusicTrackBar musicTrackBar1;
        private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum1;
    }
}