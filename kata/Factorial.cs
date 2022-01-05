namespace kata
{
    internal class Factorial
    {
        public int Submission(int n)
        {
            //filter out bad input values


            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(n == 0)
            {
                return 1;
            }
            int factorialValue = 1;

            while (n > 0)
            {
                factorialValue *= n;
                n--;
            }

            Console.WriteLine(factorialValue);

            return factorialValue;
        }
    }
}
