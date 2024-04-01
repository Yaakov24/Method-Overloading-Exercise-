namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(34,354);
            Add(23.4m, 45.7m);
            Console.WriteLine("Write a number");
           var num = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this money? say true or false");
            var num2 = bool.Parse(Console.ReadLine());
            Add(num, num1, num2);
        }

        public static void Add(int num1, int num2)
        { 
             Console.WriteLine(num1 + num2);
        }
        public static void Add(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(int num1, int num2, bool num3)
        {   var answer = num1 += num2;
            var letter = "";
            if (answer > 1) {  letter = "s"; }
            if (num3 == true)
            {
                Console.WriteLine($"{answer}dollar{letter}");
            }
            else
            {
                Console.WriteLine(answer);
            }
        }

    }
}
