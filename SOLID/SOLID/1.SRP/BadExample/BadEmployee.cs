using SOLID._1.SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1.SRP.BadExample
{
    public class BadEmployee
    {
        void CreateEmployee(Employee employee) //One method cant have multiple responsibility
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                #region Process 1: Demonstration of saving Employee's information to the db.
                stringBuilder.Append(employee.Id.ToString());
                stringBuilder.Append(employee.FirstName);
                stringBuilder.Append(employee.LastName);
                stringBuilder.Append(employee.HireDate);
                File.WriteAllText(@"C:\EmployeeData.txt", stringBuilder.ToString());
                #endregion
                #region Process 2: Logging saving process
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Kayıt Tarihi: ");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.Append(employee.Id);
                File.WriteAllText(@"C:\RegisterLog.txt", stringBuilder.ToString());
                #endregion
            }
            catch (Exception ex)
            {

                #region Process 3: Exception Log Process
                stringBuilder = new StringBuilder();
                stringBuilder.Append(ex.Message);
                stringBuilder.Append(DateTime.Now.ToString());
                File.WriteAllText(@"C:\ExceptionLog.txt", stringBuilder.ToString());
                #endregion
            }
        }
    }
}
