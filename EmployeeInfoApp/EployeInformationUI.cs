using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoApp
{
    public partial class EployeInformationUI : Form
    {
        public EployeInformationUI()
        {
            InitializeComponent();
        }
        EmplyeeInfo employeeInfor= new EmplyeeInfo();
        private void showButton_Click(object sender, EventArgs e)
        {
            
                employeeInfor.id = IdTextBox.Text;
                employeeInfor.name = nameTextBox.Text;
                employeeInfor.salary = Convert.ToInt32(salaryTextBox.Text);
                ClearTextBox();
                MessageBox.Show("ID: " + employeeInfor.id + "\nName: " + employeeInfor.name + "\nSalary: " + employeeInfor.salary);
        }


        private void retriveButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = employeeInfor.id;
            nameTextBox.Text = employeeInfor.name;
            salaryTextBox.Text = Convert.ToString(employeeInfor.salary);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeInfor= new EmplyeeInfo();
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            IdTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
        }

    }
}
