//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MusicPlayer
//{
//    public class MusicPlayer:Panel
//    {
//        private SoundTrackBar.MusicTrackBar musicTrackBar1;
//        private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum1;
//        private buttonPlay.PlayBtn playBtn1;

//        private void InitializeComponent()
//        {
//            this.playBtn1 = new buttonPlay.PlayBtn();
//            this.musicTrackBar1 = new SoundTrackBar.MusicTrackBar();
//            this.soundSpectrum1 = new SoundSpectrumVisualisation.SoundSpectrum();
//            this.SuspendLayout();
//            // 
//            // playBtn1
//            // 
//            this.playBtn1.Location = new System.Drawing.Point(0, 0);
//            this.playBtn1.Name = "playBtn1";
//            this.playBtn1.Size = new System.Drawing.Size(75, 23);
//            this.playBtn1.TabIndex = 0;
//            this.playBtn1.Text = "playBtn1";
//            this.playBtn1.UseVisualStyleBackColor = true;
//            // 
//            // musicTrackBar1
//            // 
//            this.musicTrackBar1.Clr1 = System.Drawing.Color.Red;
//            this.musicTrackBar1.Location = new System.Drawing.Point(0, 0);
//            this.musicTrackBar1.MaximumValue = 100;
//            this.musicTrackBar1.MinimumValue = 0;
//            this.musicTrackBar1.Name = "musicTrackBar1";
//            this.musicTrackBar1.Size = new System.Drawing.Size(0, 0);
//            this.musicTrackBar1.TabIndex = 0;
//            this.musicTrackBar1.Text = "musicTrackBar1";
//            this.musicTrackBar1.Value = 0;
//            // 
//            // soundSpectrum1
//            // 
//            this.soundSpectrum1.H_S_Size = 2F;
//            this.soundSpectrum1.Location = new System.Drawing.Point(3, 3);
//            this.soundSpectrum1.MaximumSize = new System.Drawing.Size(200, 200);
//            this.soundSpectrum1.Name = "soundSpectrum1";
//            this.soundSpectrum1.Size = new System.Drawing.Size(100, 100);
//            this.soundSpectrum1.SpectrumColor = System.Drawing.Color.Red;
//            this.soundSpectrum1.TabIndex = 1;
//            this.soundSpectrum1.Text = "soundSpectrum1";
//            // 
//            // MusicPlayer
//            // 
//            this.Controls.Add(this.soundSpectrum1);
//            this.Size = new System.Drawing.Size(663, 350);
//            this.ResumeLayout(false);

//        }
//        public MusicPlayer() {
//            InitializeComponent();
//        }
//        public override Color BackColor
//        {
//            get
//            {
//                return base.BackColor;
//            }

//            set
//            {
//                base.BackColor = Color.Transparent;
//            }
//        }
//    }
//}
