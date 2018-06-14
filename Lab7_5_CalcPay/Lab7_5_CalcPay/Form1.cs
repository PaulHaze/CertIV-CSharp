using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_5_CalcPay
{
    public partial class Form1 : Form
    {
        double hourlyRate;
        double normalHours;
        double overtimeHours;

        public Form1()
        {
            InitializeComponent();
        }

        void Pay(double x, double y, double z)
        {
            double total = (x * y) + ((x * 1.5) * z);
            MessageBox.Show($"Your hourly rate is: ${x}\nYour total normal hours were: {y}\nYour total overtime hours were: {z}");
            MessageBox.Show($"Normal hour pay: ${x * y}\nOvertime pay: ${((x * 1.5) * z)}\nTotal overall pay: ${total}");
            txtHourRate.Clear();
            txtNormalHours.Clear();
            txtOvertimeHours.Clear();
            txtHourRate.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hourlyRate = double.Parse(txtHourRate.Text);
            normalHours = double.Parse(txtNormalHours.Text);
            overtimeHours = double.Parse(txtOvertimeHours.Text);
            Pay(hourlyRate, normalHours, overtimeHours);
        }
    }
}
