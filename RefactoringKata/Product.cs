using System.Text;

namespace RefactoringKata
{
    public class Product
    {
        public static int SIZE_NOT_APPLICABLE = -1;

        public string Code { get; set; }
        public int Color { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public Product(string code, int color, int size, double price, string currency)
        {
            Code = code;
            Color = color;
            Size = size;
            Price = price;
            Currency = currency;
        }



        public string getColorFor()
        {
            switch (Color)
            {
                case 1:
                    return "blue";
                case 2:
                    return "red";
                case 3:
                    return "yellow";
                default:
                    return "no color";
            }
        }

        public string getSizeFor()
        {
            switch (Size)
            {
                case 1:
                    return "XS";
                case 2:
                    return "S";
                case 3:
                    return "M";
                case 4:
                    return "L";
                case 5:
                    return "XL";
                case 6:
                    return "XXL";
                default:
                    return "Invalid Size";
            }
        }

        private bool IsApplicable()
        {
            return Size != SIZE_NOT_APPLICABLE;
        }

        public override string ToString()
        {
            var sb =new StringBuilder();
            sb.Append("{");
                    sb.Append("\"code\": \"");
                    sb.Append(Code);
                    sb.Append("\", ");
                    sb.Append("\"color\": \"");
                    sb.Append(getColorFor());
                    sb.Append("\", ");

                    if (IsApplicable())
                    {
                        sb.Append("\"size\": \"");
                        sb.Append(getSizeFor());
                        sb.Append("\", ");
                    }

                    sb.Append("\"price\": ");
                    sb.Append(Price);
                    sb.Append(", ");
                    sb.Append("\"currency\": \"");
                    sb.Append(Currency);
                    sb.Append("\"}");
            return sb.ToString();
        }
    }
}
