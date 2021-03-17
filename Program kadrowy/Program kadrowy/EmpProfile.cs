using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Program_kadrowy
{
    public partial class EmpProfile : Form
    {
        public EmpProfile(int id)
        {
            InitializeComponent();

            string cmd = String.Format("SELECT NVL(e.first_name, '[Nie podano]'), e.last_name, e.email, NVL(TO_CHAR(e.phone_number), '-'), j.job_title, e.salary, NVL(TO_CHAR(e.commission_pct * 100), '[Brak]'), NVL(d.department_name, '[Brak]'), TO_CHAR(e.hire_date, 'fm DD-Mon-YYYY'), NVL(m.first_name || NVL2(m.first_name, ' ', NULL) || m.last_name, '[Brak]') FROM employees e LEFT OUTER JOIN departments d ON e.department_id = d.department_id JOIN jobs j ON e.job_id = j.job_id LEFT OUTER JOIN employees m ON e.manager_id = m.employee_id WHERE e.employee_id = {0} ", id);
            OracleDataReader reader = Utilities.QueryResult(cmd);

            if (reader == null) Program.EmpListAddr.Close();
            else
            {
                if(reader.Read())
                {
                    labelFName.Text = reader.GetString(0);
                    labelLName.Text = reader.GetString(1);
                    labelEmail.Text = reader.GetString(2);
                    labelPhone.Text = reader.GetString(3);
                    labelJob.Text = reader.GetString(4);
                    labelSalary.Text = reader.GetInt32(5).ToString();
                    labelComm.Text = reader.GetString(6);
                    if (reader.GetString(6).Equals("[Brak]") != true) labelComm.Text += "%";
                    labelDep.Text = reader.GetString(7);
                    labelDate.Text = reader.GetString(8);
                    labelManager.Text = reader.GetString(9);
                }
            }
        }
    }
}
