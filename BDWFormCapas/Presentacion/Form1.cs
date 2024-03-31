using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BDWFormCapas;
using BDWFormCapas.Presentacion;
using EmployeesBDLinQ.Datos;

namespace EmployeesBDLinQ
{
    public partial class FormEmployees : Form
    {
        Form2 form2;
        employees selectedEmployee = null;
        EmployeesBD employeesBD = new EmployeesBD();

        public FormEmployees()
        {
            InitializeComponent();
            form2 = new Form2(this, selectedEmployee, true);

            RefreshList();
        }

        private void RefreshList()
        {
            listEmployees.DataSource = employeesBD.Select();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this, null, true);
            form2.ShowDialog();
            RefreshList();
        }

        private void BtnDelate_Click(object sender, EventArgs e)
        {
            employees em = (employees)listEmployees.SelectedItem;

            employeesBD.Delete(em);
            Mensaje("Se ha eliminado un empleado con exito!!!");
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employees selectedEmployee = (employees)listEmployees.SelectedItem;
            form2 = new Form2(this, selectedEmployee, false);
            form2.ShowDialog();
        }

        private void Mensaje(string txt)
        {
            MessageBox.Show(txt);
        }
    }

    public partial class employees
    {
        public override string ToString()
        {
            return first_name + ' ' + last_name;
        }
    }
}


