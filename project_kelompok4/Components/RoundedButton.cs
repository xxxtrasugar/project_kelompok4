using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 20;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
        path.AddArc(rect.X + rect.Width - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
        path.AddArc(rect.X + rect.Width - BorderRadius, rect.Y + rect.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
        path.AddArc(rect.X, rect.Y + rect.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        using (Pen pen = new Pen(this.BackColor, 1.75f))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}