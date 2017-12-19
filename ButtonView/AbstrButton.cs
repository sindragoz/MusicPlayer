using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonView
{
    public abstract class AbstrButton:Button
    {
       protected Color btns_color=Color.Red;
        public Color Buttons_Color {
        set { btns_color = value; }
            get { return btns_color; }
        }
        public AbstrButton() {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
          
        }
        private int glow=60;
        private Size prev_size;
        private Color prev_clr;

        protected override void OnMouseEnter(EventArgs e)
        {
            prev_size = Size;
            base.OnMouseEnter(e);
            prev_clr = btns_color;
            Width += 1;
            Height += 1;
            
            btns_color = (btns_color.R == 255 && btns_color.G == 255 && btns_color.B == 255) ? Color.FromArgb(255 - glow, 255 - glow, 255 - glow) : Color.FromArgb(btns_color.R + (btns_color.R + glow <= 255 ? glow : 0), btns_color.G + (btns_color.G + glow <= 255 ? glow : 0), btns_color.B + (btns_color.B + glow <= 255 ? glow : 0)) ;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            btns_color = prev_clr;
            Size = prev_size;
            Invalidate();
        }
    }
}
