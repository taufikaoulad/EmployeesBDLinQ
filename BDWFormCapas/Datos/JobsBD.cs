using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesBDLinQ.Datos
{
    public class JobsBD
    {
        DBEmployeesDataContext dc = new DBEmployeesDataContext();

        public IQueryable<jobs> Select()
        {
            var data = from job in dc.jobs
                       select job;

            return data;
        }

    }
}
