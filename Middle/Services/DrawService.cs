using Middle.Models;
using System.Collections.Generic;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Middle.Services
{
    public class DrawService
    {
        public SimpleOpenGlControl AnT { get; set; }
        public List<List<List<Point>>> VisualisationPoints { get; set; }
        public List<Point> ALotOfRectanglesPoints { get; set; }
        public List<Point> GraphPoints { get; set; }
        public double Scale { get; set; }

        private double ScreenH { get; set; }
        private double ScreenW { get; set; }
        private int maxNumberPointsFirst { get; set; }
        private int maxNumberPointsSecond { get; set; }
        private int maxNumberPointsThird { get; set; }
        
        private bool isInited;

        public DrawService() {
            VisualisationPoints = new List<List<List<Point>>>();
            isInited = false; 
        }

        private void Init()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if (AnT.Width <= AnT.Height)
            {
                ScreenW = 30.0;
                ScreenH = 30.0 * AnT.Height / AnT.Width;
                Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            }
            else
            {
                ScreenW = 30.0 * AnT.Width / AnT.Height;
                ScreenH = 30.0;
                Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            }

            Gl.glMatrixMode(Gl.GL_MODELVIEW);

        }

        private void DrawCoordPlane()
        {
            // отрисовка сетки
            Gl.glBegin(Gl.GL_POINTS);
            {
                for (int i = -(AnT.Width / 2); i < (AnT.Width / 2); i++)
                    for (int j = -(AnT.Width / 2); j < (AnT.Width / 2); j++)
                        Gl.glVertex2d(i * Scale, j * Scale);
            }
            Gl.glEnd();

            // отрисовка координатных осей
            Gl.glBegin(Gl.GL_LINES);
            {
                // координатная ось X
                Gl.glVertex2d(0, -15);
                Gl.glVertex2d(0, 15);
                Gl.glVertex2d(Scale, 0.2);
                Gl.glVertex2d(Scale, -0.2);
                Gl.glVertex2d(14.5, 0.3);
                Gl.glVertex2d(15, 0);
                Gl.glVertex2d(14.5, -0.3);
                Gl.glVertex2d(15, 0);

                // координатная ось Y
                Gl.glVertex2d(-15, 0);
                Gl.glVertex2d(15, 0);
                Gl.glVertex2d(0.2, Scale);
                Gl.glVertex2d(-0.2, Scale);
                Gl.glVertex2d(0.3, 14.5);
                Gl.glVertex2d(0, 15);
                Gl.glVertex2d(-0.3, 14.5);
                Gl.glVertex2d(0, 15);

            }
            Gl.glEnd();

            // отрисовка подписей осей
            PrintText2D(14.2, 0.5, "x");
            PrintText2D(Scale - 0.2, -1, "1");
            PrintText2D(0.5, 14.5, "y");
            PrintText2D(-1, Scale - 0.2, "1");
        } 
        private void PrintText2D(double x, double y, string text)
        {
            Gl.glRasterPos2d(x, y);

            foreach (char charForDraw in text)
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_9_BY_15, charForDraw);
        }
        private void DrawGraph(double R, double G, double B, int lineWidth)
        {
            Gl.glLineWidth(lineWidth);
            Gl.glColor3d(R, G, B);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            {
                foreach(Point point in GraphPoints)
                    Gl.glVertex2d(point.X * Scale, point.Y * Scale);
            }
            Gl.glEnd();
            Gl.glColor3d(0, 0, 0);
            Gl.glLineWidth(1);
        }
        private void DrawRectangles(int maxNumberPoints)
        {
           //Gl.glLineWidth(8);
            Gl.glLineWidth(5);
            Gl.glEnable(Gl.GL_LINE_SMOOTH);

            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (int i = 0; i <= maxNumberPoints; i += 4)
                if (i + 4 < ALotOfRectanglesPoints.Count)
                {
                    Gl.glVertex2d(ALotOfRectanglesPoints[i].X * Scale, ALotOfRectanglesPoints[i].Y * Scale);
                    Gl.glVertex2d(ALotOfRectanglesPoints[i + 1].X * Scale, ALotOfRectanglesPoints[i + 1].Y * Scale);
                    Gl.glVertex2d(ALotOfRectanglesPoints[i + 2].X * Scale, ALotOfRectanglesPoints[i + 2].Y * Scale);
                    Gl.glVertex2d(ALotOfRectanglesPoints[i + 3].X * Scale, ALotOfRectanglesPoints[i + 3].Y * Scale);
                }

            Gl.glEnd();
            Gl.glLineWidth(1);
            Gl.glDisable(Gl.GL_LINE_SMOOTH);
        }
        private void DrawRectangles(int maxNumberPoints, int iter)
        {
            Gl.glLineWidth(3);

            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (int i = 0; i <= maxNumberPoints; i++)
                if (i < VisualisationPoints[iter][0].Count)
                    Gl.glVertex2d(VisualisationPoints[iter][0][i].X * Scale, VisualisationPoints[iter][0][i].Y * Scale);

            Gl.glEnd();
            Gl.glLineWidth(1);
        }
        private void DrawPoints(int maxNumberPoints, int iter)
        {
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glPointSize(5);
            Gl.glBegin(Gl.GL_POINTS);

            for (int i = VisualisationPoints[iter][0].Count, j = 0; i <= maxNumberPoints; j++, i++)
                if (j < VisualisationPoints[iter][1].Count)
                    Gl.glVertex2d(VisualisationPoints[iter][1][j].X * Scale, VisualisationPoints[iter][1][j].Y * Scale);

            Gl.glEnd();
            Gl.glPointSize(1);
            Gl.glDisable(Gl.GL_POINT_SMOOTH);
        }
        private void DrawLines(int maxNumberPoints, int iter)
        {
            Gl.glBegin(Gl.GL_LINES);

            for (int i = VisualisationPoints[iter][0].Count + VisualisationPoints[iter][1].Count, j = 0; i <= maxNumberPoints; j++, i++)
                if (j < VisualisationPoints[iter][2].Count)
                    Gl.glVertex2d(VisualisationPoints[iter][2][j].X * Scale, VisualisationPoints[iter][2][j].Y * Scale);

            Gl.glEnd();
        }
        private void Visualisate(int maxNumberPoints, int iter)
        {
            if (!isInited)
            {
                Init();
                isInited = true;
            }

            Gl.glColor3f(255, 0, 0);

            if (iter < 3)
            {
                if (maxNumberPoints < VisualisationPoints[iter][0].Count)
                    DrawRectangles(maxNumberPoints, iter);

                else if (maxNumberPoints < VisualisationPoints[iter][0].Count + VisualisationPoints[iter][1].Count)
                {
                    DrawRectangles(maxNumberPoints, iter);
                    DrawPoints(maxNumberPoints, iter);
                }
                else //if (maxNumberPoints < VisualisationPoints[iter][0].Count + VisualisationPoints[iter][1].Count + VisualisationPoints[iter][2].Count)
                {
                    DrawRectangles(maxNumberPoints, iter);
                    DrawPoints(maxNumberPoints, iter);
                    DrawLines(maxNumberPoints, iter);
                }
            }
            else
            {
                DrawRectangles(maxNumberPoints);
            }
            //else
            //{
            //    //List<string> s = new List<string>();

            //    //for (int i = 0, j = 0; i < KeyPoints.Count; i++)
            //    //{
            //    //    if (i % 10 == 0)
            //    //        j++;
            //    //    s.Add("S" + j);
            //    //}

            //    DrawRectangles(maxNumberPoints, iter);
            //    DrawPoints(maxNumberPoints, iter);
            //    DrawLines(maxNumberPoints, iter);

            //    //for (int i = 0; i < maxNumberPoints - RectanglePoints.Count - KeyPoints.Count - LinesPoints.Count; i++)
            //    //    if (i < s.Count)
            //    //        PrintText2D((KeyPoints[i].X - 0.2) * Scale, (KeyPoints[i].Y + 0.2) * Scale, s[i]);
            //}
        }

        public void Draw(int maxNumberPoints, double R, double G, double B, int lineWidth, bool isGraph, bool isVisualisation)
        {
            if (!isInited)
            {
                Init();
                isInited = true;
            }

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);

            Gl.glPushMatrix();

            // жесткий костыль на размещение центра координатной плоскости
            Gl.glTranslated(15, 15, 0);

            // отрисовка координатной плоскости
            DrawCoordPlane();

            // отрисовка самого графика
            if (isGraph)
                DrawGraph(R, G, B, lineWidth);

            if (isVisualisation)
            {
                maxNumberPointsFirst = VisualisationPoints[0][0].Count + VisualisationPoints[0][1].Count + VisualisationPoints[0][2].Count;
                maxNumberPointsSecond = VisualisationPoints[1][0].Count + VisualisationPoints[1][1].Count + VisualisationPoints[1][2].Count;
                maxNumberPointsThird = VisualisationPoints[2][0].Count + VisualisationPoints[2][1].Count + VisualisationPoints[2][2].Count;

                // визуализация
                if (maxNumberPoints < maxNumberPointsFirst)
                    Visualisate(maxNumberPoints, 0);

                else if (maxNumberPoints < maxNumberPointsSecond + maxNumberPointsFirst)
                    Visualisate(maxNumberPoints - maxNumberPointsFirst, 1);

                else if (maxNumberPoints < maxNumberPointsSecond + maxNumberPointsFirst + maxNumberPointsThird)
                    Visualisate(maxNumberPoints - maxNumberPointsFirst - maxNumberPointsSecond, 2);

                else
                    Visualisate(maxNumberPoints - maxNumberPointsFirst - maxNumberPointsSecond - maxNumberPointsThird, 3);
            }

            Gl.glPopMatrix();

            Gl.glFlush();

            AnT.Invalidate();
        }
        
    }
}
