using System;
using System.Drawing;
using System.Windows.Forms;

public class DrawingForm : Form
{
    public DrawingForm()
    {
        // Impostazioni di base del form
        this.Text = "Drawing Shapes";
        this.Size = new Size(400, 400);

        // Gestisce l'evento Paint per il disegno
        this.Paint += new PaintEventHandler(DrawingForm_Paint);
    }

    private void DrawingForm_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // Disegno di un punto
        Pen pointPen = new Pen(Color.Blue, 3);
        g.DrawEllipse(pointPen, 50, 50, 2, 2);

        // Disegno di un cerchio
        Pen circlePen = new Pen(Color.Red, 3);
        g.DrawEllipse(circlePen, 100, 100, 80, 80);

        // Disegno di una linea
        Pen linePen = new Pen(Color.Black, 2);
        g.DrawLine(linePen, 200, 200, 300, 300);

        // Disegno di un rettangolo
        Pen rectanglePen = new Pen(Color.Green, 3);
        g.DrawRectangle(rectanglePen, 250, 50, 100, 60);
    }

    public static void Main()
    {
        Application.Run(new DrawingForm());
    }
}