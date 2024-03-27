namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} % {b} is {remainder}");
            Console.WriteLine("What is the radius of your circle?");

            string userinput = Console.ReadLine();
            double r = double.Parse(userinput);
            AreaOfCircle(r);
            Console.WriteLine($"The area of a circle with radius of 20 is {AreaOfCircle(r)}");

        }

        public static double AreaOfCircle(double radius)
        {
           
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
             
        }
        
    }
}
