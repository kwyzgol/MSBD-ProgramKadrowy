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
    public partial class EmpEdit : Form
    {
        private List<string>[] jobData;
        private List<DataClass> depData;
        private List<DataClass> manData;
        private int id;

        public EmpEdit(int id)
        {
            InitializeComponent();

            this.id = id;
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
            string cmdMan = String.Format("SELECT employee_id, first_name || ' ' || last_name FROM employees WHERE employee_id != {0} ORDER BY 2", id);

            string cmdData = String.Format("SELECT NVL(first_name, ' '), last_name, email, NVL(phone_number, ' '), job_id, NVL(department_id, -1), salary, NVL(commission_pct, -1), NVL(manager_id, -1) FROM employees WHERE employee_id = {0}", id);

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


            reader = Utilities.QueryResult(cmdData);
            if (reader == null) Program.EmpListAddr.Close();
            else
            {
                if(reader.Read())
                {
                    if (reader.GetString(0).Equals(" ") == false) textBoxFName.Text = reader.GetString(0);
                    textBoxLName.Text = reader.GetString(1);
                    textBoxEmail.Text = reader.GetString(2);
                    if (reader.GetString(3).Equals(" ") == false) textBoxPhone.Text = reader.GetString(3);

                    int jobIndex = 0;
                    foreach(string tmp in jobData[0])
                    {
                        if (tmp.Equals(reader.GetString(4))) break;
                        jobIndex++;
                    }
                    comboBoxJob.SelectedIndex = jobIndex;

                    if (reader.GetInt32(5) != -1)
                    {
                        int depIndex = 0;
                        foreach (DataClass tmp in depData)
                        {
                            if (tmp.Num == reader.GetInt32(5)) break;
                            depIndex++;
                        }
                        comboBoxDep.SelectedIndex = depIndex + 1;
                    }
                    else comboBoxDep.SelectedIndex = 0;

                    trackBarSalary.Value = reader.GetInt32(6);
                    labelSalary.Text = trackBarSalary.Value.ToString();

                    if (reader.GetInt32(7) != -1)
                    {
                        trackBarComm.Value = (int)(reader.GetDouble(7) * 100);
                        labelComm.Text = trackBarComm.Value.ToString();
                    }

                    if (reader.GetInt32(8) != -1)
                    {
                        int manIndex = 0;
                        foreach (DataClass tmp in manData)
                        {
                            if (tmp.Num == reader.GetInt32(8)) break;
                            manIndex++;
                        }
                        comboBoxManager.SelectedIndex = manIndex + 1;
                    }
                    else comboBoxManager.SelectedIndex = 0;
                }
            }
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

                string cmd = String.Format("UPDATE employees SET last_name = '{0}', email = '{1}', job_id = '{2}', salary = {3}, commission_pct = {4}/100", lname, email, jobId, salary, comm);
                if (ifFname) cmd += String.Format(", first_name = '{0}'", fname);
                if (ifPhone) cmd += String.Format(", phone_number = '{0}'", phone);
                if (ifMan) cmd += String.Format(", manager_id = {0}", manId);
                else cmd += ", manager_id = NULL";
                if (ifDep) cmd += String.Format(", department_id = {0}", depId);
                cmd += String.Format(" WHERE employee_id = {0}", id);

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
