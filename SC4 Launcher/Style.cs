using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC4_Launcher
{
    class Style
    {

    }
    public class RectangleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Hintergrund und Rahmen zeichnen
            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pevent.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            pevent.Graphics.DrawRectangle(new Pen(Color.White, 1), 0, 0, Width - 1, Height - 1);

            // Wenn ein Image vorhanden ist, zeichne es
            if (this.ImageList != null && this.ImageIndex >= 0 && this.ImageIndex < this.ImageList.Images.Count)
            {
                Image image = this.ImageList.Images[this.ImageIndex];
                // Berechne die Position: Hier links, zentriert vertikal
                int imageX = 2;
                int imageY = (Height - image.Height) / 2;
                pevent.Graphics.DrawImage(image, new Rectangle(imageX, imageY, image.Width, image.Height));
            }

            // Text zeichnen
            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
