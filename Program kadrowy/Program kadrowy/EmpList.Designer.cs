namespace Program_kadrowy
{
    partial class EmpList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxJob = new System.Windows.Forms.GroupBox();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.groupBoxDep = new System.Windows.Forms.GroupBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.trackBarSalary1 = new System.Windows.Forms.TrackBar();
            this.labelSalary2 = new System.Windows.Forms.Label();
            this.trackBarSalary2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSalary1 = new System.Windows.Forms.Label();
            this.labelFilterTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarDate1 = new System.Windows.Forms.TrackBar();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.trackBarDate2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.listViewEmp = new System.Windows.Forms.ListView();
            this.FirstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxJob.SuspendLayout();
            this.groupBoxDep.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalary2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDate2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInfo);
            this.panel1.Controls.Add(this.groupBoxJob);
            this.panel1.Controls.Add(this.groupBoxDep);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.groupBoxSalary);
            this.panel1.Controls.Add(this.labelFilterTitle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 558);
            this.panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfo.Location = new System.Drawing.Point(12, 523);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "i";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxJob
            // 
            this.groupBoxJob.Controls.Add(this.comboBoxJob);
            this.groupBoxJob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxJob.Location = new System.Drawing.Point(3, 109);
            this.groupBoxJob.Name = "groupBoxJob";
            this.groupBoxJob.Size = new System.Drawing.Size(151, 66);
            this.groupBoxJob.TabIndex = 9;
            this.groupBoxJob.TabStop = false;
            this.groupBoxJob.Text = "Zawód";
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Wszystkie"});
            this.comboBoxJob.Location = new System.Drawing.Point(6, 27);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(139, 27);
            this.comboBoxJob.TabIndex = 5;
            // 
            // groupBoxDep
            // 
            this.groupBoxDep.Controls.Add(this.comboBoxDep);
            this.groupBoxDep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDep.Location = new System.Drawing.Point(3, 37);
            this.groupBoxDep.Name = "groupBoxDep";
            this.groupBoxDep.Size = new System.Drawing.Size(151, 66);
            this.groupBoxDep.TabIndex = 8;
            this.groupBoxDep.TabStop = false;
            this.groupBoxDep.Text = "Dział";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Items.AddRange(new object[] {
            "Wszystkie"});
            this.comboBoxDep.Location = new System.Drawing.Point(6, 27);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(139, 27);
            this.comboBoxDep.TabIndex = 5;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilter.Location = new System.Drawing.Point(63, 523);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(91, 30);
            this.buttonFilter.TabIndex = 7;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.Controls.Add(this.trackBarSalary1);
            this.groupBoxSalary.Controls.Add(this.labelSalary2);
            this.groupBoxSalary.Controls.Add(this.trackBarSalary2);
            this.groupBoxSalary.Controls.Add(this.label1);
            this.groupBoxSalary.Controls.Add(this.label2);
            this.groupBoxSalary.Controls.Add(this.labelSalary1);
            this.groupBoxSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSalary.Location = new System.Drawing.Point(3, 181);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Size = new System.Drawing.Size(151, 165);
            this.groupBoxSalary.TabIndex = 6;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = "Pensja";
            // 
            // trackBarSalary1
            // 
            this.trackBarSalary1.LargeChange = 10000;
            this.trackBarSalary1.Location = new System.Drawing.Point(6, 45);
            this.trackBarSalary1.Maximum = 30000;
            this.trackBarSalary1.Name = "trackBarSalary1";
            this.trackBarSalary1.Size = new System.Drawing.Size(140, 45);
            this.trackBarSalary1.SmallChange = 1000;
            this.trackBarSalary1.TabIndex = 1;
            this.trackBarSalary1.TickFrequency = 1000;
            this.trackBarSalary1.Scroll += new System.EventHandler(this.trackBarSalary1_Scroll);
            // 
            // labelSalary2
            // 
            this.labelSalary2.AutoSize = true;
            this.labelSalary2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSalary2.Location = new System.Drawing.Point(45, 93);
            this.labelSalary2.Name = "labelSalary2";
            this.labelSalary2.Size = new System.Drawing.Size(54, 19);
            this.labelSalary2.TabIndex = 4;
            this.labelSalary2.Text = "30000";
            // 
            // trackBarSalary2
            // 
            this.trackBarSalary2.LargeChange = 10000;
            this.trackBarSalary2.Location = new System.Drawing.Point(6, 115);
            this.trackBarSalary2.Maximum = 30000;
            this.trackBarSalary2.Name = "trackBarSalary2";
            this.trackBarSalary2.Size = new System.Drawing.Size(140, 45);
            this.trackBarSalary2.SmallChange = 1000;
            this.trackBarSalary2.TabIndex = 3;
            this.trackBarSalary2.TickFrequency = 1000;
            this.trackBarSalary2.Value = 30000;
            this.trackBarSalary2.Scroll += new System.EventHandler(this.trackBarSalary2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do";
            // 
            // labelSalary1
            // 
            this.labelSalary1.AutoSize = true;
            this.labelSalary1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSalary1.Location = new System.Drawing.Point(45, 23);
            this.labelSalary1.Name = "labelSalary1";
            this.labelSalary1.Size = new System.Drawing.Size(18, 19);
            this.labelSalary1.TabIndex = 3;
            this.labelSalary1.Text = "0";
            // 
            // labelFilterTitle
            // 
            this.labelFilterTitle.AutoSize = true;
            this.labelFilterTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilterTitle.Location = new System.Drawing.Point(12, 9);
            this.labelFilterTitle.Name = "labelFilterTitle";
            this.labelFilterTitle.Size = new System.Drawing.Size(120, 25);
            this.labelFilterTitle.TabIndex = 0;
            this.labelFilterTitle.Text = "Filtrowanie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBarDate1);
            this.groupBox1.Controls.Add(this.labelDate2);
            this.groupBox1.Controls.Add(this.trackBarDate2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelDate1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staż pracy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(60, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "lat";
            // 
            // trackBarDate1
            // 
            this.trackBarDate1.Location = new System.Drawing.Point(6, 45);
            this.trackBarDate1.Maximum = 60;
            this.trackBarDate1.Name = "trackBarDate1";
            this.trackBarDate1.Size = new System.Drawing.Size(140, 45);
            this.trackBarDate1.TabIndex = 1;
            this.trackBarDate1.Scroll += new System.EventHandler(this.trackBarDate1_Scroll);
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate2.Location = new System.Drawing.Point(36, 93);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(27, 19);
            this.labelDate2.TabIndex = 4;
            this.labelDate2.Text = "60";
            // 
            // trackBarDate2
            // 
            this.trackBarDate2.Location = new System.Drawing.Point(6, 115);
            this.trackBarDate2.Maximum = 60;
            this.trackBarDate2.Name = "trackBarDate2";
            this.trackBarDate2.Size = new System.Drawing.Size(140, 45);
            this.trackBarDate2.TabIndex = 3;
            this.trackBarDate2.Value = 60;
            this.trackBarDate2.Scroll += new System.EventHandler(this.trackBarDate2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(60, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "lat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Do";
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate1.Location = new System.Drawing.Point(36, 23);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(18, 19);
            this.labelDate1.TabIndex = 3;
            this.labelDate1.Text = "0";
            // 
            // listViewEmp
            // 
            this.listViewEmp.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewEmp.BackColor = System.Drawing.Color.Silver;
            this.listViewEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.JobColumn,
            this.DepColumn,
            this.DataColumn});
            this.listViewEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewEmp.ForeColor = System.Drawing.Color.Black;
            this.listViewEmp.FullRowSelect = true;
            this.listViewEmp.GridLines = true;
            this.listViewEmp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEmp.HideSelection = false;
            this.listViewEmp.Location = new System.Drawing.Point(166, 9);
            this.listViewEmp.MultiSelect = false;
            this.listViewEmp.Name = "listViewEmp";
            this.listViewEmp.ShowItemToolTips = true;
            this.listViewEmp.Size = new System.Drawing.Size(622, 491);
            this.listViewEmp.TabIndex = 13;
            this.listViewEmp.UseCompatibleStateImageBehavior = false;
            this.listViewEmp.View = System.Windows.Forms.View.Details;
            this.listViewEmp.SelectedIndexChanged += new System.EventHandler(this.listViewEmp_SelectedIndexChanged);
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "Imie";
            this.FirstNameColumn.Width = 111;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "Nazwisko";
            this.LastNameColumn.Width = 111;
            // 
            // JobColumn
            // 
            this.JobColumn.Text = "Zawód";
            this.JobColumn.Width = 111;
            // 
            // DepColumn
            // 
            this.DepColumn.Text = "Dział";
            this.DepColumn.Width = 111;
            // 
            // DataColumn
            // 
            this.DataColumn.Text = "Data zatrudnienia";
            this.DataColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DataColumn.Width = 157;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(166, 512);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 34);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(322, 512);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 34);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edycja";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(478, 512);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 34);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.White;
            this.buttonProfile.Enabled = false;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(634, 512);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(150, 34);
            this.buttonProfile.TabIndex = 17;
            this.buttonProfile.Text = "Profil";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Visible = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // EmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewEmp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmpList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista pracowników";
            this.Shown += new System.EventHandler(this.EmpList_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxJob.ResumeLayout(false);
            this.groupBoxDep.ResumeLayout(false);
            this.groupBoxSalary.ResumeLayout(false);
            this.groupBoxSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalary2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDate2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFilterTitle;
        private System.Windows.Forms.TrackBar trackBarDate1;
        private System.Windows.Forms.TrackBar trackBarDate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxJob;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.GroupBox groupBoxDep;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.TrackBar trackBarSalary1;
        private System.Windows.Forms.Label labelSalary2;
        private System.Windows.Forms.TrackBar trackBarSalary2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSalary1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.ColumnHeader FirstNameColumn;
        private System.Windows.Forms.ColumnHeader LastNameColumn;
        private System.Windows.Forms.ColumnHeader JobColumn;
        private System.Windows.Forms.ColumnHeader DepColumn;
        private System.Windows.Forms.ColumnHeader DataColumn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonProfile;
        public System.Windows.Forms.ListView listViewEmp;
        private System.Windows.Forms.Button buttonInfo;
    }
}