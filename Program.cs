namespace thirdDegree
{
    internal class Program
    {
        static int ThirdDegree(int x)
        {
            int result = x * x * x;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа возведёт число в третюю степень.");
            Console.WriteLine("Введите число: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int result = ThirdDegree(number);

            Console.WriteLine("Число " + number + " в третей степени будет равно " + result);
        }
    }
}