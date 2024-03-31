using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesBDLinQ;
using EmployeesBDLinQ.Datos;

namespace BDWFormCapas.Presentacion
{
    public partial class Form2 : Form
    {
        FormEmployees form1;
        employees selectedEmployee;
        bool isInsertMode;

        EmployeesBD employeesBD = new EmployeesBD();
        JobsBD jobsBD = new JobsBD();
        DepartmentsBD departmentsBD = new DepartmentsBD();

        public Form2(FormEmployees form1, employees selectedEmployee, bool isInsertMode)
        {
            InitializeComponent();
            this.form1 = form1;
            this.selectedEmployee = selectedEmployee;
            this.isInsertMode = isInsertMode;

            //Manager
            SelectEm();
            //Jobs
            cbxJobs.DataSource = jobsBD.Select();
            cbxJobs.DisplayMember = "job_title";
            cbxJobs.ValueMember = "job_id";
            //Department
            cbxDepartment.DataSource = departmentsBD.Select();
            cbxDepartment.DisplayMember = "department_name";
            cbxDepartment.ValueMember = "department_id";

            if (isInsertMode == true)
                Limpar();
            else
                RellenarFormulario();
            
        }

        private void SelectEm()
        {
            // Obtener los datos de los empleados
            var empleados = employeesBD.Select();

            // Crear una lista personalizada con DisplayMember y ValueMember
            var listaPersonalizada = empleados.Select(empleado => new
            {
                DisplayMember = $"{empleado.first_name} {empleado.last_name}",
                ValueMember = empleado.manager_id
            }).ToList();

            cbxManager.DataSource = listaPersonalizada;
            cbxManager.DisplayMember = "DisplayMember";
            cbxManager.ValueMember = "ValueMember";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(isInsertMode == true)
            {
                employeesBD.Insertar(Insert());
                Mensaje("Se ha insertado un empleado con exito!!!");
            }
            else
            {
                employeesBD.Update(Modify());
                Mensaje("Se ha actualizado un empleado con exito!!!");
            }
            Limpar();
            
            form1.Show();
            this.Close();
        }

        private employees Insert()
        {
            employees em = new employees()
            {
                first_name = txtName.Text,
                last_name = txtLastName.Text,
                email = txtEmail.Text,
                phone_number = txtPhone.Text,
                hire_date = dtpHireDate.Value.Date,
                fkjob_id = (int)cbxJobs.SelectedValue,
                salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : Convert.ToDecimal(txtSalary.Text),
                manager_id = cbxManager.SelectedValue != null ? (int)cbxManager.SelectedValue : (int?)null,
                department_id = cbxDepartment.SelectedValue != null ? (int)cbxDepartment.SelectedValue : (int?)null
            };

            return em;
        }

        private employees Modify()
        {
            employees em = selectedEmployee;

            em.first_name = txtName.Text;
            em.last_name = txtLastName.Text;
            em.email = txtEmail.Text;
            em.phone_number = txtPhone.Text;
            em.hire_date = dtpHireDate.Value.Date;
            em.fkjob_id = (int)cbxJobs.SelectedValue;
            em.salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : Convert.ToDecimal(txtSalary.Text);
            em.manager_id = cbxManager.SelectedValue != null ? (int)cbxManager.SelectedValue : (int?)null;
            em.department_id = cbxDepartment.SelectedValue != null ? (int)cbxDepartment.SelectedValue : (int?)null;

            return em;
        }
        private employees RellenarFormulario()
        {
            employees em = null;

            if (selectedEmployee != null)
            {
                em = selectedEmployee;

                txtName.Text = em.first_name;
                txtLastName.Text = em.last_name;
                txtEmail.Text = em.email;
                txtPhone.Text = em.phone_number;
                dtpHireDate.Value = em.hire_date;
                txtSalary.Text = em.salary.ToString();

                //Job
                cbxJobs.SelectedValue = em.fkjob_id;

                //Manager
                if (em.manager_id != null)
                    cbxManager.SelectedValue = em.manager_id;
                else
                    cbxManager.SelectedItem = null;

                //Department
                if (em.department_id != null)
                    cbxDepartment.SelectedValue = em.department_id;
                else
                    cbxManager.SelectedItem = null;
            }

            return em;
        }

        private void Limpar()
        {
            cbxManager.SelectedIndex = -1;
            txtName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            dtpHireDate.Value = DateTime.Now;
            txtSalary.Clear();
            cbxJobs.SelectedIndex = -1;
            cbxDepartment.SelectedIndex = -1;
        }

        private void Mensaje(string txt)
        {
            MessageBox.Show(txt);
        }
    }
}
