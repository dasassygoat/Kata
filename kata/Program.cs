
namespace kata
{
   
    public static class Kata
    {
        static int Main(string[] dice)
        {
            //LCM
            LeastCommonMultiple_rewrite lcm = new LeastCommonMultiple_rewrite();
            lcm.Lcm(new List<int> { 2, 5 }); //expected to be 10
            lcm.Lcm(new List<int> { 2, 3, 4 }); //expected to be 12
            lcm.Lcm(new List<int> { 9 }); //shoud be 9

            //LCM Original version
            //LeastCommonMultiple lcm = new LeastCommonMultiple();
            //lcm.Lcm(new List<int> { 2, 5 }); //expected to be 10
            //lcm.Lcm(new List<int> { 2, 3, 4 }); //expected to be 12
            //lcm.Lcm(new List<int> { 9 }); //shoud be 9


            //Finding next perfect square
            FindNextPerfectSquare nextSquare = new FindNextPerfectSquare();
            //nextSquare.findNextSquare(121);
            //nextSquare.findNextSquare(625);
            //nextSquare.findNextSquare(114);
            //nextSquare.findNextSquare(155);

            //Factorial
            Factorial factorial = new Factorial();
            //factorial.Submission(5);

            //Greed is Good
            int[] diceVals =  new int[]{ 1, 1, 1, 3, 1 };
            GreedIsGood greedIsGood = new GreedIsGood();
            //greedIsGood.Submission(diceVals);

            
            return 0;
        }
    }
}