using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_2
{
    public class Employee
    {


        protected string id {  get; set; }
        protected string name { get; set; }
        protected string address { get; set; }
        protected string phone { get; set; }
        protected long sin { get; set; }
        protected string dob { get; set; }
        protected string dept { get; set; }

        public Employee() { }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept) 
        { 
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }
        //Getters
        public string GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetPhone()
        {
            return phone;
        }

        public long GetSin()
        {
            return sin;
        }

        public string GetDob()
        {
            return dob;
        }

        public string GetDept()
        {
            return dept;
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
                $"DEPT: {this.dept}";
        }
    }
}
