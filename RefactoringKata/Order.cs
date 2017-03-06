using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RefactoringKata
{
    public class Order 
    {
        private readonly int id;
        public readonly List<Product> _products = new List<Product>();
        private int cur = -1;
        public Order(int id)
        {
            this.id = id;
        }

        //public int GetOrderId()
        //{
        //    return id;
        //}

        public int GetProductsCount()
        {
            return _products.Count;
        }

        public Product GetProduct(int j)
        {
            return _products[j];
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("{");
            sb.Append("\"id\": ");
            sb.Append(id);
            sb.Append(", ");
            sb.Append("\"products\": [");
            sb.Append(string.Join(",", _products));

            sb.Append("]");
            sb.Append("}");
            return sb.ToString();
        }
    }
}