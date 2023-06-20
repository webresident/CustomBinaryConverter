    public class NumberConverter
    {
        public string GetBinary(double input)
        {
            char[] integralResult = new char[12];
            char[] fractionalResult = new char[52];

            int integral = (int)input;
            double fractional = Math.Abs(input - (double)integral);

            for(int i = 11; i >= 0; i--)
            {
                integralResult[i] = (char)(48 + (integral & 1));
                integral >>= 1;
            }
            for (int i = 0; i < 52; i++)
            {
                fractionalResult[i] = '0';
            }
            for (int i = 0; i < 52; i++)
            {
                fractional *= 2;

                fractionalResult[i] = (char)(48 + (int)fractional);
                if (fractional > 1)
                    fractional--;
                if (fractional == 1)
                    break;
            }

            return new string(integralResult) + "," + new string(fractionalResult);
        }

    }
    public class Program
    {
        private static void Main()
        {
            NumberConverter converter = new NumberConverter();
            Console.WriteLine(converter.GetBinary(2.1));
	}
     }