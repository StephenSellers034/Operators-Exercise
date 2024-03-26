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
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            AreaOfCircle(20);
            Console.WriteLine($"The area of a circle with radius of 20 is {AreaOfCircle(20)}");
           
            
        }

        public static double AreaOfCircle(double radius)
        {
           double area = Math.PI * radius * radius;
            return area;
        }
    }
}
