using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_2
{
    public class PartTime: Employee
    {
        protected double hours {  get; set; }
        protected double rate { get; set; }

        public PartTime() { }
        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double hours, double rate) : base(id, name, address, phone, sin, dob, dept)
        {
            this.rate = rate;
            this.hours = hours;
        }
          
        //GetPay Method Returns Pay
        public double GetPay()
        {
            return hours * rate;
        }
        public override string ToString()
        {
            return $"Employee Details \n" +
                $"ID: {this.id} \n" +
                $"Name: {this.name}\n" +
                $"Address: {this.address}\n" +
                $"SIN: {this.sin} \n" +
                $"DOB: {this.dob} \n" +
                $"DEPT: {this.dept} \n" +
                $"PAY: {GetPay():2F}";
        }
    }

  
}
