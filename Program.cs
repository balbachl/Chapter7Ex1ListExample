using System;
namespace MembershipList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> members = new List<string> { "Frank Furter", "Cookie Crumb", "Sassy Frass", "Happy Jack" };
            string? name = String.Empty;
            string[] nameArr;
            int choice = menu();
            while (choice != 4)
            {
                if (choice == 1)
                {
                    printList(members);
                }
                else if (choice == 2)
                {
                    nameArr = addList();
                    members.AddRange(nameArr);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the name of the person you want removed from the list: ");
                    name = Console.ReadLine();
                    if (members.Contains(name))
                    {
                        members.Remove(name);
                        Console.WriteLine("The name has been deleted");
                    }
                    else
                        Console.WriteLine("Sorry, that name does not exist, please try again");
                }
                choice = menu();
            }


        }
        static int menu()
        {
            Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
            int selection = int.Parse(Console.ReadLine());
            while(selection < 1 || selection > 4)
            {
                Console.WriteLine("Please enter a valid option");
                selection = int.Parse(Console.ReadLine());
            }
            return selection;
        }
        static void printList(List<string> mem)
        {
            mem.Sort();
            foreach (string s in mem)
                Console.WriteLine(s);
            return;
        }
        static string[] addList()
        {
            Console.Write("How many members do you wish to add? ");
            int number = int.Parse(Console.ReadLine());
            string[] newMembers = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Member name? ");
                newMembers[i] = Console.ReadLine();

            }
            return newMembers;
        }
    }
}