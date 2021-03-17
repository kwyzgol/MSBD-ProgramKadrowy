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
    public partial class EmpAdd : Form
    {
        private List<string>[] jobData;
        private List<DataClass> depData;
        private List<DataClass> manData;

        public EmpAdd()
        {
            InitializeComponent();
        }

        private void trackBarSalary_Scroll(object sender, EventArgs e)
        {
            labelSalary.Text = trackBarSalary.Value.ToString();
        }

        private void trackBarComm_Scroll(object sender, EventArgs e)
        {
            labelComm.Text = trackBarComm.Value.ToString();
        }

        private void DataLoad()
        {
            string cmdJob = "SELECT job_id, job_title FROM jobs ORDER BY 2";
            string cmdDep = "SELECT department_id, department_name FROM departments ORDER BY 2";
            string cmdMan = "SELECT employee_id, first_name || ' ' || last_name FROM employees ORDER BY 2";

            OracleDataReader reader = Utilities.QueryResult(cmdJob);
            if (reader == null) Program.EmpListAddr.Close();
            else
            {
                jobData = new List<string>[2];
                jobData[0] = new List<string>();
                jobData[1] = new List<string>();
                while(reader.Read())
                {
                    jobData[0].Add(reader.GetString(0));
                    jobData[1].Add(reader.GetString(1));
                    comboBoxJob.Items.Add(reader.GetString(1));
                }
            }
            comboBoxJob.SelectedIndex = 0;

            reader = Utilities.QueryResult(cmdDep);
            if (reader == null) Program.EmpListAddr.Close();
            else
            {
                depData = new List<DataClass>();
                while(reader.Read())
                {
                    DataClass tmp = new DataClass(reader.GetInt32(0), reader.GetString(1));
                    depData.Add(tmp);
                    comboBoxDep.Items.Add(tmp.Str);
                }
            }
            comboBoxDep.SelectedIndex = 0;

            reader = Utilities.QueryResult(cmdMan);
            if (reader == null) Program.EmpListAddr.Close();
            else
            {
                manData = new List<DataClass>();
                while (reader.Read())
                {
                    DataClass tmp = new DataClass(reader.GetInt32(0), reader.GetString(1));
                    manData.Add(tmp);
                    comboBoxManager.Items.Add(tmp.Str);
                }
            }
            comboBoxManager.SelectedIndex = 0;
        }

        private void EmpAdd_Shown(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxLName.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Pole \"Nazwisko\" oraz \"E-mail\" są obowiązkowe.", "Komunikat");
            }
            else
            {
                bool ifFname = false;
                bool ifPhone = false;
                bool ifMan = false;
                bool ifDep = false;

                int id = Utilities.GetId();
                string fname = "", lname = "", email = "", phone = "", jobId = "";
                int salary = -1, manId = -1, depId = -1, comm = -1;

                if (textBoxFName.Text.Length != 0)
                {
                    ifFname = true;
                    fname = textBoxFName.Text;
                }
                if (textBoxPhone.Text.Length != 0)
                {
                    ifPhone = true;
                    phone = textBoxPhone.Text;
                }
                if (comboBoxManager.SelectedIndex != 0)
                {
                    ifMan = true;
                    manId = manData[comboBoxManager.SelectedIndex - 1].Num;
                }
                if(comboBoxDep.SelectedIndex != 0)
                {
                    ifDep = true;
                    depId = depData[comboBoxDep.SelectedIndex - 1].Num;
                }

                lname = textBoxLName.Text;
                email = textBoxEmail.Text;
                jobId = jobData[0][comboBoxJob.SelectedIndex];
                salary = trackBarSalary.Value;
                comm = trackBarComm.Value;

                string cmd = "INSERT INTO employees(employee_id, hire_date, last_name, email, job_id, salary, commission_pct";
                if (ifFname) cmd += ", first_name";
                if (ifPhone) cmd += ", phone_number";
                if (ifMan) cmd += ", manager_id";
                if (ifDep) cmd += ", department_id";
                cmd += String.Format(") VALUES({0}, SYSDATE, '{1}', '{2}', '{3}', {4}, {5}/100", id, lname, email, jobId, salary, comm);
                if (ifFname) cmd += String.Format(", '{0}'", fname);
                if (ifPhone) cmd += String.Format(", '{0}'", phone);
                if (ifMan) cmd += String.Format(", {0}", manId);
                if (ifDep) cmd += String.Format(", {0}", depId);
                cmd += ")";

                List<string> cmdList = new List<string>();
                cmdList.Add(cmd);
                if (Utilities.dmlOperation(cmdList))
                {
                    Program.EmpListAddr.listViewEmp.SelectedItems.Clear();
                    Program.EmpListAddr.listViewEmp.Items.Clear();
                    Program.EmpListAddr.EmpLoad();
                    this.Close();
                }
                else Program.EmpListAddr.Close();
            }
        }
    }
}
