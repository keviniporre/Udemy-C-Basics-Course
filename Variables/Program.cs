// See https://aka.ms/new-console-template for more information

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare values
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a';
            var firstName = "Kevin";
            var isWorking = false;
            const float Pi = 3.14f;
            //Shortcut for Console.WriteLine: write cw and press Tab
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            //Run the app: Ctrl + F5

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

        }
    }
}