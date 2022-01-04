
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
            dice = new string[5] { "1", "2", "1", "4", "5" };

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

            var counts = new ValueCounts[];
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
            };

            for (var x = 0; x < 5; x++)
            {
                if (Convert.ToInt32(dice[x]) == 1)
                    counts.
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
           for(var x =1; x <= 5; x++)
            {
                if(one)
            }
            return 0;
        }
    }
}