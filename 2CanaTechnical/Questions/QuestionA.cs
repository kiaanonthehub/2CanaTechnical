namespace _2CanaTechnical.Questions
{
    internal class QuestionA
    {
        List<double> transactions = new List<double>();

        public void ReadSalesAmt()
        {
            double amt = 0;

            Console.Write("Enter in amount R: ");
            amt = Convert.ToDouble(Console.ReadLine());
            
            while (amt != 0)
            {
                transactions.Add(amt);
                
                Console.Write("Enter in amount R: ");
                amt = Convert.ToDouble(Console.ReadLine());
            }
        }


        public double CalculateTotalSales()
        {
            double total = 0;

            foreach (double i in transactions)
            {
                total += i;
            }

            return total;
        }


        public double CalculateDiscount(double total)
        {
             double DISCOUNT_RATE = 0.20;

            return (total * DISCOUNT_RATE) ;
        }

        public void Display()
        {
            Console.WriteLine("\n-----------------------Transactions-------------------------");
            foreach (double i in transactions)
            {
                Console.WriteLine("Amount: R{0:0.00}", i);
            }
            Console.WriteLine("\n------------------------Totals------------------------------");    
            Console.WriteLine("Total no. of items: " + transactions.Count);
            Console.WriteLine("Total value of sales: R {0:0.00}" , CalculateTotalSales());
            Console.WriteLine("Total discount: R {0:0.00}", CalculateDiscount(CalculateTotalSales()));
        }
    }
}
