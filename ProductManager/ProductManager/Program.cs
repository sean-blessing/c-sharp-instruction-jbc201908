using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductManager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!");

            int i1 = GetInt("Enter a whole number: ");
            Console.WriteLine("i1 = " + i1);

            string name = "";
            name = GetString("Enter name: ");

            printThreeNumbers(5, 6, 7);
            printThreeNumbers();
            printThreeNumbers(8,9);
            printThreeNumbers(8, c: 10);

            Product p1 = new Product("java", "Murach's Java Programming", 59.50);
            Console.WriteLine(p1);

            Book b1 = new Book{
                Code = "c#",
                Description = "Murach's C# Programming",
                Price = 57.50,
                Author = "Joel Murach"
            };
            Product p2 = new Product("andr", "Murach's Android Programming", 62.50);
            Product[] products = { p1, p2, b1 };

            foreach (Product pdt in products) {
                Console.WriteLine(pdt);

            }

            ArrayList productList1 = new ArrayList();
            productList1.Add(p1);
            productList1.Add(p2);
            productList1.Add(b1);

            Product p = (Product)productList1[0];

            Console.WriteLine("Use a list...");
            List<Product> productList2 = new List<Product>();
            productList2.Add(p1);
            productList2.Add(p2);
            productList2.Add(b1);

            p = productList2[0];

            Console.WriteLine("Use a Dictionary...");
            Dictionary<string, Product> productDictionary =
                                new Dictionary<string, Product>();
            productDictionary.Add(p1.Code, p1);
            productDictionary.Add(p2.Code, p2);
            productDictionary.Add(b1.Code, b1);

            p = productDictionary["andr"];
            Console.WriteLine("product andr = " + p);

            Console.WriteLine("Bye");
        }

        private static void printThreeNumbers(int a = 1, int b = 2, int c=3) {
            Console.WriteLine(a + ", " + b + ", " + c);
        }

        private static string GetString(string prompt) {
            string name;
            Console.WriteLine(prompt);
            name = Console.ReadLine();
            return name;
        }

        // with exception handling
/*        private static int GetInt(string prompt) {
            int i = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                try {
                    i = Convert.ToInt32(s);
                    success = true;
                }
                catch (Exception) {
                    Console.WriteLine("Error - not a whole #: "+s);
                }
            }

            return i;
        }
    }
*/    // with data validation
    private static int GetInt(string prompt) {
        int i = 0;
        bool success = false;
        while (!success) {
            Console.Write(prompt);
            string s = Console.ReadLine();
            if (int.TryParse(s, out i)) {
                success = true;
            }
            else {
                Console.WriteLine("Error - not a whole #: "+s);
            }
        }

        return i;
    }
}
}
