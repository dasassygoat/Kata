
namespace kata
{
    class ValueCounts
    {
        public int diceValue { get; set; }
        public int diceRoleCount { get; set; }
    }
    public static class Kata
    {
        static int Main(string[] dice)
        {
            dice = new string[5] { "5", "1", "3", "4", "1" };

            int threeOnes = 1000;
            int threeTwos = 200;
            int threeThrees = 300;
            int threeFours = 400;
            int threeFives = 500;
            int threeSixes = 600;
            int one = 100;
            int five = 50;

            int totalValue = 0;

            int oneCount = 0; int twoCount = 0; int threeCount = 0; int fourCount = 0; int fiveCount = 0; int sixCount = 0;



            for (var x = 0; x < 5; x++)
            {
                if (Convert.ToInt32(dice[x]) == 1)
                    oneCount++;
                if (Convert.ToInt32(dice[x]) == 2)
                    twoCount++;
                if (Convert.ToInt32(dice[x]) == 3)
                    threeCount++;
                if (Convert.ToInt32(dice[x]) == 4)
                    fourCount++;
                if (Convert.ToInt32(dice[x]) == 5)
                    fiveCount++;
                if (Convert.ToInt32(dice[x]) == 6)
                    sixCount++;


            }
           
                if (oneCount >= 3)
                {
                    totalValue += threeOnes;
                    oneCount -= 3;
           
                }

                if (oneCount != 0)
                {
                    if (oneCount > 0)
                    {
                        for (var y = oneCount; y > 0; y--)
                        {
                            totalValue += one;
                        }
                    }
             
                }

                if (twoCount >= 3)
                {
                    totalValue += threeTwos;
             
                }

                if (threeCount >= 3)
                {
                    totalValue += threeThrees;
         
                }
                if (fourCount >= 3)
                {
                    totalValue += threeFours;
            
                }

                if (fiveCount >= 3)
                {
                    totalValue += threeFives;
                    fiveCount -= 3;
           

                }

                if (fiveCount != 0)
                {
                    if (fiveCount > 0)
                    {
                        for (var y = fiveCount; y > 0; y--)
                        {
                            totalValue += five;
                            fiveCount--;
                        }
                    }
      
                }

                if (sixCount >= 3)
                {
                    totalValue += threeSixes;
                  
                }
            Console.WriteLine(totalValue);
            return 0;
        }
    }
}