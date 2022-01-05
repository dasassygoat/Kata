
namespace kata
{
   
    public static class Kata
    {
        static int Main(string[] dice)
        {
            //Greed is Good
            int[] diceVals =  new int[]{ 1, 1, 1, 3, 1 };
            GreedIsGood greedIsGood = new GreedIsGood();
            greedIsGood.Submission(diceVals);


            return 0;
        }
    }
}