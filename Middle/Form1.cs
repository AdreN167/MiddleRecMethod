using Middle.Models;
using Middle.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Middle
{
    public partial class Form1 : Form
    {
        private int maxNumberPoints = 0;
        private double scale = 1.0;

        private List<Point> graphPoints;

        private double leftBorder = -15;
        private double rightBorder = 15;

        private double eps = 0.0001;

        private DrawService drawService;

        private double func1(double x)
        {
            return Math.Sin(x);
        }
        private double func2(double x)
        {
            return Math.Sqrt(x);
        }
        private double func3(double x)
        {
            return 2 * x;
        }

        public Form1()
        {
            InitializeComponent();
            anT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawService = new DrawService();
            StartDraw();
        }

        private void Start()
        {
            if (!double.TryParse(leftBorderTextBox.Text, out leftBorder))
            {
                leftBorder = -15.0f;
                leftBorderTextBox.Text = "-15";
                MessageBox.Show("Левая граница должна иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!double.TryParse(rightBorderTextBox.Text, out rightBorder))
            {
                rightBorder = 15.0f;
                rightBorderTextBox.Text = "-15";
                MessageBox.Show("Правая граница должна иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!double.TryParse(epsTextBox.Text, out eps))
            {
                eps = 0.001f;
                epsTextBox.Text = "0,001";
                MessageBox.Show("Точность должна иметь числовое значение в промежутке (0, 1)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (leftBorder > rightBorder)
            {
                leftBorderTextBox.Text = rightBorder.ToString();
                rightBorderTextBox.Text = leftBorder.ToString();
                MessageBox.Show("Левая граница должна быть меньше правой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(eps > 0 && eps < 1))
            {
                eps = 0.001f;
                epsTextBox.Text = "0.001";
                MessageBox.Show("Точность должна иметь числовое значение в промежутке (0, 1)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Func<double, double> func = null;

            if (func1RadioButton.Checked)
            {
                func = func1;
            }

            else if (func2RadioButton.Checked)
            {
                func = func2;
                bool isValid = true;

                if (double.Parse(leftBorderTextBox.Text) < 0)
                {
                    leftBorder = 0;
                    leftBorderTextBox.Text = "0";
                    isValid = false;
                }
                if (double.Parse(rightBorderTextBox.Text) < 0)
                {
                    rightBorder = 3;
                    rightBorderTextBox.Text = "3";
                    isValid = false;
                }
                if (!isValid)
                    MessageBox.Show("Вы вышли за границы области опрделения функции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (func3RadioButton.Checked)
            {
                func = func3;
            }

            bool isFine = true;
            int N = 0;
            double integral = MiddleRectangleMethodService.MiddleRectagleMethod(leftBorder, rightBorder, eps, func, out isFine, out N);

            if (!isFine)
                MessageBox.Show("Достичь заданной точности невозможно!", "" +
                        "Не допустимое значение точности",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

            rectanglesCountLabel.Text = "N: " + N.ToString();
            integralLabel.Text = "I: " + integral.ToString();
        }

        private void StartDraw()
        {
            if (!double.TryParse(leftBorderTextBox.Text, out leftBorder))
            {
                leftBorder = -15.0f;
                leftBorderTextBox.Text = "-15";
                MessageBox.Show("Левая граница должна иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!double.TryParse(rightBorderTextBox.Text, out rightBorder))
            {
                rightBorder = 15.0f;
                rightBorderTextBox.Text = "-15";
                MessageBox.Show("Правая граница должна иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!double.TryParse(epsTextBox.Text, out eps))
            {
                eps = 0.001f;
                epsTextBox.Text = "0,001";
                MessageBox.Show("Точность должна иметь числовое значение в промежутке (0, 1)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (leftBorder > rightBorder)
            {
                leftBorderTextBox.Text = rightBorder.ToString();
                rightBorderTextBox.Text = leftBorder.ToString();
                MessageBox.Show("Левая граница должна быть меньше правой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(eps > 0 && eps < 1))
            {
                eps = 0.001f;
                epsTextBox.Text = "0.001";
                MessageBox.Show("Точность должна иметь числовое значение в промежутке (0, 1)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // задаем масштаб
            scale = trackBar1.Value / 2.0;
            maxNumberPoints = 0;

            double step = 0.1;
            Func<double, double> func = null;

            if (func1RadioButton.Checked)
            {
                func = func1;
            }

            else if (func2RadioButton.Checked)
            {
                func = func2;
                bool isValid = true;

                if (double.Parse(leftBorderTextBox.Text) < 0)
                {
                    leftBorder = 0;
                    leftBorderTextBox.Text = "0";
                    isValid = false;
                }
                if (double.Parse(rightBorderTextBox.Text) < 0)
                {
                    rightBorder = 3;
                    rightBorderTextBox.Text = "3";
                    isValid = false;
                }
                if (!isValid)
                    MessageBox.Show("Вы вышли за границы области опрделения функции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (func3RadioButton.Checked)
            {
                func = func3;
            }

            graphPoints = FunctionService.CalculateFunction(func, leftBorder, rightBorder, step);

            int N = 4;
            // настройка DrawService
            drawService.AnT = anT;
            drawService.Scale = scale;
            drawService.GraphPoints = graphPoints;

            List<List<List<Point>>> list = new List<List<List<Point>>>();

            list.Add(new List<List<Point>>());
            list.Add(new List<List<Point>>());
            list.Add(new List<List<Point>>());

            // первая итерация
            {
                list[0].Add(MiddleRectangleMethodService.RectanglesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[0].Add(MiddleRectangleMethodService.KeyPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[0].Add(MiddleRectangleMethodService.LinesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
            }
            // вторая итерация
            {
                N *= 2;
                list[1].Add(MiddleRectangleMethodService.RectanglesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[1].Add(MiddleRectangleMethodService.KeyPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[1].Add(MiddleRectangleMethodService.LinesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
            }
            // третья итерация
            {
                N *= 2;
                list[2].Add(MiddleRectangleMethodService.RectanglesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[2].Add(MiddleRectangleMethodService.KeyPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
                list[2].Add(MiddleRectangleMethodService.LinesPoints
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    ));
            }
            // четвертая итерация
            {
                N = 150;
                drawService.ALotOfRectanglesPoints = MiddleRectangleMethodService.ALotOfRectangles
                    (
                        leftBorder,
                        rightBorder,
                        (rightBorder - leftBorder) / N,
                        func
                    );
            }

            drawService.VisualisationPoints = list;

            timer.Start();           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
            StartDraw();
        }

        private void zoomOutLabel_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > trackBar1.Minimum)
            {
                trackBar1.Value -= 1;
                StartDraw();
            }
        }

        private void zoomInLabel_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < trackBar1.Maximum)
            {
                trackBar1.Value += 1;
                StartDraw();
            }
        }

        private void pointInGrap_Tick(object sender, EventArgs e)
        {
            maxNumberPoints++;
            drawService.Draw(maxNumberPoints, 
                (double)redTrackBar.Value / 1000, 
                (double)greenTrackBar.Value / 1000, 
                (double)blueTrackBar.Value / 1000,
                graphLineWidthTrackBar.Value,
                graphСheckBox.Checked,
                visualisationCheckBox.Checked);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scale = trackBar1.Value / 2.0;
            StartDraw();
        }

        private void func1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartDraw();
        }

        private void func2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartDraw();
        }

        private void func3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartDraw();
        }

        

        private void graphLineWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            graphLineWidthLabel.Text = graphLineWidthTrackBar.Value.ToString();
            StartDraw();
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redValueLabel.Text = redTrackBar.Value.ToString();
            StartDraw();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenValueLabel.Text = greenTrackBar.Value.ToString();
            StartDraw();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            blueValueLabel.Text = blueTrackBar.Value.ToString();
            StartDraw();
        }

        private void graphСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StartDraw();
        }

        private void visualisationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StartDraw();
        }

    }
}
