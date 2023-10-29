using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("####\tHarsha Bank\t####");
        System.Console.WriteLine("::\tLogin Page\t::");

        // Vars to store userName and Password
        string userName = null;
        string password = null;

        System.Console.Write("Username:");
        userName = System.Console.ReadLine();

        if (userName != null)
        {
            System.Console.Write("Password:");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                // Menu choice

                System.Console.WriteLine("\n::\tMain Menu\t::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("Enter choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        Console.WriteLine("Main menu");
                        break;
                    case 2:
                        Console.WriteLine("Something else");
                        break;
                    case 3:
                        Console.WriteLine("Somethign else");
                        break;
                    case 4:
                        Console.WriteLine("Something");
                        break;
                    case 5:
                        Console.WriteLine("Soemthing");
                        break;
                    default:
                        Console.WriteLine("Soemthing");
                        break;
                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        System.Console.WriteLine("Thank you! Please come again");
        System.Console.ReadKey();
    }
}