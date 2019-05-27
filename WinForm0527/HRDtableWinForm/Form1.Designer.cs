namespace HRDtableWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_EmployeeID = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.grpBox_SearchContents = new System.Windows.Forms.GroupBox();
            this.txtBox_DepartmentID = new System.Windows.Forms.TextBox();
            this.lbl_DepartmentID = new System.Windows.Forms.Label();
            this.txtBox_ManagerID = new System.Windows.Forms.TextBox();
            this.lbl_ManagerID = new System.Windows.Forms.Label();
            this.txtBox_CommissionPCT = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPCT = new System.Windows.Forms.Label();
            this.txtBox_Salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_JobID = new System.Windows.Forms.TextBox();
            this.lbl_JobID = new System.Windows.Forms.Label();
            this.txtBox_HireDate = new System.Windows.Forms.TextBox();
            this.lbl_HireDate = new System.Windows.Forms.Label();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.lv_listEmployees = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hire_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Job_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commission_PCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManagerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpBox_Search.SuspendLayout();
            this.grpBox_SearchContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.btn_Search);
            this.grpBox_Search.Controls.Add(this.txtBox_EmployeeID);
            this.grpBox_Search.Controls.Add(this.lbl_EmployeeID);
            this.grpBox_Search.Location = new System.Drawing.Point(31, 28);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Size = new System.Drawing.Size(526, 65);
            this.grpBox_Search.TabIndex = 0;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "[ 조회 ]";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(393, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txtBox_EmployeeID
            // 
            this.txtBox_EmployeeID.Location = new System.Drawing.Point(126, 24);
            this.txtBox_EmployeeID.Name = "txtBox_EmployeeID";
            this.txtBox_EmployeeID.Size = new System.Drawing.Size(258, 21);
            this.txtBox_EmployeeID.TabIndex = 1;
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(34, 27);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(85, 12);
            this.lbl_EmployeeID.TabIndex = 0;
            this.lbl_EmployeeID.Text = "Employee ID :";
            // 
            // grpBox_SearchContents
            // 
            this.grpBox_SearchContents.Controls.Add(this.txtBox_DepartmentID);
            this.grpBox_SearchContents.Controls.Add(this.lbl_DepartmentID);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_ManagerID);
            this.grpBox_SearchContents.Controls.Add(this.lbl_ManagerID);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_CommissionPCT);
            this.grpBox_SearchContents.Controls.Add(this.lbl_CommissionPCT);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_Salary);
            this.grpBox_SearchContents.Controls.Add(this.label6);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_JobID);
            this.grpBox_SearchContents.Controls.Add(this.lbl_JobID);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_HireDate);
            this.grpBox_SearchContents.Controls.Add(this.lbl_HireDate);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_PhoneNumber);
            this.grpBox_SearchContents.Controls.Add(this.lbl_PhoneNumber);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_Email);
            this.grpBox_SearchContents.Controls.Add(this.lbl_Email);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_LastName);
            this.grpBox_SearchContents.Controls.Add(this.lbl_LastName);
            this.grpBox_SearchContents.Controls.Add(this.txtBox_FirstName);
            this.grpBox_SearchContents.Controls.Add(this.lbl_FirstName);
            this.grpBox_SearchContents.Location = new System.Drawing.Point(31, 99);
            this.grpBox_SearchContents.Name = "grpBox_SearchContents";
            this.grpBox_SearchContents.Size = new System.Drawing.Size(526, 209);
            this.grpBox_SearchContents.TabIndex = 3;
            this.grpBox_SearchContents.TabStop = false;
            this.grpBox_SearchContents.Text = "[ 조회내용 ]";
            // 
            // txtBox_DepartmentID
            // 
            this.txtBox_DepartmentID.Location = new System.Drawing.Point(127, 162);
            this.txtBox_DepartmentID.Name = "txtBox_DepartmentID";
            this.txtBox_DepartmentID.Size = new System.Drawing.Size(100, 21);
            this.txtBox_DepartmentID.TabIndex = 19;
            // 
            // lbl_DepartmentID
            // 
            this.lbl_DepartmentID.AutoSize = true;
            this.lbl_DepartmentID.Location = new System.Drawing.Point(136, 142);
            this.lbl_DepartmentID.Name = "lbl_DepartmentID";
            this.lbl_DepartmentID.Size = new System.Drawing.Size(84, 12);
            this.lbl_DepartmentID.TabIndex = 18;
            this.lbl_DepartmentID.Text = "Department ID";
            // 
            // txtBox_ManagerID
            // 
            this.txtBox_ManagerID.Location = new System.Drawing.Point(22, 162);
            this.txtBox_ManagerID.Name = "txtBox_ManagerID";
            this.txtBox_ManagerID.Size = new System.Drawing.Size(99, 21);
            this.txtBox_ManagerID.TabIndex = 17;
            // 
            // lbl_ManagerID
            // 
            this.lbl_ManagerID.AutoSize = true;
            this.lbl_ManagerID.Location = new System.Drawing.Point(40, 142);
            this.lbl_ManagerID.Name = "lbl_ManagerID";
            this.lbl_ManagerID.Size = new System.Drawing.Size(70, 12);
            this.lbl_ManagerID.TabIndex = 16;
            this.lbl_ManagerID.Text = "Manager ID";
            // 
            // txtBox_CommissionPCT
            // 
            this.txtBox_CommissionPCT.Location = new System.Drawing.Point(393, 106);
            this.txtBox_CommissionPCT.Name = "txtBox_CommissionPCT";
            this.txtBox_CommissionPCT.Size = new System.Drawing.Size(111, 21);
            this.txtBox_CommissionPCT.TabIndex = 15;
            // 
            // lbl_CommissionPCT
            // 
            this.lbl_CommissionPCT.AutoSize = true;
            this.lbl_CommissionPCT.Location = new System.Drawing.Point(398, 86);
            this.lbl_CommissionPCT.Name = "lbl_CommissionPCT";
            this.lbl_CommissionPCT.Size = new System.Drawing.Size(106, 12);
            this.lbl_CommissionPCT.TabIndex = 14;
            this.lbl_CommissionPCT.Text = "Commission PCT";
            // 
            // txtBox_Salary
            // 
            this.txtBox_Salary.Location = new System.Drawing.Point(232, 106);
            this.txtBox_Salary.Name = "txtBox_Salary";
            this.txtBox_Salary.Size = new System.Drawing.Size(108, 21);
            this.txtBox_Salary.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salary";
            // 
            // txtBox_JobID
            // 
            this.txtBox_JobID.Location = new System.Drawing.Point(127, 106);
            this.txtBox_JobID.Name = "txtBox_JobID";
            this.txtBox_JobID.Size = new System.Drawing.Size(100, 21);
            this.txtBox_JobID.TabIndex = 11;
            // 
            // lbl_JobID
            // 
            this.lbl_JobID.AutoSize = true;
            this.lbl_JobID.Location = new System.Drawing.Point(156, 86);
            this.lbl_JobID.Name = "lbl_JobID";
            this.lbl_JobID.Size = new System.Drawing.Size(40, 12);
            this.lbl_JobID.TabIndex = 10;
            this.lbl_JobID.Text = "Job ID";
            // 
            // txtBox_HireDate
            // 
            this.txtBox_HireDate.Location = new System.Drawing.Point(22, 106);
            this.txtBox_HireDate.Name = "txtBox_HireDate";
            this.txtBox_HireDate.Size = new System.Drawing.Size(99, 21);
            this.txtBox_HireDate.TabIndex = 9;
            // 
            // lbl_HireDate
            // 
            this.lbl_HireDate.AutoSize = true;
            this.lbl_HireDate.Location = new System.Drawing.Point(44, 85);
            this.lbl_HireDate.Name = "lbl_HireDate";
            this.lbl_HireDate.Size = new System.Drawing.Size(56, 12);
            this.lbl_HireDate.TabIndex = 8;
            this.lbl_HireDate.Text = "Hire Date";
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(390, 52);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(114, 21);
            this.txtBox_PhoneNumber.TabIndex = 7;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(401, 30);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(90, 12);
            this.lbl_PhoneNumber.TabIndex = 6;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(232, 52);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(152, 21);
            this.txtBox_Email.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(271, 30);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(43, 12);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "E-mail";
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(127, 52);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(100, 21);
            this.txtBox_LastName.TabIndex = 3;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(145, 30);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(67, 12);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last Name";
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(22, 52);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(99, 21);
            this.txtBox_FirstName.TabIndex = 1;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(43, 30);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(67, 12);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First Name";
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Location = new System.Drawing.Point(53, 340);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(482, 59);
            this.btnAllSearch.TabIndex = 4;
            this.btnAllSearch.Text = "전체 조회";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.BtnAllSearch_Click);
            // 
            // lv_listEmployees
            // 
            this.lv_listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.First_Name,
            this.Last_Name,
            this.Email,
            this.Phone_Number,
            this.Hire_Date,
            this.Job_ID,
            this.Salary,
            this.Commission_PCT,
            this.ManagerID,
            this.DepartmentID});
            this.lv_listEmployees.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lv_listEmployees.Location = new System.Drawing.Point(53, 406);
            this.lv_listEmployees.Name = "lv_listEmployees";
            this.lv_listEmployees.Size = new System.Drawing.Size(482, 239);
            this.lv_listEmployees.TabIndex = 5;
            this.lv_listEmployees.UseCompatibleStateImageBehavior = false;
            this.lv_listEmployees.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "Employee ID";
            this.EmployeeID.Width = 50;
            // 
            // First_Name
            // 
            this.First_Name.Text = "First Name";
            this.First_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.First_Name.Width = 100;
            // 
            // Last_Name
            // 
            this.Last_Name.Text = "Last Name";
            this.Last_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Last_Name.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 100;
            // 
            // Phone_Number
            // 
            this.Phone_Number.Text = "Phone Number";
            this.Phone_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone_Number.Width = 100;
            // 
            // Hire_Date
            // 
            this.Hire_Date.Text = "Hire Date";
            this.Hire_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hire_Date.Width = 100;
            // 
            // Job_ID
            // 
            this.Job_ID.Text = "Job ID";
            this.Job_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Job_ID.Width = 100;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            this.Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Salary.Width = 100;
            // 
            // Commission_PCT
            // 
            this.Commission_PCT.Text = "Commission PCT";
            this.Commission_PCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Commission_PCT.Width = 100;
            // 
            // ManagerID
            // 
            this.ManagerID.Text = "Manager ID";
            this.ManagerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ManagerID.Width = 100;
            // 
            // DepartmentID
            // 
            this.DepartmentID.Text = "Department ID";
            this.DepartmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartmentID.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 669);
            this.Controls.Add(this.lv_listEmployees);
            this.Controls.Add(this.btnAllSearch);
            this.Controls.Add(this.grpBox_SearchContents);
            this.Controls.Add(this.grpBox_Search);
            this.Name = "MainForm";
            this.Text = "직원조회";
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.grpBox_SearchContents.ResumeLayout(false);
            this.grpBox_SearchContents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.TextBox txtBox_EmployeeID;
        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox grpBox_SearchContents;
        private System.Windows.Forms.TextBox txtBox_DepartmentID;
        private System.Windows.Forms.Label lbl_DepartmentID;
        private System.Windows.Forms.TextBox txtBox_ManagerID;
        private System.Windows.Forms.Label lbl_ManagerID;
        private System.Windows.Forms.TextBox txtBox_CommissionPCT;
        private System.Windows.Forms.Label lbl_CommissionPCT;
        private System.Windows.Forms.TextBox txtBox_Salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_JobID;
        private System.Windows.Forms.Label lbl_JobID;
        private System.Windows.Forms.TextBox txtBox_HireDate;
        private System.Windows.Forms.Label lbl_HireDate;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Button btnAllSearch;
        private System.Windows.Forms.ListView lv_listEmployees;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Last_Name;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone_Number;
        private System.Windows.Forms.ColumnHeader Hire_Date;
        private System.Windows.Forms.ColumnHeader Job_ID;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader Commission_PCT;
        private System.Windows.Forms.ColumnHeader ManagerID;
        private System.Windows.Forms.ColumnHeader DepartmentID;
    }
}

