namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PriceSmallCarpet = 25;
            int PricelargeCarpet = 35;
            double TaxRate = 0.06;
            Console.WriteLine(" please enter Number of small carpets");
            int NumSmall=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" please enter Number of large carpets");
            int NumLarge  = Convert.ToInt32(Console.ReadLine());
            double cost = (NumSmall * PriceSmallCarpet) + (NumLarge * PricelargeCarpet);
            double ResultTex= TaxRate * cost;
            double total = cost + ResultTex;
            Console.WriteLine($"Total estimate: {total}");
            Console.WriteLine("This estimate is valid for 30 days");






        }
    }
}
