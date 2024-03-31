using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesBDLinQ.Datos
{
    public class DepartmentsBD
    {
        DBEmployeesDataContext dc = new DBEmployeesDataContext();

        public IQueryable<departments> Select()
        {
            var data = from dep in dc.departments
                       select dep;

            return data;
        }
    }
}
