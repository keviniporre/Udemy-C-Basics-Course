// See https://aka.ms/new-console-template for more information

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare values
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            string firstName = "Kevin";
            bool isWorking = false;

            //Shortcut for Console.WriteLine: write cw and press Tab
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            //Run the app: Ctrl + F5
        }
    }
}