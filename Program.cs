namespace hazi1016
{
    internal class Program
    {
        static int []tomb = new int[5];
        static void F05()
        {
            for (int i = 0; i < 5; i++)
            {    Console.WriteLine("Kérem a(z) {0}. számot: ", i + 1);
                 tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            F05();
        }
    }
}
