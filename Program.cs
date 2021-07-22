using System;
using System.Collections.Generic;

namespace WosPuzzlesC
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }

            // Place 10 random integer values between 5-25 into the array
            // Print the min and max values of the array
            // Print the sum of all the values
            public static int[] RandomArray()
        {
            // makes an array with 10 zero indexs
            int[] someArray = new int[10];
            int min = someArray[0];
            int max = someArray[0];
            int sum = 0;
            Random rand = new Random();
          
             // Place 10 random integer values between 5-25 into the array
            for(int i = 0; i < someArray.Length; i++){
            // make a random num every time 
            int randomNum = rand.Next(5,25);
                // make the index the random num
                someArray[i] = randomNum;
                System.Console.WriteLine(someArray[i]);
                // find min max
                if(someArray[i] < min)
                {
                    min = someArray[i];
                }
               else if(someArray[i] > max)
                {
                    max = someArray[i];
                }
                // add to sum
                sum += someArray[i];

            }
            System.Console.WriteLine(sum);

            return someArray;
        }

        public static string TossCoin()
        {
          string tossResult = "";
        //   Have the function print "Tossing a Coin!"
       // System.Console.WriteLine("Tossing Coin!");
        // Randomize a coin toss with a result signaling either side of the coin 
        Random rand = new Random();
        int randTossNum = rand.Next(1,3);
        System.Console.WriteLine("random toss num " + randTossNum);
        if(randTossNum == 1)
        {
            tossResult = "Heads";
            System.Console.WriteLine(tossResult);
        }
        else if(randTossNum == 2)
        {
            tossResult = "Tails";
            System.Console.WriteLine(tossResult);
        }

            return tossResult;
        }

            // put void for now to avoid errs
        public static double TossMultipleCoins(int num)
        {
            // how to get var out of another funtion
            int headWins = 0;
            int tailsWins = 0;

            for(int i = 1; i <= num; i++ )
            {
                TossCoin();
                if(TossCoin() == "Heads")
                {
                    headWins++;
                }
                if(TossCoin() == "Tails")
                {
                    tailsWins++;
                }
            }

            double ratio = headWins / tailsWins;
            return ratio;

        }

        public static List<string> Names()
        {
            // list of people
            List <string> people = new List<string>();
            List <string> results = new List<string>();
            // add people to the string 
            people.Add("Tiffany");
            people.Add("Todd");
            people.Add("Charlie");
            people.Add("Geneva");
            people.Add("Sydney");

            Random rand = new Random();
            // gives the same num
            for(int i = people.Count - 1; i >= 0; i--)
            {
                // shuffle
                System.Console.WriteLine("---------");
                System.Console.WriteLine(people[i]);
                // if the current elements name is greater than 5 letters
                if(people[i].Length > 5)
                    {
                        // put it in the results list
                        results.Add(people[i]);
                    }

            }
            // test case for greater than 5
            for(int i = 0; i < results.Count; i++)
                {
                    System.Console.WriteLine(results[i]);
                }

            return results;


        }





    }
}
