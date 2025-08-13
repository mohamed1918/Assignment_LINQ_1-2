namespace Assignment_LINQ_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dataa
            var products = new[]
            {
            new { ProductName = "Apple", Category = "Fruits", UnitPrice = 5.00m, UnitsInStock = 10 },
            new { ProductName = "Banana", Category = "Fruits", UnitPrice = 2.00m, UnitsInStock = 0 },
            new { ProductName = "Laptop", Category = "Electronics", UnitPrice = 1500m, UnitsInStock = 5 },
            new { ProductName = "Chair", Category = "Furniture", UnitPrice = 75m, UnitsInStock = 0 }
            };

            var customers = new[]
            {
            new { CustomerName = "moahmmed hossam", Region = "du", Orders = new[]{ new { OrderID=1, Quantity=3 } } },
            new { CustomerName = "mohanad hossam", Region = "du", Orders = new[]{ new { OrderID=2, Quantity=5 } } }
            };

            string[] dictionaryWords = { "apple", "banana", "chair", "laptop", "their", "height" };
            int[] arrNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            #endregion

            #region Restriction Operators
            //var r1 = products.Where(p => p.UnitsInStock == 0);
            //var r2 = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //var r3 = digitNames.Select((n, i) => new { n, i }).Where(x => x.n.Length < x.i);

            //Console.WriteLine(string.Join(", ", r1.Select(p => p.ProductName)));
            //Console.WriteLine(string.Join(", ", r2.Select(p => p.ProductName)));
            //Console.WriteLine(string.Join(", ", r3.Select(x => x.n)));
            #endregion

            #region Element Operators
            //var e1 = products.First(p => p.UnitsInStock == 0);
            //var e2 = products.FirstOrDefault(p => p.UnitPrice > 1000);
            //var e3 = arrNumbers.Where(n => n > 5).Skip(1).First();

            //Console.WriteLine($"First out of stock: {e1.ProductName}");
            //Console.WriteLine($"First price > 1000: {(e2 != null ? e2.ProductName : "null")}");
            //Console.WriteLine($"Second number > 5: {e3}");
            #endregion

            #region Aggregate Operators
            var a1 = arrNumbers.Count(n => n % 2 != 0);
            var a2 = customers.Select(c => new { c.CustomerName, Orders = c.Orders.Count() });
            var a3 = products.GroupBy(p => p.Category).Select(g => new { g.Key, Count = g.Count() });
            var a4 = arrNumbers.Sum();
            var a5 = dictionaryWords.Sum(w => w.Length);
            var a6 = dictionaryWords.Min(w => w.Length);
            var a7 = dictionaryWords.Max(w => w.Length);
            var a8 = dictionaryWords.Average(w => w.Length);
            
            Console.WriteLine($"Odd count: {a1}");
            foreach (var x in a2) Console.WriteLine($"{x.CustomerName}: {x.Orders}");
            foreach (var x in a3) Console.WriteLine($"{x.Key}: {x.Count}");
            Console.WriteLine($"Sum: {a4}, Total chars: {a5}, Min: {a6}, Max: {a7}, Avg: {a8:F2}");
            #endregion


        }
    }
}
