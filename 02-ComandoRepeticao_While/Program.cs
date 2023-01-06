namespace _02_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10) {
                Console.WriteLine($": {i} x 5 = {i * 5}");
                i++; // i = i+1
            }
            Console.WriteLine("------------------------");

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($": {j} x 6 = {j * 6}");                
            }

            {

               
        }
        }
    }
}