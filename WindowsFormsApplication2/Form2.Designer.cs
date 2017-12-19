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
           // this.soundSpectrum1 = new SoundSpectrumVisualisation.SoundSpectrum();
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
            this.button2.Location = new System.Drawing.Point(12, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // soundSpectrum1
            // 
        //    this.soundSpectrum1.BackColor = System.Drawing.Color.Black;
       //     this.soundSpectrum1.H_S_Size = 9.375F;
       //     this.soundSpectrum1.Location = new System.Drawing.Point(726, 12);
        //    this.soundSpectrum1.Name = "soundSpectrum1";
       //     this.soundSpectrum1.Size = new System.Drawing.Size(300, 146);
       //     this.soundSpectrum1.SpectrumColor = System.Drawing.Color.RoyalBlue;
        //    this.soundSpectrum1.TabIndex = 10;
          //  this.soundSpectrum1.Text = "soundSpectrum1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
          //  this.Controls.Add(this.soundSpectrum1);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
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
    }
}