using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Course
{
    public partial class Form1 : Form
    {
        
        public decimal velosity_min_value;
        public decimal velosity_max_value;
        public decimal temperature_max_value;
        public decimal temperature_min_value;
        public decimal humidity_max_value;
        public decimal humidity_min_value;
        public decimal air_quality_min_value;
        public decimal air_quality_max_value;
        public Form1()
        {
        
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Start_Click(object sender, EventArgs e)
        {
            this.Hide();

            velosity_min_value = velosity_min.Value;
            velosity_max_value = velosity_max.Value;
            temperature_max_value = temperature_max.Value;
            temperature_min_value = temperature_min.Value;
            humidity_max_value = humidity_max.Value;
            humidity_min_value = humidity_min.Value;
            air_quality_max_value = air_quality_max.Value;
            air_quality_min_value = air_quality_min.Value;
            Fake_sensor.Start_Start(velosity_min_value, velosity_max_value, temperature_min_value, temperature_max_value, humidity_min_value, humidity_max_value, air_quality_min_value, air_quality_max_value);
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
