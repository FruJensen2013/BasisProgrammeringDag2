namespace BasicProgrammingDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Isabella";
            string code = "1234";
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are not old enough to proceed");
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
                return;
            }

            else if (age <= 18)
            { Console.WriteLine("Enter username"); }
            string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
            if (username == name && password == code) 
                {
                    Console.WriteLine("Welcome" + (username));
                    Console.WriteLine("press any key to exit");
                    Console.ReadKey();
                }
                else if (username != name || password != code)
                {
                    Console.WriteLine("incorrect username or password");
                    Console.WriteLine("press any key to exit");
                    Console.ReadKey();
              
            }
            
            }

        }
}
