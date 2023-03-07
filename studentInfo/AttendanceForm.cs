using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentInfo
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            cmbShortDROP.Items.Add("P - Present");
            cmbShortDROP.Items.Add("0 - Absent");
            cmbShortDROP.Items.Add("S - Sick");
            cmbShortDROP.Items.Add("E - Excused");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbShortDROP.Text == "P - Present")
            {
                comboBox1.Text = "Present";
                comboBox2.Text = "Present";
                comboBox3.Text = "Present";
                comboBox4.Text = "Present";
                comboBox5.Text = "Present";
                comboBox6.Text = "Present";
                comboBox7.Text = "Present";
                comboBox8.Text = "Present";
                comboBox9.Text = "Present";
                comboBox10.Text = "Present";
                comboBox11.Text = "Present";
                comboBox12.Text = "Present";
                comboBox13.Text = "Present";
                comboBox14.Text = "Present";
                comboBox15.Text = "Present";
                comboBox16.Text = "Present";
                comboBox17.Text = "Present";
                comboBox18.Text = "Present";
                comboBox19.Text = "Present";
                comboBox20.Text = "Present";

            }
            else if (cmbShortDROP.Text == "0 - Absent")
            {
                comboBox1.Text = "Absent";
                comboBox2.Text = "Absent";
                comboBox3.Text = "Absent";
                comboBox4.Text = "Absent";
                comboBox5.Text = "Absent";
                comboBox6.Text = "Absent";
                comboBox7.Text = "Absent";
                comboBox8.Text = "Absent";
                comboBox9.Text = "Absent";
                comboBox10.Text = "Absent";
                comboBox11.Text = "Absent";
                comboBox12.Text = "Absent";
                comboBox13.Text = "Absent";
                comboBox14.Text = "Absent";
                comboBox15.Text = "Absent";
                comboBox16.Text = "Absent";
                comboBox17.Text = "Absent";
                comboBox18.Text = "Absent";
                comboBox19.Text = "Absent";
                comboBox20.Text = "Absent";
            }
            else if (cmbShortDROP.Text == "S - Sick")
            {
                comboBox1.Text = "Sick";
                comboBox2.Text = "Sick";
                comboBox3.Text = "Sick";
                comboBox4.Text = "Sick";
                comboBox5.Text = "Sick";
                comboBox6.Text = "Sick";
                comboBox7.Text = "Sick";
                comboBox8.Text = "Sick";
                comboBox9.Text = "Sick";
                comboBox10.Text = "Sick";
                comboBox11.Text = "Sick";
                comboBox12.Text = "Sick";
                comboBox13.Text = "Sick";
                comboBox14.Text = "Sick";
                comboBox15.Text = "Sick";
                comboBox16.Text = "Sick";
                comboBox17.Text = "Sick";
                comboBox18.Text = "Sick";
                comboBox19.Text = "Sick";
                comboBox20.Text = "Sick";
            }
            else if (cmbShortDROP.Text == "E - Excused")
            {
                comboBox1.Text = "Excused";
                comboBox2.Text = "Excused";
                comboBox3.Text = "Excused";
                comboBox4.Text = "Excused";
                comboBox5.Text = "Excused";
                comboBox6.Text = "Excused";
                comboBox7.Text = "Excused";
                comboBox8.Text = "Excused";
                comboBox9.Text = "Excused";
                comboBox10.Text = "Excused";
                comboBox11.Text = "Excused";
                comboBox12.Text = "Excused";
                comboBox13.Text = "Excused";
                comboBox14.Text = "Excused";
                comboBox15.Text = "Excused";
                comboBox16.Text = "Excused";
                comboBox17.Text = "Excused";
                comboBox18.Text = "Excused";
                comboBox19.Text = "Excused";
                comboBox20.Text = "Excused";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Stop();
            pictureBox1.Dispose();

        }
    }
}
