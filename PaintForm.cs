﻿using System.Drawing;

namespace Figures
{
    public static partial class PaintForm
    {
        public static void Draw(Graphics g, Circle circle)
        {
            g.FillEllipse(circle.brush, circle.FirstPoint.X - circle.Width / 2,
                circle.FirstPoint.Y - circle.Height / 2, circle.Width, circle.Height);
        }
        public static void Draw(Graphics g, Ellipse ellipse)
        {
            g.FillEllipse(ellipse.brush, ellipse.FirstPoint.X, ellipse.FirstPoint.Y,
                ellipse.Width, ellipse.Height);
        }
        public static void Draw(Graphics g, Line line)
        {
            Pen pen = new Pen(line.brush.Color, 4f);

            g.DrawLine(pen, line.First, line.Second);
        }
        public static void Draw(Graphics g, Polygon polygon)
        {
            polygon.Points = polygon.Vertices.ToArray();
            g.FillPolygon(polygon.brush, polygon.Points);
        }
        public static void Draw(Graphics g, Rect rect)
        {
            g.FillRectangle(rect.brush, rect.position.X, rect.position.Y, rect.Width, rect.Height);
        }
        public static void Draw(Graphics g, Square square)
        {
            g.FillRectangle(square.brush, square.position.X, square.position.Y, square.Width, square.Width);
        }
        public static void Draw(Graphics g, MyPoint point)
        {
            g.FillEllipse(point.brush, point.Position.X, point.Position.Y, 4, 4);
        }
    }
}
