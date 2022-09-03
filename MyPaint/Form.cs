using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;

namespace MyPaint
{
    public partial class PaintApplication : Form
    {
        private Picture picture;
        private Point downPoint;
        Picture.DrawingState state;

        public PaintApplication()
        {
            InitializeComponent();

            downPoint = new Point();

            state = Picture.DrawingState.None;

            picture = new Picture(Canvas.Width, Canvas.Height, 1, Color.Black);
        }

        private void toolStripPalleteButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Pen.Color = colorDialog.Color;
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            state = Picture.DrawingState.Start;

            downPoint.X = e.X;
            downPoint.Y = e.Y;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            picture.Draw(ref downPoint, new Point(e.X, e.Y), Canvas, state);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            state = Picture.DrawingState.End;
            picture.Draw(ref downPoint, new Point(e.X, e.Y), Canvas, state);
            state = Picture.DrawingState.None;
        }

        private void toolStripLineWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            var width = int.TryParse(toolStripLineWidthTextBox.Text, out int number) ? int.Parse(toolStripLineWidthTextBox.Text) : 0;

            picture.Pen.Width = width;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK && picture.Bitmap != null)
            {
                try
                {
                    Canvas.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        picture.Bitmap = (Bitmap)System.Drawing.Image.FromStream(stream);
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }

                Canvas.Image = picture.Bitmap;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture.Bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = picture.Bitmap;
        }

        private void toolStripCurveButton_Click(object sender, EventArgs e)
        {
            picture.DrawingMode = Picture.Mode.Curve;
        }

        private void toolStripSquareButton_Click(object sender, EventArgs e)
        {
            picture.DrawingMode = Picture.Mode.Square;
        }

        private void toolStripLineButton_Click(object sender, EventArgs e)
        {
            picture.DrawingMode = Picture.Mode.Line;
        }

        private void toolStripEllipseButton_Click(object sender, EventArgs e)
        {
            picture.DrawingMode = Picture.Mode.Ellipse;
        }

        private void toolStripFillColorButton_Click(object sender, EventArgs e)
        {
            picture.DrawingMode = Picture.Mode.FillColor;
        }
    }
}
