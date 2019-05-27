using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDtableWinForm
{
    class Employee
    {
        /// <summary>
        /// EMPLOYEE 테이블의 컬럼마다 변수지정 후, 각각의 변수에 프로퍼티 만들어주기
        /// </summary>
        public long Employee_id { get; set; }       // NUMBER(6)
        public string First_name { get; set; }      // VARCHAR2(20)
        public string Last_name { get; set; }       // VARCHAR2(25)
        public string Email { get; set; }           // VARCHAR2(20)
        public string Phone_number { get; set; }    // VARCHAR2(20)
        public DateTime Hire_date { get; set; }     // DATE
        public string Job_id { get; set; }          // VARCHAR2(10)
        public double Salary { get; set; }          // NUMBER(8, 2)
        public double CommissionPCT { get; set; }   // NUMBER(2, 2)
        public long Manager_id { get; set; }        // NUMBER(6)
        public int Department_id { get; set; }      // NUMBER(4)
    }
}
