using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Windage;

namespace ResultForce
{
    public partial class Form1 : Form
    {
        //Путь до Tle файла
        private string path = "";
        private DateTime dateAll1, dateAll2, date1, date2; 
        private int stepNum = -1;
        private string stepType = "";
        private List<List<string>> AllTle; //Список всех Tle координат
        private List<List<string>> SortTle; //Спико отсортированных Tle координат
        Dictionary<DateTime, double> PointForRaduis;
        Dictionary<DateTime, double> PointsForResCoeff;

        private enum TimeslotType
        {
            Minute,
            Hour,
            Day,
            Week,
            Month,
            Year
        }

        public Form1()
        {
            InitializeComponent();

            InitialSetupOfFormComponents();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_FirstMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_FirstMonth.Checked)
            {
                dateTimePicker_Interval1.Enabled = false;
                dateTimePicker_Interval2.Enabled = false;
            }
            date1 = dateAll1;
            date2 = date1.AddMonths(1);
        }

        private void radioButton_FirstYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_FirstYear.Checked)
            {
                dateTimePicker_Interval1.Enabled = false;
                dateTimePicker_Interval2.Enabled = false;
            }
            date1 = dateAll1;
            date2 = date1.AddYears(1);
        }

        private void radioButton_AllTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_AllTime.Checked)
            {
                dateTimePicker_Interval1.Enabled = false;
                dateTimePicker_Interval2.Enabled = false;
            }
            date1 = dateAll1;
            date2 = dateAll2;
        }

        private void radioButton_AnotherInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_AnotherInterval.Checked)
            {
                dateTimePicker_Interval1.Enabled = true;
                dateTimePicker_Interval2.Enabled = true;
            }
        }

        private void dateTimePicker_Interval1_ValueChanged(object sender, EventArgs e)
        {
            date1 = dateTimePicker_Interval1.Value;
        }

        private void dateTimePicker_Interval2_ValueChanged(object sender, EventArgs e)
        {
            date2 = dateTimePicker_Interval2.Value; 
        }


        private void ComboBox_typeInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            stepType = comboBox_typeInterval.SelectedItem.ToString();
            if (stepType.Length > 0)
            {
                numericUpDown_Interval.Enabled = true;
            }
            //Ставим интервал в зависимсоти от выбора пользователя
            switch (stepType)
            {
                case "Minute":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
                    break;
                case "Hour":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
                    break;
                case "Day":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    break;
                case "Week":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    break;
                case "Month":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    break;
                case "Year":
                    this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                    this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    break;
            }
        }

        private void numericUpDown_Interval_ValueChanged(object sender, EventArgs e)
        {
            stepNum = Convert.ToInt32(numericUpDown_Interval.Value);
            this.chart1.ChartAreas[0].AxisX.Interval = stepNum;
        }

        private void radioButton_DefaultStep_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_DefaultStep.Checked)
            {
                comboBox_typeInterval.Enabled = false;
                numericUpDown_Interval.Enabled = false;
            }
        }

        private void radioButton_AnotherStep_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_AnotherStep.Checked)
            {
                comboBox_typeInterval.Enabled = true;
            }
        }

        private void buildAGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Обрабатываем ошибки
            HandlingErrors();

            //Получаем массив Tle отсортированный по датам
            SortTle = ResistanceFactor.ChoiseTle(AllTle, date1, date2);

            //Задаем параметры осей
            SetUpCoordinateAxes();

            //очищаем старые графики
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            //Строим графики а зависимости от выбранного бокса
            if (radioButton_distanceFromEarthToSite.Checked)
            {
                BulidGraphRadius();
            }
            if (radioButton_atmosphericResCoeff.Checked)
            {
                BuildGraphResCoeff();
            }
        }

        private void BulidGraphRadius()
        {
            PointForRaduis = ResistanceFactor.GetRadiusFull(SortTle);
            this.chart1.ChartAreas[0].AxisY.Minimum = 6800;
            this.chart1.ChartAreas[0].AxisY.Maximum = 7000;
            foreach (var item in PointForRaduis)
                this.chart1.Series[0].Points.AddXY(item.Key, item.Value);
        }

        private void BuildGraphResCoeff()
        {
            PointsForResCoeff = ResistanceFactor.AtmosphericResistanceCoefficient(SortTle);
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 0.0000005;
            foreach (var item in PointsForResCoeff)
                this.chart1.Series[1].Points.AddXY(item.Key, item.Value);
        }

        private void clearAGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!radioButton_distanceFromEarthToSite.Checked && !radioButton_atmosphericResCoeff.Checked)
            {
                MessageBox.Show("Please select at least one chart");
                return;
            }
            if (radioButton_distanceFromEarthToSite.Checked)
            {
                this.chart1.Series[0].Points.Clear();
            }
            if (radioButton_atmosphericResCoeff.Checked)
            {
                this.chart1.Series[1].Points.Clear();
            }
        }

        private void Button_SearchTleFile_Click(object sender, EventArgs e)
        {
            //Предоставляем пользователю выбрать путь до Tle файла
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox_Path.Text = ofd.FileName;
            else return;
            path = textBox_Path.Text;
            SetParameters(path);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_distanceFromEarthToSite_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_atmosphericResCoeff_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Настраиваем элементы в начале работы
        private void InitialSetupOfFormComponents()
        {
            radioButton_DefaultStep.Checked = true;
            radioButton_FirstMonth.Enabled = false;
            radioButton_FirstYear.Enabled = false;
            radioButton_AnotherInterval.Enabled = false;
            radioButton_AllTime.Enabled = false;
            radioButton_distanceFromEarthToSite.Enabled = false;
            radioButton_atmosphericResCoeff.Enabled = false;
            dateTimePicker_Interval1.Enabled = false;
            dateTimePicker_Interval2.Enabled = false;
            comboBox_typeInterval.Enabled = false;
            numericUpDown_Interval.Enabled = false;
            radioButton_DefaultStep.Enabled = false;
            radioButton_AnotherStep.Enabled = false;
            comboBox_typeInterval.Items.AddRange(Enum.GetNames(typeof(TimeslotType)));
            numericUpDown_Interval.Minimum = 1;
            numericUpDown_Interval.Maximum = 365;
        }

        //Первичная обработка входных Tle координат
        private void SetParameters(string path)
        {
            //Считанные Tle координаты сохраняем в лист
            AllTle = ResistanceFactor.ReadTleFromFile(path);

            //Определяем временные границы Tle координат
            dateAll1 = ResistanceFactor.ConvertNumberToDate(AllTle[0][0].Substring(18, 5));
            dateAll2 = ResistanceFactor.ConvertNumberToDate(AllTle[AllTle.Count - 1][0].Substring(18, 5));
            radioButton_AllTime.Enabled = true;
            radioButton_AnotherInterval.Enabled = true;
            radioButton_DefaultStep.Enabled = true;
            radioButton_AnotherStep.Enabled = true;
            radioButton_atmosphericResCoeff.Enabled = true;
            radioButton_distanceFromEarthToSite.Enabled = true;

            //Настраиваем календари для произвольного интервала
            dateTimePicker_Interval1.MinDate = dateAll1;
            dateTimePicker_Interval1.MaxDate = dateAll2;
            dateTimePicker_Interval2.MinDate = dateAll1;
            dateTimePicker_Interval2.MaxDate = dateAll2;
            dateTimePicker_Interval1.Value = dateAll1;
            dateTimePicker_Interval2.Value = dateAll2;

            //В зависимости от временных гариц задаем временной промежуток 
            if (path != "" && (dateAll2 - dateAll1).Days >= 30) radioButton_FirstMonth.Enabled = true;
            else radioButton_FirstMonth.Enabled = false;
            if (path != "" && (dateAll2 - dateAll1).Days >= 365) radioButton_FirstYear.Enabled = true;
            else radioButton_FirstYear.Enabled = false;
        }

        private void HandlingErrors()
        {
            //Обрабатываем различные эксепшены
            if (path == "")
            {
                MessageBox.Show("Please choose the path to the Tle file");
                return;
            }
            if (!radioButton_FirstMonth.Checked && !radioButton_FirstYear.Checked && !radioButton_AllTime.Checked
                && !radioButton_AnotherInterval.Checked)
            {
                MessageBox.Show("Please select a time interval");
                return;
            }
            if (date2 <= date1)
            {
                MessageBox.Show("The selected interval is incorrect", "Warning");
                return;
            }
            if (!radioButton_atmosphericResCoeff.Checked && !radioButton_distanceFromEarthToSite.Checked)
            {
                MessageBox.Show("Please select at least one chart");
                return;
            }
            if (radioButton_DefaultStep.Checked)
            {
                this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;
                this.chart1.ChartAreas[0].AxisX.Interval = 0;

            }
            if (radioButton_AnotherStep.Checked)
            {
                if (stepType.Length == 0 || stepNum == -1)
                {
                    MessageBox.Show("Please select step");
                    return;
                }
            }
        }

        private void SetUpCoordinateAxes()
        {
            //Задаем параметры осей координат
            this.chart1.Series[0].XValueType = ChartValueType.DateTime;
            this.chart1.Series[1].XValueType = ChartValueType.DateTime;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            this.chart1.ChartAreas[0].AxisX.Minimum = date1.ToOADate();
            this.chart1.ChartAreas[0].AxisX.Maximum = date2.ToOADate();
            this.chart1.Series[0].YValueType = ChartValueType.Double;
            this.chart1.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle; //Устанавливаем стрелочки
            this.chart1.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle; //Устанавливаем стрелочки
        }
    }
}
