using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace studentInfo
{
    public partial class signUP : Form
    {
        public signUP()
        {
            InitializeComponent();
        }

        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;

        SQLiteDataAdapter DB1;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void signUP_Load(object sender, EventArgs e)
        {
            LoadData();
         
        }

        private void setConnection() {
            sql_con = new SQLiteConnection("Data Source = Project1.db");
       
        }

        private void LoadData()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();


            string CommandText = "select * from studentInformation";
            DB1 = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            DB1.Fill(ds);
            dt = ds.Tables[0];
            StudentSignDGV.DataSource = dt;


            sql_con.Close();

        }
        private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into studentInformation (StudentName, ID, Birthdate, CourseandYear, Gender, Phone, Email) values('" + txtStudentName.Text + "', '" + txtStudentID.Text + "', '" + dtpBirthdate.Text + "', '" + txtCourse.Text + "', '" + cmbGender.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "') ";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from studentInformation where StudentName = '" + txtStudentName.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("deleted.");
        }

        private void StudentSignDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentName.Text = StudentSignDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtStudentID.Text = StudentSignDGV.SelectedRows[0].Cells[1].Value.ToString();
            dtpBirthdate.Text = StudentSignDGV.Rows[0].Cells[2].Value.ToString();
            txtCourse.Text = StudentSignDGV.SelectedRows[0].Cells[3].Value.ToString();
            cmbGender.Text = StudentSignDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtPhone.Text = StudentSignDGV.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = StudentSignDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string txtQuery = "update studentInformation set StudentName = '" + txtStudentName.Text + "', ID = '" + txtStudentID.Text + "', Birthdate = '" + dtpBirthdate.Text + "', CourseandYear = '" + txtCourse.Text + "', Gender = '" + cmbGender.Text + "', Phone = '" + txtPhone.Text + "', Email = '" + txtEmail.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Dispose();
        }
    }
}
