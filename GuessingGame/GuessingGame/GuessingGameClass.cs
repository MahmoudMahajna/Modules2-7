using System;

namespace GuessingGame
{
    public class GuessingGameClass
    {
        public void Play()
        {
            int guessingNumber;
            bool flag;
            var times = 1;
            var secret = new Random().Next(1, 101);


            //You could have used do-while loop to eliminate this GetInput
            GetInput(out flag, out guessingNumber);

            //Flag is redundant.
            while (guessingNumber != secret || !flag)
            {
                //flag is redundant
                //What is this calculation for? Why not guessingNumber > secret?
                //10 is too large for an epsilon...So large, that it make the calculation wrong.
                if (flag && guessingNumber - secret > 10)
                    Console.WriteLine("too big!");

                //flag is redundant
                //same as above.
                if (flag && guessingNumber - secret < -10)
                    Console.WriteLine("too small");

                GetInput(out flag, out guessingNumber);
                if (++times != 7) continue;
                Console.WriteLine($"you failed, the right number is {secret}");
                break;
            }
            if (guessingNumber == secret)
                Console.WriteLine($"You guessed the number successfully by {times} times...");
        }

        private  void GetInput(out bool flag, out int guessingNumber)
        {
            Console.WriteLine("Enter you'r guessing number");
            GetAndTryParse(out flag, out guessingNumber);
            while (!flag)
            {
                Console.WriteLine("Enter a number");
                GetAndTryParse(out flag, out guessingNumber);
            }
        }

        private  void GetAndTryParse(out bool flag, out int guessingNumber)
        {
            var input = Console.ReadLine();
            flag = int.TryParse(input, out guessingNumber);
        }
    }
}