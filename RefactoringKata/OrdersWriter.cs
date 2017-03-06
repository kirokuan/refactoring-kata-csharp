using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringKata
{
    public class OrdersWriter
    {
        private List<Order> _orders;

        public OrdersWriter(List<Order> orders)
        {
            _orders = orders;
        }

        public string GetContents()
        {
            var sb = new StringBuilder("{\"orders\": [");
            sb.Append(string.Join(", ", _orders));
            return sb.Append("]}").ToString();
        }
    }
}