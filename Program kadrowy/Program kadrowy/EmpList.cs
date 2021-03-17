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
    public partial class EmpList : Form
    {
        private List<DataClass> depList;
        private List<string>[] jobList;

        public EmpList()
        {
            InitializeComponent();

            comboBoxDep.SelectedIndex = 0;
            comboBoxJob.SelectedIndex = 0;
        }

        private void trackBarSalary1_Scroll(object sender, EventArgs e)
        {
            labelSalary1.Text = trackBarSalary1.Value.ToString();
        }

        private void trackBarSalary2_Scroll(object sender, EventArgs e)
        {
            labelSalary2.Text = trackBarSalary2.Value.ToString();
        }

        private void trackBarDate1_Scroll(object sender, EventArgs e)
        {
            labelDate1.Text = trackBarDate1.Value.ToString();
        }

        private void trackBarDate2_Scroll(object sender, EventArgs e)
        {
            labelDate2.Text = trackBarDate2.Value.ToString();
        }

        private void listViewEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEmp.SelectedIndices.Count != 0)
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                buttonProfile.Enabled = true;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
                buttonProfile.Visible = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
                buttonProfile.Enabled = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
                buttonProfile.Visible = false;
            }
        }

        private void DataLoad()
        {
            depList = new List<DataClass>();
            jobList = new List<string>[2];
            jobList[0] = new List<string>();    //id
            jobList[1] = new List<string>();    //title

            OracleDataReader reader = Utilities.QueryResult("SELECT department_id, department_name FROM departments ORDER BY 2");
            if (reader == null) this.Close();
            else
            {
                while(reader.Read())
                {
                    DataClass tmp = new DataClass(reader.GetInt32(0), reader.GetString(1));
                    depList.Add(tmp);
                    comboBoxDep.Items.Add(tmp.Str);
                }
            }

            reader = Utilities.QueryResult("SELECT job_id, job_title FROM jobs ORDER BY 2");
            if (reader == null) this.Close();
            else
            {
                while (reader.Read())
                {
                    jobList[0].Add(reader.GetString(0));
                    string tmp = reader.GetString(1);
                    jobList[1].Add(tmp);
                    comboBoxJob.Items.Add(tmp);
                }
            }
        }

        public void EmpLoad()
        {
            string cmd = "SELECT NVL(e.first_name, '[Nie podano]'), e.last_name, j.job_title, NVL(d.department_name, '[brak]'), TO_CHAR(e.hire_date, 'fm DD-Mon-YYYY'), e.employee_id FROM employees e LEFT OUTER JOIN departments d ON e.department_id = d.department_id JOIN jobs j ON e.job_id = j.job_id WHERE ";
            string optional = "";
            if (comboBoxDep.SelectedIndex != 0)
            {
                optional += String.Format("d.department_id = {0} AND ", depList[comboBoxDep.SelectedIndex - 1].Num);
            }
            if(comboBoxJob.SelectedIndex != 0)
            {
                optional += String.Format("j.job_id = '{0}' AND ", jobList[0][comboBoxJob.SelectedIndex - 1]);
            }
            cmd += optional;
            cmd += String.Format("(e.salary BETWEEN {0} AND {1}) AND ", trackBarSalary1.Value, trackBarSalary2.Value);
            cmd += String.Format("(MONTHS_BETWEEN(SYSDATE, e.hire_date)/12 BETWEEN {0} AND {1}) ORDER BY 4, 1", trackBarDate1.Value, trackBarDate2.Value);

            OracleDataReader reader = Utilities.QueryResult(cmd);
            if (reader == null) this.Close();
            else
            {
                while(reader.Read())
                {
                    var tmp = listViewEmp.Items.Add(reader.GetString(0));
                    tmp.SubItems.Add(reader.GetString(1));
                    tmp.SubItems.Add(reader.GetString(2));
                    tmp.SubItems.Add(reader.GetString(3));
                    tmp.SubItems.Add(reader.GetString(4));
                    tmp.SubItems.Add(reader.GetInt32(5).ToString());
                }
            }

        }

        private void EmpList_Shown(object sender, EventArgs e)
        {
            if (Utilities.DatabaseConnection() == false)
            {
                MessageBox.Show("Podczas łączenia z bazą danych wystąpił błąd.", "Komunikat");
                this.Close();
            }
            DataLoad();
            EmpLoad();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            listViewEmp.SelectedItems.Clear();
            listViewEmp.Items.Clear();
            EmpLoad();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            EmpProfile tmp = new EmpProfile(Int32.Parse(listViewEmp.Items[listViewEmp.SelectedIndices[0]].SubItems[5].Text));
            tmp.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EmpAdd tmp = new EmpAdd();
            tmp.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EmpEdit tmp = new EmpEdit(Int32.Parse(listViewEmp.Items[listViewEmp.SelectedIndices[0]].SubItems[5].Text));
            tmp.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listViewEmp.Items[listViewEmp.SelectedIndices[0]].SubItems[5].Text);
            DialogResult confirm = MessageBox.Show("Czy na pewno chcesz trwale usunąć tego pracownika?", "Komunikat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string cmdDep = String.Format("UPDATE departments SET manager_id = NULL where manager_id = {0}", id);
                string cmdEmp = String.Format("UPDATE employees SET manager_id = NULL where manager_id = {0}", id);
                string cmdJob = String.Format("DELETE FROM job_history WHERE employee_id = {0}", id);

                string cmd = string.Format("DELETE FROM employees WHERE employee_id = {0}", id);

                List<string> cmdList = new List<string>();
                cmdList.Add(cmdDep);
                cmdList.Add(cmdEmp);
                cmdList.Add(cmdJob);
                cmdList.Add(cmd);

                if (Utilities.dmlOperation(cmdList))
                {
                    listViewEmp.SelectedItems.Clear();
                    listViewEmp.Items.Clear();
                    EmpLoad();
                }
                else this.Close();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info tmp = new Info();
            tmp.ShowDialog();
        }
    }
}
