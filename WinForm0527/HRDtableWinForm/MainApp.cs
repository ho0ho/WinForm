using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDtableWinForm
{
    static class MainApp
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// 
        /// DAO 클래스: Data Access Object (다른 언어) 
        /// DAC 클래스: Data Access Class(.NET에서 쓰는 용어) => DB관련정보를 여기에 모아놓기 위해 사용
        /// 
        /// 오라클의 HR.EMPLOYEES 테이블을 갖다 쓰자
        /// => C:\app\bit\product\18.0.0\dbhomeXE\ODP.NET\managed\common\
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
