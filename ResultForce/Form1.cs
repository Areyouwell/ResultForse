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
        private string path = "";
        private DateTime dateAll1, dateAll2, date1, date2;
        private int stepNum = -1;
        private string stepType = "";
        private List<List<string>> AllTle;
        private List<List<string>> SortTle; 
        Dictionary<DateTime, double> PointsForKinetic;
        Dictionary<DateTime, double> PointsForPotential;
        private enum TimeslotType
        {
            Day,
            Week,
            Month,
            Year
        }

        public Form1()
        {
            InitializeComponent();

            radioButton_DefaultStep.Checked = true;
            radioButton_FirstMonth.Enabled = false;
            radioButton_FirstYear.Enabled = false;
            radioButton_AnotherInterval.Enabled = false;
            radioButton_AllTime.Enabled = false;
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
        }

        private void numericUpDown_Interval_ValueChanged(object sender, EventArgs e)
        {
            stepNum = Convert.ToInt32(numericUpDown_Interval.Value);
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

        private void checkBox_KineticEn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_PotentialEn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buildAGraphToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (!checkBox_KineticEn.Checked && !checkBox_PotentialEn.Checked)
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
                if (stepType.Length == 0)
                {
                    MessageBox.Show("Please select step");
                    return;
                }
                //Ставим интервал в зависимсоти от выбора пользователя
                switch (stepType)
                {
                    case "Day":
                        this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                        break;
                    case "Week":
                        this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
                        break;
                    case "Month":
                        this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                        break;
                    case "Year":
                        this.chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                        break;
                }
                this.chart1.ChartAreas[0].AxisX.Interval = stepNum;
            }

            //Получаем массивы точек для потенциальной и кинетической энергий
            SortTle = ResistanceFactor.ChoiseTle(AllTle, date1, date2);
            Dictionary<DateTime, double>[] PointsForTwoGraphs = ResistanceFactor.FormResultDictionary(SortTle);
            PointsForKinetic = PointsForTwoGraphs[0];
            PointsForPotential = PointsForTwoGraphs[1];

            //Задаем параметры осей координат
            this.chart1.Series[0].XValueType = ChartValueType.DateTime;
            this.chart1.Series[1].XValueType = ChartValueType.DateTime;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            this.chart1.ChartAreas[0].AxisX.Minimum = date1.ToOADate();
            this.chart1.ChartAreas[0].AxisX.Maximum = date2.ToOADate();
            this.chart1.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            this.chart1.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle;

            //очищаем старые графики
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            //Строим графики а зависимости от выбранного чекбокса
            if (checkBox_KineticEn.Checked)
            {
                foreach (var item in PointsForKinetic)
                    this.chart1.Series[0].Points.AddXY(item.Key, item.Value);
            }
            if (checkBox_PotentialEn.Checked)
            {
                foreach (var item in PointsForPotential)
                    this.chart1.Series[1].Points.AddXY(item.Key, item.Value);
            }
        }

        private void clearAGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkBox_KineticEn.Checked && !checkBox_PotentialEn.Checked)
            {
                MessageBox.Show("Please select at least one chart");
                return;
            }
            if (checkBox_KineticEn.Checked)
            {
                this.chart1.Series[0].Points.Clear();
            }
            if (checkBox_PotentialEn.Checked)
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

        private void textBox_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            //Настраиваем календари для произвольного интервала
            dateTimePicker_Interval1.MinDate = dateAll1;
            dateTimePicker_Interval1.MaxDate = dateAll2;
            dateTimePicker_Interval2.MinDate = dateAll1;
            dateTimePicker_Interval2.MaxDate = dateAll2;
            dateTimePicker_Interval1.Value = dateAll1;

            //В зависимости от временных гариц задаем временной промежуток 
            if (path != "" && (dateAll2 - dateAll1).Days >= 30) radioButton_FirstMonth.Enabled = true;
            else radioButton_FirstMonth.Enabled = false;
            if (path != "" && (dateAll2 - dateAll1).Days >= 365) radioButton_FirstYear.Enabled = true;
            else radioButton_FirstYear.Enabled = false;
        }
    }
}
