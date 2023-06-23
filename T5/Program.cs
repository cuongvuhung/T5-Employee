using System.Xml.Linq;

namespace T5;

class Program
{
    static void Main(string[] args)
    {
        int selected;
        EmployeeManager manager = new EmployeeManager();
        do
        {
            Console.WriteLine("***EMPLOYEE MANAGER***");
            Console.WriteLine("1. Search Employee by Name or EmpNo");
            Console.WriteLine("2. Add New Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Show all Employee");
            Console.WriteLine("6. Exit");
            Console.Write("   Select (1-6): ");
            selected = Convert.ToInt16(Console.ReadLine());
            

            switch (selected)
            {
                case 1:
                    manager.Find();
                    break;
                case 2:
                    manager.AddNew();
                    break;
                case 3:
                    manager.Update();
                    break;
                case 4:
                    manager.Delete();
                    break;
                case 5:
                    manager.Show();
                    break;
                case 6:
                    Console.WriteLine("-------- END ---------");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        } while (selected != 6);
        Console.ReadLine();
    }
}

