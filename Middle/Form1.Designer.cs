namespace Middle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rightBorderTextBox = new System.Windows.Forms.TextBox();
            this.rigthBorderLabel = new System.Windows.Forms.Label();
            this.leftBorderTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.leftAndRightBordersGroupBox = new System.Windows.Forms.GroupBox();
            this.leftBorderLabel = new System.Windows.Forms.Label();
            this.func2RadioButton = new System.Windows.Forms.RadioButton();
            this.func1RadioButton = new System.Windows.Forms.RadioButton();
            this.functionsGroupBox = new System.Windows.Forms.GroupBox();
            this.func3RadioButton = new System.Windows.Forms.RadioButton();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.epsLabel = new System.Windows.Forms.Label();
            this.epsGroupBox = new System.Windows.Forms.GroupBox();
            this.integralLabel = new System.Windows.Forms.Label();
            this.integralGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesCountLabel = new System.Windows.Forms.Label();
            this.zoomInLabel = new System.Windows.Forms.Label();
            this.zoomOutLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.scaleGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.visualisationCheckBox = new System.Windows.Forms.CheckBox();
            this.graphСheckBox = new System.Windows.Forms.CheckBox();
            this.graphLineWidthLabel = new System.Windows.Forms.Label();
            this.lineWidthLabel = new System.Windows.Forms.Label();
            this.graphLineWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueValueLabel = new System.Windows.Forms.Label();
            this.redValueLabel = new System.Windows.Forms.Label();
            this.greenValueLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.anT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.leftAndRightBordersGroupBox.SuspendLayout();
            this.functionsGroupBox.SuspendLayout();
            this.epsGroupBox.SuspendLayout();
            this.integralGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.scaleGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphLineWidthTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.pointInGrap_Tick);
            // 
            // rightBorderTextBox
            // 
            this.rightBorderTextBox.Location = new System.Drawing.Point(176, 36);
            this.rightBorderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBorderTextBox.Name = "rightBorderTextBox";
            this.rightBorderTextBox.Size = new System.Drawing.Size(84, 29);
            this.rightBorderTextBox.TabIndex = 8;
            this.rightBorderTextBox.Text = "3";
            // 
            // rigthBorderLabel
            // 
            this.rigthBorderLabel.AutoSize = true;
            this.rigthBorderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rigthBorderLabel.Location = new System.Drawing.Point(150, 41);
            this.rigthBorderLabel.Name = "rigthBorderLabel";
            this.rigthBorderLabel.Size = new System.Drawing.Size(20, 19);
            this.rigthBorderLabel.TabIndex = 7;
            this.rigthBorderLabel.Text = "b:";
            // 
            // leftBorderTextBox
            // 
            this.leftBorderTextBox.Location = new System.Drawing.Point(46, 36);
            this.leftBorderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBorderTextBox.Name = "leftBorderTextBox";
            this.leftBorderTextBox.Size = new System.Drawing.Size(84, 29);
            this.leftBorderTextBox.TabIndex = 6;
            this.leftBorderTextBox.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(261, 660);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(235, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(20, 660);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(235, 36);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // leftAndRightBordersGroupBox
            // 
            this.leftAndRightBordersGroupBox.Controls.Add(this.rightBorderTextBox);
            this.leftAndRightBordersGroupBox.Controls.Add(this.rigthBorderLabel);
            this.leftAndRightBordersGroupBox.Controls.Add(this.leftBorderTextBox);
            this.leftAndRightBordersGroupBox.Controls.Add(this.leftBorderLabel);
            this.leftAndRightBordersGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftAndRightBordersGroupBox.Location = new System.Drawing.Point(18, 48);
            this.leftAndRightBordersGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftAndRightBordersGroupBox.Name = "leftAndRightBordersGroupBox";
            this.leftAndRightBordersGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.leftAndRightBordersGroupBox.Size = new System.Drawing.Size(278, 92);
            this.leftAndRightBordersGroupBox.TabIndex = 6;
            this.leftAndRightBordersGroupBox.TabStop = false;
            this.leftAndRightBordersGroupBox.Text = "Границы отрезка";
            // 
            // leftBorderLabel
            // 
            this.leftBorderLabel.AutoSize = true;
            this.leftBorderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorderLabel.Location = new System.Drawing.Point(20, 41);
            this.leftBorderLabel.Name = "leftBorderLabel";
            this.leftBorderLabel.Size = new System.Drawing.Size(19, 19);
            this.leftBorderLabel.TabIndex = 5;
            this.leftBorderLabel.Text = "a:";
            // 
            // func2RadioButton
            // 
            this.func2RadioButton.AutoSize = true;
            this.func2RadioButton.Checked = true;
            this.func2RadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func2RadioButton.Location = new System.Drawing.Point(18, 72);
            this.func2RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.func2RadioButton.Name = "func2RadioButton";
            this.func2RadioButton.Size = new System.Drawing.Size(91, 23);
            this.func2RadioButton.TabIndex = 1;
            this.func2RadioButton.TabStop = true;
            this.func2RadioButton.Text = "y = sqrt(x)";
            this.func2RadioButton.UseVisualStyleBackColor = true;
            this.func2RadioButton.CheckedChanged += new System.EventHandler(this.func2RadioButton_CheckedChanged);
            // 
            // func1RadioButton
            // 
            this.func1RadioButton.AutoSize = true;
            this.func1RadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func1RadioButton.Location = new System.Drawing.Point(18, 36);
            this.func1RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.func1RadioButton.Name = "func1RadioButton";
            this.func1RadioButton.Size = new System.Drawing.Size(84, 23);
            this.func1RadioButton.TabIndex = 0;
            this.func1RadioButton.Text = "y = sin(x)";
            this.func1RadioButton.UseVisualStyleBackColor = true;
            this.func1RadioButton.CheckedChanged += new System.EventHandler(this.func1RadioButton_CheckedChanged);
            // 
            // functionsGroupBox
            // 
            this.functionsGroupBox.Controls.Add(this.func3RadioButton);
            this.functionsGroupBox.Controls.Add(this.func2RadioButton);
            this.functionsGroupBox.Controls.Add(this.func1RadioButton);
            this.functionsGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionsGroupBox.Location = new System.Drawing.Point(18, 251);
            this.functionsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionsGroupBox.Name = "functionsGroupBox";
            this.functionsGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.functionsGroupBox.Size = new System.Drawing.Size(278, 157);
            this.functionsGroupBox.TabIndex = 9;
            this.functionsGroupBox.TabStop = false;
            this.functionsGroupBox.Text = "Функции";
            // 
            // func3RadioButton
            // 
            this.func3RadioButton.AutoSize = true;
            this.func3RadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func3RadioButton.Location = new System.Drawing.Point(18, 109);
            this.func3RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.func3RadioButton.Name = "func3RadioButton";
            this.func3RadioButton.Size = new System.Drawing.Size(66, 23);
            this.func3RadioButton.TabIndex = 2;
            this.func3RadioButton.Text = "y = 2x";
            this.func3RadioButton.UseVisualStyleBackColor = true;
            this.func3RadioButton.CheckedChanged += new System.EventHandler(this.func3RadioButton_CheckedChanged);
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(71, 41);
            this.epsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(187, 29);
            this.epsTextBox.TabIndex = 10;
            this.epsTextBox.Text = "0,001";
            // 
            // epsLabel
            // 
            this.epsLabel.AutoSize = true;
            this.epsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsLabel.Location = new System.Drawing.Point(18, 44);
            this.epsLabel.Name = "epsLabel";
            this.epsLabel.Size = new System.Drawing.Size(33, 19);
            this.epsLabel.TabIndex = 9;
            this.epsLabel.Text = "eps:";
            // 
            // epsGroupBox
            // 
            this.epsGroupBox.Controls.Add(this.epsTextBox);
            this.epsGroupBox.Controls.Add(this.epsLabel);
            this.epsGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsGroupBox.Location = new System.Drawing.Point(20, 146);
            this.epsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsGroupBox.Name = "epsGroupBox";
            this.epsGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.epsGroupBox.Size = new System.Drawing.Size(276, 100);
            this.epsGroupBox.TabIndex = 10;
            this.epsGroupBox.TabStop = false;
            this.epsGroupBox.Text = "Точность";
            // 
            // integralLabel
            // 
            this.integralLabel.AutoSize = true;
            this.integralLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.integralLabel.Location = new System.Drawing.Point(19, 36);
            this.integralLabel.Name = "integralLabel";
            this.integralLabel.Size = new System.Drawing.Size(17, 19);
            this.integralLabel.TabIndex = 11;
            this.integralLabel.Text = "I:";
            // 
            // integralGroupBox
            // 
            this.integralGroupBox.Controls.Add(this.rectanglesCountLabel);
            this.integralGroupBox.Controls.Add(this.integralLabel);
            this.integralGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.integralGroupBox.Location = new System.Drawing.Point(20, 413);
            this.integralGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.integralGroupBox.Name = "integralGroupBox";
            this.integralGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.integralGroupBox.Size = new System.Drawing.Size(276, 118);
            this.integralGroupBox.TabIndex = 10;
            this.integralGroupBox.TabStop = false;
            this.integralGroupBox.Text = "Результат вычислений";
            // 
            // rectanglesCountLabel
            // 
            this.rectanglesCountLabel.AutoSize = true;
            this.rectanglesCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectanglesCountLabel.Location = new System.Drawing.Point(19, 70);
            this.rectanglesCountLabel.Name = "rectanglesCountLabel";
            this.rectanglesCountLabel.Size = new System.Drawing.Size(24, 19);
            this.rectanglesCountLabel.TabIndex = 12;
            this.rectanglesCountLabel.Text = "N:";
            // 
            // zoomInLabel
            // 
            this.zoomInLabel.AutoSize = true;
            this.zoomInLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zoomInLabel.Location = new System.Drawing.Point(206, 37);
            this.zoomInLabel.Name = "zoomInLabel";
            this.zoomInLabel.Size = new System.Drawing.Size(18, 19);
            this.zoomInLabel.TabIndex = 13;
            this.zoomInLabel.Text = "+";
            this.zoomInLabel.Click += new System.EventHandler(this.zoomInLabel_Click);
            // 
            // zoomOutLabel
            // 
            this.zoomOutLabel.AutoSize = true;
            this.zoomOutLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zoomOutLabel.Location = new System.Drawing.Point(18, 37);
            this.zoomOutLabel.Name = "zoomOutLabel";
            this.zoomOutLabel.Size = new System.Drawing.Size(15, 19);
            this.zoomOutLabel.TabIndex = 12;
            this.zoomOutLabel.Text = "-";
            this.zoomOutLabel.Click += new System.EventHandler(this.zoomOutLabel_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(51, 37);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(148, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // scaleGroupBox
            // 
            this.scaleGroupBox.Controls.Add(this.zoomInLabel);
            this.scaleGroupBox.Controls.Add(this.zoomOutLabel);
            this.scaleGroupBox.Controls.Add(this.trackBar1);
            this.scaleGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleGroupBox.Location = new System.Drawing.Point(20, 536);
            this.scaleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleGroupBox.Name = "scaleGroupBox";
            this.scaleGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.scaleGroupBox.Size = new System.Drawing.Size(276, 109);
            this.scaleGroupBox.TabIndex = 12;
            this.scaleGroupBox.TabStop = false;
            this.scaleGroupBox.Text = "Масштаб";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.groupBox2);
            this.settingsGroupBox.Controls.Add(this.scaleGroupBox);
            this.settingsGroupBox.Controls.Add(this.groupBox1);
            this.settingsGroupBox.Controls.Add(this.integralGroupBox);
            this.settingsGroupBox.Controls.Add(this.epsGroupBox);
            this.settingsGroupBox.Controls.Add(this.functionsGroupBox);
            this.settingsGroupBox.Controls.Add(this.exitButton);
            this.settingsGroupBox.Controls.Add(this.startButton);
            this.settingsGroupBox.Controls.Add(this.leftAndRightBordersGroupBox);
            this.settingsGroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsGroupBox.Location = new System.Drawing.Point(738, 15);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.settingsGroupBox.Size = new System.Drawing.Size(514, 717);
            this.settingsGroupBox.TabIndex = 6;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Настройки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.visualisationCheckBox);
            this.groupBox2.Controls.Add(this.graphСheckBox);
            this.groupBox2.Controls.Add(this.graphLineWidthLabel);
            this.groupBox2.Controls.Add(this.lineWidthLabel);
            this.groupBox2.Controls.Add(this.graphLineWidthTrackBar);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(307, 413);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.groupBox2.Size = new System.Drawing.Size(189, 232);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображение";
            // 
            // visualisationCheckBox
            // 
            this.visualisationCheckBox.AutoSize = true;
            this.visualisationCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.visualisationCheckBox.Location = new System.Drawing.Point(25, 156);
            this.visualisationCheckBox.Name = "visualisationCheckBox";
            this.visualisationCheckBox.Size = new System.Drawing.Size(122, 23);
            this.visualisationCheckBox.TabIndex = 14;
            this.visualisationCheckBox.Text = "Визуализация";
            this.visualisationCheckBox.UseVisualStyleBackColor = true;
            this.visualisationCheckBox.CheckedChanged += new System.EventHandler(this.visualisationCheckBox_CheckedChanged);
            // 
            // graphСheckBox
            // 
            this.graphСheckBox.AutoSize = true;
            this.graphСheckBox.Checked = true;
            this.graphСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.graphСheckBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.graphСheckBox.Location = new System.Drawing.Point(25, 123);
            this.graphСheckBox.Name = "graphСheckBox";
            this.graphСheckBox.Size = new System.Drawing.Size(76, 23);
            this.graphСheckBox.TabIndex = 13;
            this.graphСheckBox.Text = "График";
            this.graphСheckBox.UseVisualStyleBackColor = true;
            this.graphСheckBox.CheckedChanged += new System.EventHandler(this.graphСheckBox_CheckedChanged);
            // 
            // graphLineWidthLabel
            // 
            this.graphLineWidthLabel.AutoSize = true;
            this.graphLineWidthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphLineWidthLabel.Location = new System.Drawing.Point(149, 63);
            this.graphLineWidthLabel.Name = "graphLineWidthLabel";
            this.graphLineWidthLabel.Size = new System.Drawing.Size(17, 19);
            this.graphLineWidthLabel.TabIndex = 12;
            this.graphLineWidthLabel.Text = "1";
            // 
            // lineWidthLabel
            // 
            this.lineWidthLabel.AutoSize = true;
            this.lineWidthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineWidthLabel.Location = new System.Drawing.Point(30, 36);
            this.lineWidthLabel.Name = "lineWidthLabel";
            this.lineWidthLabel.Size = new System.Drawing.Size(117, 19);
            this.lineWidthLabel.TabIndex = 9;
            this.lineWidthLabel.Text = "Толщина линии";
            // 
            // graphLineWidthTrackBar
            // 
            this.graphLineWidthTrackBar.LargeChange = 1;
            this.graphLineWidthTrackBar.Location = new System.Drawing.Point(19, 63);
            this.graphLineWidthTrackBar.Minimum = 1;
            this.graphLineWidthTrackBar.Name = "graphLineWidthTrackBar";
            this.graphLineWidthTrackBar.Size = new System.Drawing.Size(123, 45);
            this.graphLineWidthTrackBar.TabIndex = 0;
            this.graphLineWidthTrackBar.Value = 1;
            this.graphLineWidthTrackBar.Scroll += new System.EventHandler(this.graphLineWidthTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueValueLabel);
            this.groupBox1.Controls.Add(this.redValueLabel);
            this.groupBox1.Controls.Add(this.greenValueLabel);
            this.groupBox1.Controls.Add(this.blueLabel);
            this.groupBox1.Controls.Add(this.greenLabel);
            this.groupBox1.Controls.Add(this.redLabel);
            this.groupBox1.Controls.Add(this.blueTrackBar);
            this.groupBox1.Controls.Add(this.greenTrackBar);
            this.groupBox1.Controls.Add(this.redTrackBar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(307, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 360);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет линии графика";
            // 
            // blueValueLabel
            // 
            this.blueValueLabel.AutoSize = true;
            this.blueValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueValueLabel.Location = new System.Drawing.Point(124, 314);
            this.blueValueLabel.Name = "blueValueLabel";
            this.blueValueLabel.Size = new System.Drawing.Size(17, 19);
            this.blueValueLabel.TabIndex = 15;
            this.blueValueLabel.Text = "0";
            // 
            // redValueLabel
            // 
            this.redValueLabel.AutoSize = true;
            this.redValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redValueLabel.Location = new System.Drawing.Point(23, 314);
            this.redValueLabel.Name = "redValueLabel";
            this.redValueLabel.Size = new System.Drawing.Size(17, 19);
            this.redValueLabel.TabIndex = 14;
            this.redValueLabel.Text = "0";
            // 
            // greenValueLabel
            // 
            this.greenValueLabel.AutoSize = true;
            this.greenValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenValueLabel.Location = new System.Drawing.Point(73, 314);
            this.greenValueLabel.Name = "greenValueLabel";
            this.greenValueLabel.Size = new System.Drawing.Size(17, 19);
            this.greenValueLabel.TabIndex = 13;
            this.greenValueLabel.Text = "0";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabel.Location = new System.Drawing.Point(122, 46);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(19, 19);
            this.blueLabel.TabIndex = 11;
            this.blueLabel.Text = "B";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenLabel.Location = new System.Drawing.Point(70, 46);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(20, 19);
            this.greenLabel.TabIndex = 10;
            this.greenLabel.Text = "G";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redLabel.Location = new System.Drawing.Point(21, 46);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(19, 19);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "R";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.LargeChange = 1;
            this.blueTrackBar.Location = new System.Drawing.Point(121, 68);
            this.blueTrackBar.Maximum = 1000;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueTrackBar.Size = new System.Drawing.Size(45, 243);
            this.blueTrackBar.TabIndex = 2;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.LargeChange = 1;
            this.greenTrackBar.Location = new System.Drawing.Point(70, 68);
            this.greenTrackBar.Maximum = 1000;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenTrackBar.Size = new System.Drawing.Size(45, 243);
            this.greenTrackBar.TabIndex = 1;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // redTrackBar
            // 
            this.redTrackBar.LargeChange = 1;
            this.redTrackBar.Location = new System.Drawing.Point(19, 68);
            this.redTrackBar.Maximum = 1000;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redTrackBar.Size = new System.Drawing.Size(45, 243);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // anT
            // 
            this.anT.AccumBits = ((byte)(0));
            this.anT.AutoCheckErrors = false;
            this.anT.AutoFinish = false;
            this.anT.AutoMakeCurrent = true;
            this.anT.AutoSwapBuffers = true;
            this.anT.BackColor = System.Drawing.Color.Black;
            this.anT.ColorBits = ((byte)(32));
            this.anT.DepthBits = ((byte)(16));
            this.anT.Location = new System.Drawing.Point(18, 15);
            this.anT.Margin = new System.Windows.Forms.Padding(4);
            this.anT.Name = "anT";
            this.anT.Size = new System.Drawing.Size(713, 717);
            this.anT.StencilBits = ((byte)(0));
            this.anT.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 741);
            this.Controls.Add(this.anT);
            this.Controls.Add(this.settingsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Численное интегрирование (метод средних прямоугольников)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftAndRightBordersGroupBox.ResumeLayout(false);
            this.leftAndRightBordersGroupBox.PerformLayout();
            this.functionsGroupBox.ResumeLayout(false);
            this.functionsGroupBox.PerformLayout();
            this.epsGroupBox.ResumeLayout(false);
            this.epsGroupBox.PerformLayout();
            this.integralGroupBox.ResumeLayout(false);
            this.integralGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.scaleGroupBox.ResumeLayout(false);
            this.scaleGroupBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphLineWidthTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox rightBorderTextBox;
        private System.Windows.Forms.Label rigthBorderLabel;
        private System.Windows.Forms.TextBox leftBorderTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox leftAndRightBordersGroupBox;
        private System.Windows.Forms.Label leftBorderLabel;
        private System.Windows.Forms.RadioButton func2RadioButton;
        private System.Windows.Forms.RadioButton func1RadioButton;
        private System.Windows.Forms.GroupBox functionsGroupBox;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.Label epsLabel;
        private System.Windows.Forms.GroupBox epsGroupBox;
        private System.Windows.Forms.Label integralLabel;
        private System.Windows.Forms.GroupBox integralGroupBox;
        private System.Windows.Forms.Label zoomInLabel;
        private System.Windows.Forms.Label zoomOutLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox scaleGroupBox;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private Tao.Platform.Windows.SimpleOpenGlControl anT;
        private System.Windows.Forms.RadioButton func3RadioButton;
        private System.Windows.Forms.Label rectanglesCountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox visualisationCheckBox;
        private System.Windows.Forms.CheckBox graphСheckBox;
        private System.Windows.Forms.Label graphLineWidthLabel;
        private System.Windows.Forms.Label lineWidthLabel;
        private System.Windows.Forms.TrackBar graphLineWidthTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label greenValueLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label blueValueLabel;
        private System.Windows.Forms.Label redValueLabel;
    }
}

