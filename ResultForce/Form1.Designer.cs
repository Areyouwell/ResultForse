
namespace ResultForce
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.Button_SearchTleFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Interval2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Interval1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_AnotherInterval = new System.Windows.Forms.RadioButton();
            this.radioButton_AllTime = new System.Windows.Forms.RadioButton();
            this.radioButton_FirstYear = new System.Windows.Forms.RadioButton();
            this.radioButton_FirstMonth = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_PotentialEn = new System.Windows.Forms.CheckBox();
            this.checkBox_KineticEn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Interval = new System.Windows.Forms.NumericUpDown();
            this.comboBox_typeInterval = new System.Windows.Forms.ComboBox();
            this.radioButton_AnotherStep = new System.Windows.Forms.RadioButton();
            this.radioButton_DefaultStep = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.Legend = "Legend1";
            series1.LegendText = "Alpha(t)    (Kinetic)";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Navy;
            series2.Legend = "Legend1";
            series2.LegendText = "2*Alpha(t)    (Potential) ";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(962, 537);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAGraphToolStripMenuItem,
            this.clearAGraphToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // buildAGraphToolStripMenuItem
            // 
            this.buildAGraphToolStripMenuItem.Name = "buildAGraphToolStripMenuItem";
            this.buildAGraphToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.buildAGraphToolStripMenuItem.Text = "Build graph";
            this.buildAGraphToolStripMenuItem.Click += new System.EventHandler(this.buildAGraphToolStripMenuItem_Click);
            // 
            // clearAGraphToolStripMenuItem
            // 
            this.clearAGraphToolStripMenuItem.Name = "clearAGraphToolStripMenuItem";
            this.clearAGraphToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clearAGraphToolStripMenuItem.Text = "Clear graph";
            this.clearAGraphToolStripMenuItem.Click += new System.EventHandler(this.clearAGraphToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 575);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Path);
            this.groupBox2.Controls.Add(this.Button_SearchTleFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1007, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // textBox_Path
            // 
            this.textBox_Path.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Path.ForeColor = System.Drawing.Color.Red;
            this.textBox_Path.Location = new System.Drawing.Point(11, 86);
            this.textBox_Path.Multiline = true;
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Path.Size = new System.Drawing.Size(259, 41);
            this.textBox_Path.TabIndex = 2;
            this.textBox_Path.WordWrap = false;
            this.textBox_Path.TextChanged += new System.EventHandler(this.textBox_Path_TextChanged);
            // 
            // Button_SearchTleFile
            // 
            this.Button_SearchTleFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchTleFile.Location = new System.Drawing.Point(11, 46);
            this.Button_SearchTleFile.Name = "Button_SearchTleFile";
            this.Button_SearchTleFile.Size = new System.Drawing.Size(85, 34);
            this.Button_SearchTleFile.TabIndex = 1;
            this.Button_SearchTleFile.Text = "Browse";
            this.Button_SearchTleFile.UseVisualStyleBackColor = true;
            this.Button_SearchTleFile.Click += new System.EventHandler(this.Button_SearchTleFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify the path to the Tle file";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker_Interval2);
            this.groupBox3.Controls.Add(this.dateTimePicker_Interval1);
            this.groupBox3.Controls.Add(this.radioButton_AnotherInterval);
            this.groupBox3.Controls.Add(this.radioButton_AllTime);
            this.groupBox3.Controls.Add(this.radioButton_FirstYear);
            this.groupBox3.Controls.Add(this.radioButton_FirstMonth);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1007, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 206);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "from";
            // 
            // dateTimePicker_Interval2
            // 
            this.dateTimePicker_Interval2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Interval2.Location = new System.Drawing.Point(90, 171);
            this.dateTimePicker_Interval2.Name = "dateTimePicker_Interval2";
            this.dateTimePicker_Interval2.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker_Interval2.TabIndex = 6;
            this.dateTimePicker_Interval2.ValueChanged += new System.EventHandler(this.dateTimePicker_Interval2_ValueChanged);
            // 
            // dateTimePicker_Interval1
            // 
            this.dateTimePicker_Interval1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Interval1.Location = new System.Drawing.Point(90, 140);
            this.dateTimePicker_Interval1.Name = "dateTimePicker_Interval1";
            this.dateTimePicker_Interval1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker_Interval1.TabIndex = 5;
            this.dateTimePicker_Interval1.ValueChanged += new System.EventHandler(this.dateTimePicker_Interval1_ValueChanged);
            // 
            // radioButton_AnotherInterval
            // 
            this.radioButton_AnotherInterval.AutoSize = true;
            this.radioButton_AnotherInterval.Location = new System.Drawing.Point(30, 113);
            this.radioButton_AnotherInterval.Name = "radioButton_AnotherInterval";
            this.radioButton_AnotherInterval.Size = new System.Drawing.Size(98, 17);
            this.radioButton_AnotherInterval.TabIndex = 4;
            this.radioButton_AnotherInterval.TabStop = true;
            this.radioButton_AnotherInterval.Text = "another interval";
            this.radioButton_AnotherInterval.UseVisualStyleBackColor = true;
            this.radioButton_AnotherInterval.CheckedChanged += new System.EventHandler(this.radioButton_AnotherInterval_CheckedChanged);
            // 
            // radioButton_AllTime
            // 
            this.radioButton_AllTime.AutoSize = true;
            this.radioButton_AllTime.Location = new System.Drawing.Point(30, 90);
            this.radioButton_AllTime.Name = "radioButton_AllTime";
            this.radioButton_AllTime.Size = new System.Drawing.Size(57, 17);
            this.radioButton_AllTime.TabIndex = 3;
            this.radioButton_AllTime.TabStop = true;
            this.radioButton_AllTime.Text = "all time";
            this.radioButton_AllTime.UseVisualStyleBackColor = true;
            this.radioButton_AllTime.CheckedChanged += new System.EventHandler(this.radioButton_AllTime_CheckedChanged);
            // 
            // radioButton_FirstYear
            // 
            this.radioButton_FirstYear.AutoSize = true;
            this.radioButton_FirstYear.Location = new System.Drawing.Point(30, 67);
            this.radioButton_FirstYear.Name = "radioButton_FirstYear";
            this.radioButton_FirstYear.Size = new System.Drawing.Size(64, 17);
            this.radioButton_FirstYear.TabIndex = 2;
            this.radioButton_FirstYear.TabStop = true;
            this.radioButton_FirstYear.Text = "first year";
            this.radioButton_FirstYear.UseVisualStyleBackColor = true;
            this.radioButton_FirstYear.CheckedChanged += new System.EventHandler(this.radioButton_FirstYear_CheckedChanged);
            // 
            // radioButton_FirstMonth
            // 
            this.radioButton_FirstMonth.AutoSize = true;
            this.radioButton_FirstMonth.Location = new System.Drawing.Point(30, 44);
            this.radioButton_FirstMonth.Name = "radioButton_FirstMonth";
            this.radioButton_FirstMonth.Size = new System.Drawing.Size(73, 17);
            this.radioButton_FirstMonth.TabIndex = 1;
            this.radioButton_FirstMonth.TabStop = true;
            this.radioButton_FirstMonth.Text = "first month";
            this.radioButton_FirstMonth.UseVisualStyleBackColor = true;
            this.radioButton_FirstMonth.CheckedChanged += new System.EventHandler(this.radioButton_FirstMonth_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select interval";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_PotentialEn);
            this.groupBox4.Controls.Add(this.checkBox_KineticEn);
            this.groupBox4.Location = new System.Drawing.Point(1007, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 84);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Method";
            // 
            // checkBox_PotentialEn
            // 
            this.checkBox_PotentialEn.AutoSize = true;
            this.checkBox_PotentialEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_PotentialEn.Location = new System.Drawing.Point(30, 49);
            this.checkBox_PotentialEn.Name = "checkBox_PotentialEn";
            this.checkBox_PotentialEn.Size = new System.Drawing.Size(163, 28);
            this.checkBox_PotentialEn.TabIndex = 1;
            this.checkBox_PotentialEn.Text = "potential energy";
            this.checkBox_PotentialEn.UseVisualStyleBackColor = true;
            this.checkBox_PotentialEn.CheckedChanged += new System.EventHandler(this.checkBox_PotentialEn_CheckedChanged);
            // 
            // checkBox_KineticEn
            // 
            this.checkBox_KineticEn.AutoSize = true;
            this.checkBox_KineticEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_KineticEn.Location = new System.Drawing.Point(30, 19);
            this.checkBox_KineticEn.Name = "checkBox_KineticEn";
            this.checkBox_KineticEn.Size = new System.Drawing.Size(146, 28);
            this.checkBox_KineticEn.TabIndex = 0;
            this.checkBox_KineticEn.Text = "kinetic energy";
            this.checkBox_KineticEn.UseVisualStyleBackColor = true;
            this.checkBox_KineticEn.CheckedChanged += new System.EventHandler(this.checkBox_KineticEn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select step";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown_Interval);
            this.groupBox5.Controls.Add(this.comboBox_typeInterval);
            this.groupBox5.Controls.Add(this.radioButton_AnotherStep);
            this.groupBox5.Controls.Add(this.radioButton_DefaultStep);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(1007, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 126);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step";
            // 
            // numericUpDown_Interval
            // 
            this.numericUpDown_Interval.Location = new System.Drawing.Point(164, 90);
            this.numericUpDown_Interval.Name = "numericUpDown_Interval";
            this.numericUpDown_Interval.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_Interval.TabIndex = 5;
            this.numericUpDown_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_Interval_ValueChanged);
            // 
            // comboBox_typeInterval
            // 
            this.comboBox_typeInterval.FormattingEnabled = true;
            this.comboBox_typeInterval.Location = new System.Drawing.Point(30, 90);
            this.comboBox_typeInterval.Name = "comboBox_typeInterval";
            this.comboBox_typeInterval.Size = new System.Drawing.Size(102, 21);
            this.comboBox_typeInterval.TabIndex = 4;
            this.comboBox_typeInterval.SelectedIndexChanged += new System.EventHandler(this.ComboBox_typeInterval_SelectedIndexChanged);
            // 
            // radioButton_AnotherStep
            // 
            this.radioButton_AnotherStep.AutoSize = true;
            this.radioButton_AnotherStep.Location = new System.Drawing.Point(31, 67);
            this.radioButton_AnotherStep.Name = "radioButton_AnotherStep";
            this.radioButton_AnotherStep.Size = new System.Drawing.Size(84, 17);
            this.radioButton_AnotherStep.TabIndex = 3;
            this.radioButton_AnotherStep.TabStop = true;
            this.radioButton_AnotherStep.Text = "another step";
            this.radioButton_AnotherStep.UseVisualStyleBackColor = true;
            this.radioButton_AnotherStep.CheckedChanged += new System.EventHandler(this.radioButton_AnotherStep_CheckedChanged);
            // 
            // radioButton_DefaultStep
            // 
            this.radioButton_DefaultStep.AutoSize = true;
            this.radioButton_DefaultStep.Location = new System.Drawing.Point(31, 44);
            this.radioButton_DefaultStep.Name = "radioButton_DefaultStep";
            this.radioButton_DefaultStep.Size = new System.Drawing.Size(80, 17);
            this.radioButton_DefaultStep.TabIndex = 2;
            this.radioButton_DefaultStep.TabStop = true;
            this.radioButton_DefaultStep.Text = "default step";
            this.radioButton_DefaultStep.UseVisualStyleBackColor = true;
            this.radioButton_DefaultStep.CheckedChanged += new System.EventHandler(this.radioButton_DefaultStep_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 614);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildAGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_PotentialEn;
        private System.Windows.Forms.CheckBox checkBox_KineticEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_AnotherInterval;
        private System.Windows.Forms.RadioButton radioButton_AllTime;
        private System.Windows.Forms.RadioButton radioButton_FirstYear;
        private System.Windows.Forms.RadioButton radioButton_FirstMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Interval1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Interval;
        private System.Windows.Forms.ComboBox comboBox_typeInterval;
        private System.Windows.Forms.RadioButton radioButton_AnotherStep;
        private System.Windows.Forms.RadioButton radioButton_DefaultStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Interval2;
        private System.Windows.Forms.Button Button_SearchTleFile;
        private System.Windows.Forms.TextBox textBox_Path;
    }
}

