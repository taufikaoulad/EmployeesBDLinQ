using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDWFormCapas;

namespace EmployeesBDLinQ.Datos
{
    public class EmployeesBD
    {
        DBEmployeesDataContext dc = new DBEmployeesDataContext();

        public void Insertar(employees empleado)
        {
            dc.employees.InsertOnSubmit(empleado);
            dc.SubmitChanges();
        }

        public IQueryable<employees> Select()
        {
            var data = from emp in dc.employees
                           select emp;
            
            return data;
        }

        public void Delete(employees empleado)
        {
            dc.employees.DeleteOnSubmit(empleado);
            dc.SubmitChanges();
        }

        public void Update(employees empleado)
        {
            dc.SubmitChanges();
        }
    }
}