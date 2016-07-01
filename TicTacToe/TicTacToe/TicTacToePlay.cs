using System;

namespace TicTacToe
{
    public class TicTacToePlay
    {
        public static void Play()
        {
            TicTacToeGame ticaTacToeGame = new TicTacToeGame();
            ticaTacToeGame.BoardDisplay();
            while (true)
            {
                int row, col;
                GetIndexes(out row, out col);
                var isLegal = ticaTacToeGame.SetMove(row, col);
                if (!isLegal) continue;
                if (!ticaTacToeGame.IsGameOver)
                {
                    ticaTacToeGame.BoardDisplay();
                    continue;
                }
                Console.WriteLine("Game Over!");
                ticaTacToeGame.BoardDisplay();
                break;
            }
        }
        private static void GetIndexes(out int row, out int col)
        {
            GET:
            string input;
            GetLegalLine(out input);
            var tmpArr=CheckTwoIndexes(input);
            if(tmpArr==null)goto GET;
            bool flag1, flag2;
            TryParse(tmpArr,out flag1, out flag2, out row, out col);
            while (!flag1 || !flag2)
            {
                GetLegalLine(out input);
                tmpArr = CheckTwoIndexes(input);
                if (tmpArr == null) continue;
                TryParse(tmpArr,out flag1,out flag2,out row,out col );
            }
        }
        private static string[] CheckTwoIndexes(string input)
        {
            var tmpArr = input.Split(new[] { ' ', '\t' }, StringSplitOptions.None);
            return tmpArr.Length != 2 ? null : tmpArr;
        }
        private static void TryParse(string[] tmpArr,out bool flag1, out bool flag2, out int row, out int col)
        {
            flag1 = int.TryParse(tmpArr[0], out row);
            flag2 = int.TryParse(tmpArr[1], out col);
        }
        private static void GetLegalLine(out string input)
        {
            Console.WriteLine("enter couple of indexes between 0-2 (like 0 2)");
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("enter couple of indexes between 0-2 (like 0 2)");
                input = Console.ReadLine();
            }
        }
    }
}