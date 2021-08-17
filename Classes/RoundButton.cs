using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Chaisher.Classes
{
    class RoundButton:Button
    {
        private int bordersize = 5;
        private int borderradius = 40;
        private Color bordercolor = Color.White;
        public RoundButton ()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(130, 100);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Margin = new Padding(5, 5, 5, 5);

                

        }
        // Methods 
        private GraphicsPath GetGraphicsPath(RectangleF rect , float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            float curveSize = radius * 2F;
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF recsurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);
            if(borderradius >2)
            {
                using(GraphicsPath pathSurface= GetGraphicsPath(recsurface , borderradius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectBorder , borderradius-1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penborder = new Pen(bordercolor, bordersize))
                {
                    penborder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (bordersize >= 1)
                        pevent.Graphics.DrawPath(penborder, pathBorder);

                }
            }
            else

            {
                this.Region = new Region(recsurface);
                if(bordersize>= 1)
                {
                    using (Pen penborder = new Pen (bordercolor , bordersize))
                    {
                        penborder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penborder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += Parent_BackColorChanged;
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
           if (this.DesignMode )
            {
                this.Invalidate();
            }
        }
    }
}
