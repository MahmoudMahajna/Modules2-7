using System;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public enum CellType
        {
            X,
            O,
            Empty
        }

        private CellType[,] _arr;
        private int _movesNumber;
        public bool IsGameOver { get; set; }
        public TicTacToeGame()
        {
            InitializeArray();
        }
        private void InitializeArray()
        {
            _arr = new CellType[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _arr[i, j] = CellType.Empty;
                }
            }
        }
        public void BoardDisplay()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_arr[i, j] == CellType.Empty ? $"{'*',10}" : $"{_arr[i, j],10}");
                }
                Console.WriteLine();
            }
        }
        public bool SetMove(int row, int col)
        {
            var flag=IsLegalMove(row, col);
            if (!flag) return false;
            _arr[row, col] = _movesNumber%2==0?CellType.X:CellType.O;
            _movesNumber++;
           if( CheckGameOver()) IsGameOver=true;
           return true;
        }
        private bool CheckGameOver()
        {
            return CheckWin() || CheckDraw();
        }
        private bool CheckDraw()
        {
            return !CheckWin() && _movesNumber == 9;
        }
        private bool CheckWin()
        {
            if (_arr[0, 0] == _arr[0, 1] && _arr[0, 2] == _arr[0, 1] && _arr[0, 0] != CellType.Empty) return true;
            if (_arr[1, 0] == _arr[1, 1] && _arr[1, 2] == _arr[1, 1] && _arr[1, 0] != CellType.Empty) return true;
            if (_arr[2, 0] == _arr[2, 1] && _arr[2, 2] == _arr[2, 1] && _arr[2, 0] != CellType.Empty) return true;
            if (_arr[0, 0] == _arr[1, 0] && _arr[2, 0] == _arr[1, 0] && _arr[0, 0] != CellType.Empty) return true;
            if (_arr[0, 1] == _arr[1, 1] && _arr[2, 1] == _arr[1, 1] && _arr[0, 1] != CellType.Empty) return true;
            if (_arr[0, 2] == _arr[1, 2] && _arr[2, 2] == _arr[1, 2] && _arr[0, 2] != CellType.Empty) return true;
            if (_arr[0, 0] == _arr[1, 1] && _arr[2, 2] == _arr[1, 1] && _arr[0, 0] != CellType.Empty) return true;
            if (_arr[0, 2] == _arr[1, 1] && _arr[2, 0] == _arr[1, 1] && _arr[0, 2] != CellType.Empty) return true;
            return false;
        }
        private bool IsLegalMove(int row, int col)
        {
            return row >= 0 && row <= 2 && col >= 0 && col <= 2 && _arr[row,col] == CellType.Empty;
        }
    }
    
}