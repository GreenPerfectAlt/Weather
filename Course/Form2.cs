using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Data.Sqlite;
using System.Threading;
namespace Course
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

            private void button1_Click(object sender, EventArgs e)
        {

            string _time = "0";
            double _velosity = 0;
            double _temperature = 0;
            double _humidity = 0;
            double _air_quality_index = 0;
            using (var bd_connection = new SqliteConnection("Filename=weatherdata.db;Foreign Keys=True"))
            {
                bd_connection.Open();

                string sqlExpression = "SELECT * FROM monitoring where day = '" + DateTime.Today.ToString() + "'";

                SqliteCommand commandVIEW = new SqliteCommand(sqlExpression, bd_connection);

                cartesianChart1.LegendLocation = LegendLocation.Bottom;


                SqliteDataReader reader = commandVIEW.ExecuteReader();//считывание данных

                SeriesCollection series = new SeriesCollection();

                List<string> bd_times = new List<string>();
                ChartValues<double> bd_velosity = new ChartValues<double>();
                ChartValues<double> bd_temperature = new ChartValues<double>();
                ChartValues<double> bd_humidity = new ChartValues<double>();
                ChartValues<double> bd_air_quality_index = new ChartValues<double>();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {

                        _time = reader.GetString(0); bd_times.Add((reader.GetString(1)));
                        _velosity = reader.GetDouble(1); bd_velosity.Add(Convert.ToDouble(reader.GetDouble(2)));
                        _temperature = reader.GetDouble(2); bd_temperature.Add(Convert.ToDouble(reader.GetDouble(3)));
                        _humidity = reader.GetDouble(3); bd_humidity.Add(Convert.ToDouble(reader.GetDouble(4)));
                        _air_quality_index = reader.GetDouble(4); bd_air_quality_index.Add(Convert.ToDouble(reader.GetDouble(5)));


                    }
                }
                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(new Axis()
                {
                    Title = "" + DateTime.Today,
                    Labels = bd_times
                });

                LineSeries line1 = new LineSeries();
                line1.Title = "Скорость воздуха";
                line1.Values = bd_velosity;


                LineSeries line2 = new LineSeries();
                line2.Title = "Температура";
                line2.Values = bd_temperature;


                LineSeries line3 = new LineSeries();
                line3.Title = "Влажность";
                line3.Values = bd_humidity;


                LineSeries line4 = new LineSeries();
                line4.Title = "Коэффициент";
                line4.Values = bd_air_quality_index;


                series.Add(line1);
                series.Add(line2);
                series.Add(line3);
                series.Add(line4);

                cartesianChart1.Series = series;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
