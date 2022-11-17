namespace _2CanaTechnical.Questions
{
    internal class QuestionB
    {
        List<double> transactions = new List<double>();
        double totalDiscount = 0;

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


        public double CalculateDiscount(double amt)
        {
            double DISCOUNT_RATE = 0.20;

            return (amt * DISCOUNT_RATE);
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
            Console.WriteLine("Total value of sales: R {0:0.00}", CalculateTotalSales());
            Console.WriteLine("Total discount: R {0:0.00}", totalDiscount);
        }

        public bool Check1(double amt)
        {
            if (amt > 20)
            {
                return true;
            }
            return false;
        }


        public bool Check2()
        {
            if (transactions.Count <= 3)
            {
                return true;
            }
            return false;
        }

        public void ApplyNewDiscountRule()
        {
            int discountCounter = 0;

            foreach (double i in transactions)
            {
                if(discountCounter < 3) 
                {
                    
                    if (Check1(i) || Check2())
                    {
                        if (CalculateDiscount(i) > 20)
                        {
                            totalDiscount += 20;
                            discountCounter++;
                        }
                        else if (CalculateDiscount(i) < 20 && CalculateDiscount(i) > 5)
                        {
                            totalDiscount += CalculateDiscount(i);
                            discountCounter++;
                        }else if(CalculateDiscount(i) < 5)
                        {
                            totalDiscount += 5;
                        }
                    }

                    totalDiscount += 0;
                }

            }
        }
    }
}
