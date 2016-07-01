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
            GetInput(out flag, out guessingNumber);
            while (guessingNumber != secret || !flag)
            {
                if (flag && guessingNumber - secret > 10)
                    Console.WriteLine("too big!");
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