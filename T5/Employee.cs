using System;
namespace T5
{
    public class Employee
    {
        private String no;
        private String name;
        private String email;
        int deleted;
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
        public int GetDeleted()
        { 
            return deleted;
        }

        public void SetName(String name) 
        { 
            this.name = name;
        }
        public void SetNo(String no)
        {
            this.no = no;
        }
        public void SetEmail(String email)
        {
            this.email = email;
        }
        public void SetDeleted(int deleted)
        { 
            this.deleted = deleted; 
        }

        public Employee(string no, string name, string email,int deleted)
        {
            this.no = no;
            this.name = name;
            this.email = email;
            this.deleted = 0;
        }

        public override string? ToString()
        {
            return no + ", " + name + ", " + email;// + ", " + deleted ;
        }
    }
}

