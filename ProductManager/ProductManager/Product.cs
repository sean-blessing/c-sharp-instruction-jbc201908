using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager {
    class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product() {

        }

        public Product(string c, string d, double p) {
            Code = c;
            Description = d;
            Price = p;
        }

        public override string ToString() {
            return $"Product: code={Code}, " +
                    $"desc={Description}, price={Price.ToString("C2")}";
        }

    }
}
