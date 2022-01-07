
namespace kata
{
   
    public static class Kata
    {
        static int Main(string[] dice)
        {
            //Finding next perfect square
            FindNextPerfectSquare nextSquare = new FindNextPerfectSquare();
            nextSquare.findNextSquare(121);
            nextSquare.findNextSquare(625);
            nextSquare.findNextSquare(114);

            //Factorial
            Factorial factorial = new Factorial();
            factorial.Submission(5);

            //Greed is Good
            int[] diceVals =  new int[]{ 1, 1, 1, 3, 1 };
            GreedIsGood greedIsGood = new GreedIsGood();
            greedIsGood.Submission(diceVals);

            
            return 0;
        }
    }
}