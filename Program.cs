using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee("Ewelike Emeka",1,DateTime.Today,".Net developer","IT");
            Employee employeeTwo = new Employee("Ifunanya Onah",2,DateTime.Today,".Net developer","IT");
            Employee employeeThree = new Employee("Uzor Nwachukwu",3,DateTime.Today,"Javascript developer","IT");
            Employee employeeFour = new Employee("Raphael abayomi",4,DateTime.Today,"Accountant","Accounting");
            Employee employeeFive = new Employee("Ewelike Emeka",5,DateTime.Today,"Human resource manager","Hr");

            Employee[] employeesArray = new Employee[]{employeeOne,employeeTwo,employeeThree,employeeFour,employeeFive};

            System.Console.WriteLine("Name\tstaffid\tDate\tJobtitle\tDepartment");
            foreach (Employee em in employeesArray)
            {
                System.Console.WriteLine($"{em.FullName}\t{em.StaffId}\t{em.Date}\t{em._jobTitle}\t{em._department}");
            }
        }   
    }
}
