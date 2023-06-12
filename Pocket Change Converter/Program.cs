using System;

namespace PocketChange
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pocket Change");

            string userInput = Console.ReadLine();
            int userInputInt = Convert.ToInt32(userInput);

            int silverValue = 5;
            int goldValue = 10;

            double numGoldCoins = 0;
            double numSilverCoins = 0;
            double numBronzeCoins = 0;

            if (userInputInt >= 10)
            {
                numGoldCoins = userInputInt / goldValue;
                Math.Floor(numGoldCoins);
            }

            if (numGoldCoins > 0)
            {
                numSilverCoins = Math.Floor(((userInputInt) - numGoldCoins * goldValue) / silverValue);
            }

            if (numSilverCoins > 0)
            {
                numBronzeCoins = userInputInt % silverValue;
            }

            Console.WriteLine($"You have {numGoldCoins} gold coins");
            Console.WriteLine($"You have {numSilverCoins} silver coins");
            Console.WriteLine($"You have {numBronzeCoins} bronze coins");
        }

    }
}
