using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    internal class Picture
    {
        public enum DrawingState
        {
            None,    //Nothing drawing
            Start,  //Pen down and starts drawing
            End    //Pen up and ends drawing
        }

        public enum Mode 
        { 
            Curve,
            Line,
            Square,
            Ellipse,
            FillColor
        }

       private Graphics graphics, graphicsShapes;
       private Bitmap bitmap, bitmapShapes;
       private Pen pen;
       private Mode drawingMode;

        public Pen Pen { get => pen; set => pen = value; }
        public Bitmap Bitmap { get => bitmap; set { bitmap = value; this.graphics = Graphics.FromImage(bitmap); } }
        public Mode DrawingMode { get => drawingMode; set => drawingMode = value; }

        public Picture(int width, int height,  int penWidth, Color penColor)
        {
            this.bitmap = new Bitmap(width, height);
            this.bitmapShapes = new Bitmap(width, height);
            this.graphics = Graphics.FromImage(bitmap);
            this.graphicsShapes = Graphics.FromImage(bitmapShapes);
            this.pen = new Pen(penColor, penWidth);
            this.drawingMode = Mode.Curve;

            this.pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        /// <summary>
        /// Makes changes to the final image depending on the drawing state and the selected mode
        /// </summary>
        /// <param name="from">the point where the drawing will start</param>
        /// <param name="to">the point where the drawing will end</param>
        /// <param name="picture"picture box with final image></param>
        /// <param name="state">drawing state</param>
        public void Draw(ref Point from, Point to, PictureBox picture, DrawingState state)
        {
            int x, y;

            //necessary for correct display depending on the direction of the rice:
            x = from.X > to.X ? to.X : from.X;
            y = from.Y > to.Y ? to.Y : from.Y;

            switch (drawingMode)
            {
                case Mode.Curve:
                    if(state == DrawingState.Start)
                    {
                    graphics.DrawLine(pen, from, to);
                    picture.Image = bitmap;
                    }
                    //the point where the drawing comes from changes, due to which a curved line is drawn
                    from.X = to.X;
                    from.Y = to.Y;
                    break;
                case Mode.Line:

                    if (state == DrawingState.End)
                    {
                        graphics.DrawLine(pen, from.X, from.Y, to.X, to.Y);
                        picture.Image = bitmap;
                    }
                    if (state == DrawingState.Start)
                    {
                        graphicsShapes.Clear(Color.White);

                        graphicsShapes.DrawLine(pen, from.X, from.Y, to.X, to.Y);

                        graphicsShapes.DrawImage(bitmap, 0, 0);
                        picture.Image = bitmapShapes;
                    }
                    break;
                case Mode.Square:

                    if (state == DrawingState.End)
                    {
                        graphics.DrawRectangle(pen, x, y, Math.Abs(to.X - from.X), Math.Abs(to.Y - from.Y));
                        picture.Image = bitmap;
                    }
                    if (state == DrawingState.Start)
                    {
                        graphicsShapes.Clear(Color.White);

                        graphicsShapes.DrawRectangle(pen, x, y, Math.Abs(to.X - from.X), Math.Abs(to.Y - from.Y));

                        graphicsShapes.DrawImage(bitmap, 0, 0);
                        picture.Image = bitmapShapes;
                    }
                    break;
                case Mode.Ellipse:

                    if (state == DrawingState.End)
                    {
                        graphics.DrawEllipse(pen, x, y, Math.Abs(to.X - from.X), Math.Abs(to.Y - from.Y));
                        picture.Image = bitmap;
                    }
                    if (state == DrawingState.Start)
                    {
                        graphicsShapes.Clear(Color.White);

                        graphicsShapes.DrawEllipse(pen, x, y, Math.Abs(to.X - from.X), Math.Abs(to.Y - from.Y));

                        graphicsShapes.DrawImage(bitmap, 0, 0);
                        picture.Image = bitmapShapes;
                    }
                    break;
                case Mode.FillColor:
                    if (state == DrawingState.End)
                    {
                        FillColor(bitmap, to.X, to.Y, bitmap.GetPixel(to.X, to.Y), pen.Color);
                        picture.Image = bitmap;
                    }
                    break;
            }
        }

        /// <summary>
        /// Paints all the pixels in an area until it hits a pixel of a different color or paints the entire canvas
        /// </summary>
        /// <param name="bitmap">Frawing bitmap</param>
        /// <param name="x">X-coordinate from where the filling starts</param>
        /// <param name="y">Y-coordinate from where the filling starts</param>
        /// <param name="oldColor">what color pixels will be painted over</param>
        /// <param name="newColor">New color for the old painted pixels</param>
        private void FillColor(Bitmap bitmap, int x, int y, Color oldColor, Color newColor)
        {
            Queue<Point> queue = new Queue<Point>();

            queue.Enqueue(new Point(x, y));

            int width = bitmap.Width;
            int height = bitmap.Height;

            while (queue.Count > 0)
            {
                x = queue.Peek().X;
                y = queue.Peek().Y;
                queue.Dequeue();
                if (x <= 0 || x >= width || y <= 0 || y >= height || bitmap.GetPixel(x, y) != oldColor)
                    continue;

                else
                {
                    bitmap.SetPixel(x, y, newColor);
                    queue.Enqueue(new Point(x + 1, y));
                    queue.Enqueue(new Point(x - 1, y));
                    queue.Enqueue(new Point(x, y + 1));
                    queue.Enqueue(new Point(x, y - 1));
                }
            }
        }

    }
}
