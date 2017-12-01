using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
    public class HR
    {
        public void ToSalary(Employee employee)
        {
            var transferSource = typeof(Employee).GetMethod("TransferToEmployee").GetParameters()[0].GetCustomAttributes(false)[0] as TransferSource ;

            switch (transferSource.TransferType)
            {
                case TransferSourceType.Loan:
                    {
                        employee.TransferToEmployee(6000);
                    }
                    break;
                case TransferSourceType.Reimburse:
                    {
                        employee.TransferToEmployee(600);
                    }
                    break;
                case TransferSourceType.Salary:
                    {
                        employee.TransferToEmployee(40000);
                    }
                    break;
            }
        }
    }

    public enum TransferSourceType
    {
        Salary,
        Reimburse,
        Loan
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    public class TransferSource : Attribute
    {
        public TransferSourceType TransferType { get; set; }
    }

    public partial class Employee
    {
        public void TransferToEmployee([TransferSource(TransferType = TransferSourceType.Salary)] int number)
        {
            ///Todo 转入员工银行卡
        }
    }

}