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
            //var a1 = arrNumbers.Count(n => n % 2 != 0);
            //var a2 = customers.Select(c => new { c.CustomerName, Orders = c.Orders.Count() });
            //var a3 = products.GroupBy(p => p.Category).Select(g => new { g.Key, Count = g.Count() });
            //var a4 = arrNumbers.Sum();
            //var a5 = dictionaryWords.Sum(w => w.Length);
            //var a6 = dictionaryWords.Min(w => w.Length);
            //var a7 = dictionaryWords.Max(w => w.Length);
            //var a8 = dictionaryWords.Average(w => w.Length);

            //Console.WriteLine($"Odd count: {a1}");
            //foreach (var x in a2) Console.WriteLine($"{x.CustomerName}: {x.Orders}");
            //foreach (var x in a3) Console.WriteLine($"{x.Key}: {x.Count}");
            //Console.WriteLine($"Sum: {a4}, Total chars: {a5}, Min: {a6}, Max: {a7}, Avg: {a8:F2}");
            #endregion

            #region Set Operators
            //var s1 = products.Select(p => p.Category).Distinct();
            //var s2 = products.Select(p => p.ProductName[0]).Union(customers.Select(c => c.CustomerName[0]));
            //var s3 = products.Select(p => p.ProductName[0]).Intersect(customers.Select(c => c.CustomerName[0]));
            //var s4 = products.Select(p => p.ProductName[0]).Except(customers.Select(c => c.CustomerName[0]));
            //var s5 = products.Select(p => p.ProductName[^3..]).Concat(customers.Select(c => c.CustomerName[^3..]));

            //Console.WriteLine(string.Join(", ", s1));
            //Console.WriteLine(string.Join(", ", s2));
            //Console.WriteLine(string.Join(", ", s3));
            //Console.WriteLine(string.Join(", ", s4));
            //Console.WriteLine(string.Join(", ", s5));
            #endregion

            #region Partitioning Operators
            //var p1 = customers.Where(c => c.Region == "du").SelectMany(c => c.Orders).Take(3);
            //var p2 = customers.Where(c => c.Region == "du").SelectMany(c => c.Orders).Skip(2);
            //var p3 = arrNumbers.TakeWhile((n, i) => n >= i);
            //var p4 = arrNumbers.SkipWhile(n => n % 3 != 0);
            //var p5 = arrNumbers.SkipWhile((n, i) => n >= i);

            //Console.WriteLine(string.Join(", ", p1.Select(o => o.OrderID)));
            //Console.WriteLine(string.Join(", ", p2.Select(o => o.OrderID)));
            //Console.WriteLine(string.Join(", ", p3));
            //Console.WriteLine(string.Join(", ", p4));
            //Console.WriteLine(string.Join(", ", p5));
            #endregion

            #region Quantifiers
            var q1 = dictionaryWords.Any(w => w.Contains("ei"));
            var q2 = products.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
            var q3 = products.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
            
            Console.WriteLine($"Contains 'ei': {q1}");
            foreach (var g in q2) Console.WriteLine($"Category {g.Key} has out of stock");
            foreach (var g in q3) Console.WriteLine($"Category {g.Key} all in stock");
            #endregion


        }
    }
}
