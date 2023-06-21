using System;
namespace T5
{
	public class Employee
	{
        private String no;
        private String name;
		private String email;

        public Employee()
        {
        }

        public String GetNo()
        {
            return this.no;
        }

        public String GetName()
        {
            return this.name;
        }

        public Employee(string no, string name, string email)
        {
            this.no = no;
            this.name = name;
            this.email = email;
        }

        public override string? ToString()
        {
            return no + ", " + name + ", " + email;
        }
    }
}

