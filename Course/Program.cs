using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Threading;


namespace Course
{
    class Mathh
    {
        static public decimal Rand(decimal min, decimal max)
        {
            Random random = new Random();
            return ((decimal)random.NextDouble() * (max - min) + min);
        }
        public void Write_in_datebase()
        {
        }
    }

    class Analisis:Mathh
    {
        /// <summary>
        /// Класс для обработки данных
        /// </summary>
        [MTAThread]
        
        static public void Data_collection(int time, decimal velmin, decimal velmax, decimal tmin, decimal tmax, decimal hmin, decimal hmax, decimal amin, decimal amax)
        {

            using (var bd_connection = new SqliteConnection("Filename=weatherdata.db;Foreign Keys=True"))
            {
                bd_connection.Open();
                string sqlExpression = "INSERT INTO monitoring (day, time, velosity, temperature, humidity, air_quality_index) VALUES (@day, @time, @velosity, @temperature, @humidity, @air_quality_index)";



                decimal velosity = 0, temperature = 0, humidity = 0, air_quality_index = 0;
                int Houre = 0, secund = 0;


                Thread _thread = new Thread(() =>
                 {
                     Application.Run(new Form2());
                 });
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();

                while (Houre <= 86400)
                {
                    while (secund <= time)
                    {
                        velosity += Rand(velmin, velmax);
                        temperature += Rand(tmin, tmax);
                        humidity += Rand(hmin, hmax);
                        air_quality_index += Rand(amin, amax);
                        System.Threading.Thread.Sleep(5000);
                        secund += 5;
                    }
                            secund = 0;
                            decimal sr_v = velosity / (time/5);
                            decimal sr_t = temperature / (time / 5);
                            decimal sr_h = humidity / (time / 5);
                            decimal sr_a = air_quality_index / (time / 5);
                            SqliteCommand commandADD = new SqliteCommand(sqlExpression, bd_connection);
                            SqliteParameter dayParam = new SqliteParameter("@day", DateTime.Today.ToString());
                            SqliteParameter timeParam = new SqliteParameter("@time", DateTime.Now.Hour.ToString() +":"+ DateTime.Now.Minute.ToString());
                            SqliteParameter velosityParam = new SqliteParameter("@velosity", sr_v);
                            SqliteParameter temperatureParam = new SqliteParameter("@temperature", sr_t);
                            SqliteParameter humidityParam = new SqliteParameter("@humidity", sr_h);
                            SqliteParameter air_quality_indexParam = new SqliteParameter("@air_quality_index", sr_a);
                            commandADD.Parameters.Add(dayParam);
                            commandADD.Parameters.Add(timeParam);
                            commandADD.Parameters.Add(velosityParam);
                            commandADD.Parameters.Add(temperatureParam);
                            commandADD.Parameters.Add(humidityParam);
                            commandADD.Parameters.Add(air_quality_indexParam);
                            commandADD.ExecuteNonQuery();
                            velosity = 0;
                            temperature = 0;
                            humidity = 0;
                            air_quality_index = 0;
                            Houre+=time;
                           
                        }
                 
                    }
                   
                }

        static public void Data_collection_true()
        {
            decimal velosity = 0, temperature = 0, humidity = 0, air_quality_index = 0;
            uint Houre = 0, minutes = 0;
            Form1 Ffr = new Form1();
            while (Houre <= 24)
            {
                while (minutes <= 60)
                {
                    //снятие показаний с датчиков, я думаю ты знаешь как
                    System.Threading.Thread.Sleep(5000);
                    minutes++;
                }
                minutes = 0;
                decimal sr_v = velosity / 12;
                decimal sr_t = temperature / 12;
                decimal sr_h = humidity / 12;
                decimal sr_a = air_quality_index / 12;
                velosity = 0;
                temperature = 0;
                humidity = 0;
                air_quality_index = 0;
                Houre++;
            }
            MessageBox.Show("Показания сняты");
        }
        static public void Start_form()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

  
    }
    /// <summary>
    /// Класс для симулирования процесса с определеным коэффициентом ускорения
    /// </summary>
    class Fake_sensor : Analisis
    {
        static void Main()
        {
            
            Fake_sensor.Start_form();
           
        }
        static public void Start_Start(int step,decimal min, decimal max, decimal tmin, decimal tmax, decimal hmin, decimal hmax, decimal amin, decimal amax)
        {
            Data_collection(step, min, max,tmin,tmax,hmin,hmax,amin,amax);
        }
    }
    class True_sensor : Analisis
    {
        [STAThread]
        static void Main()
        {
            {

                True_sensor.Start_form();

            }
        }
        static public void Start_True(decimal min, decimal max)
        {
            Data_collection_true();
        }
    }
}
