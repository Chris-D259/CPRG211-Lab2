using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_2
{
    public class Salaried:Employee
    {
        protected double salary {  get; set; }

        public Salaried()
        {

        }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary):base(id, name, address, phone, sin,  dob,  dept)
        {
            this.salary = salary;
        }

        //Get Pay Method - Returns Salary
        public double GetPay()
        {
            return salary;
        }
        //ToString Method
        public override string ToString()
        {
            return $"Employee Details \n" +
                $"ID: {this.id} \n" +
                $"Name: {this.name}\n" +
                $"Address: {this.address}\n" +
                $"SIN: {this.sin} \n" +
                $"DOB: {this.dob} \n" +
                $"DEPT: {this.dept} \n"+
                $"PAY: {GetPay():2F}";
        }
    }
}
