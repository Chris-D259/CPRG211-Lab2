using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_2
{
    public class Wages:Employee
    {
        protected double rate {  get; set; }
        protected double hours { get; set; }

        public Wages()
        {

        }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        { 
            this.hours = hours;
            this.rate = rate;
        }
        //Get Pay Method Returns Pay - factors in OT Calculation
        public double GetPay()
        {
            if (hours > 40)
            {
                return (40 * rate) + ((hours - 40) * rate * 1.5);
            }
            else
            {
                return hours * rate;
            }
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
                $"DEPT: {this.dept} \n" +
                $"PAY: {GetPay():2F}";
        }
    }
    }

