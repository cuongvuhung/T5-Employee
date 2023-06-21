using System;
namespace T5
{
	public class EmployeeManager : BaseManager
	{
		public static int MAX = 10;
		private Employee[] employees;

		public EmployeeManager() : base()
		{
			//this.employees = new Employee[MAX];
			this.employees = new Employee[]{
				new Employee("E001", "hoangnm", "hoangnm@gmail.com"),
                new Employee("E002", "namph", "namph@gmail.com"),
                new Employee("E003", "minhnv", "minhnv@gmail.com"),
            };
        }

        public EmployeeManager(String name, Employee[] employees) : base(name)
        {
			//SetName(name);
			this.employees = employees;
        }

        //      public void ViewAll()
        //{
        //	Console.WriteLine("ViewAll");
        //	Console.WriteLine(BaseManager.VERSION);

        //	base.AddNew();
        //}

        public override void AddNew()
        {
            base.AddNew();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Delete()
        {
            base.Delete();
        }

        public override void Find()
		{
			Console.Write("Enter EmpNo or Name: ");
			String searchKey = Console.ReadLine();

			// search
			Employee[] result = new Employee[MAX];
			int count = 0;
			foreach (Employee emp in employees)
			{
				if (emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey))
				{
					result[count++] = emp;
					//count++;
				}
			}

			// print
			if (count > 0)
			{
                PrintList(result);
            } else
			{
				Console.WriteLine("Not Found!");
			}
			
		}

		private void PrintList(Employee[] arr)
		{
			foreach (Employee item in arr)
			{
				if (item != null)
				{
                    Console.WriteLine(item);
                }
			}
		}
	}
}

