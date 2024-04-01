namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(34,354));
            Console.WriteLine(Add(23.4m, 45.7m));
            Console.WriteLine("Write a number");
           int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this money? say true or false");
            bool isMoney = bool.Parse(Console.ReadLine());
            Console.WriteLine(Add(num1, num2, isMoney));
        }

        public static int Add(int num1, int num2)
        { 
           return  num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
           return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isMoney)
        {   int answer = num1 += num2;
          
            string letter = "";
            if (answer > 1) {  letter = "s"; }
            if (isMoney == true)
            {
              return  $"{answer}dollar{letter}";
            }
            else
            {
               return $"{answer}";
            }
        }

    }
}
