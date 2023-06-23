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
				new Employee("E001", "hoangnm", "hoangnm@gmail.com",0),
                new Employee("E002", "namph", "namph@gmail.com",0),
                new Employee("E003", "minhnv", "minhnv@gmail.com",0),
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

        public override void Show()
        {
			PrintList(employees);
        }
        public override void AddNew()
        {
            Console.Write("Enter EmpNo: ");
            String EmpNo = Console.ReadLine();
            Console.Write("Enter EmpName: ");
            String EmpName = Console.ReadLine();
            Console.Write("Enter EmpEmail: ");
            String EmpEmail = Console.ReadLine();
			employees = employees.Concat(new Employee[] { new Employee (EmpNo,EmpName,EmpEmail,0) }).ToArray();
            PrintList(employees);
        }

        public override void Update()
        {
            Console.Write("Enter EmpNo or EmpName for update: ");
            String searchKey = Console.ReadLine();
            foreach (Employee emp in employees)
            {
                if (((emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey)) && emp.GetDeleted().Equals(0)))
                {
                    Console.WriteLine("Found a Employee have EmpNo or Emp Name is:" + searchKey);
                    Console.WriteLine("Ready for update");
                    Console.Write("Enter EmpNo: ");
                    emp.SetNo (Console.ReadLine());
                    Console.Write("Enter EmpName: ");
                    emp.SetName (Console.ReadLine());
                    Console.Write("Enter EmpEmail: ");
                    emp.SetEmail (Console.ReadLine());
                }
            }
            PrintList(employees);
        }

        public override void Delete()
        {
            Console.Write("Enter EmpNo or EmpName for delete: ");
            String searchKey = Console.ReadLine();
            foreach (Employee emp in employees)
            {
                if (emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey))
                {                                  
                    Console.WriteLine("Found a Employee have EmpNo or Emp Name is:" + searchKey);
                    Console.WriteLine("Ready for delete");
                    Console.Write("Yes(Y) or No(any other):");
                    if (Console.ReadLine().ToUpper() == "Y") { emp.SetDeleted(1); }                   
                    else { Console.WriteLine("Nothing happen!"); }
                }
            }
            PrintList(employees);
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
				if ((emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey)) && emp.GetDeleted().Equals(0))
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
            Console.Clear();
            foreach (Employee item in arr)
			{
				if (item != null && item.GetDeleted().Equals(0))
				{
                    Console.WriteLine(item);
                }
			}
            Console.WriteLine("---------------------------------");
        }
	}
}

