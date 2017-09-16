using System;

namespace WordSearchInMatrix
{

    public class Solution
    {
        public bool Exist(char[,] board, string word)
        {
            bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];

            return Search(board, visited, word, 0, 0, 0);
        }

        public bool Search(char[,] board, bool[,] visited, string word, int row, int col, int index)
        {
            //base condition
            if (index == word.Length)
            {
                // reached the end
                return true;
            }

            if (row >= board.GetLength(0)
               || row < 0
               || col >= board.GetLength(1)
               || col < 0
               || board[row, col] != word[index]
               || visited[row, col])
            {
                return false;
            }


            visited[row, col] = true;

            bool exists = Search(board, visited, word, row + 1, col, index + 1)
                            ||
                            Search(board, visited, word, row - 1, col, index + 1)
                            ||
                            Search(board, visited, word, row, col + 1, index + 1)
                            ||
                            Search(board, visited, word, row, col - 1, index + 1);

            visited[row, col] = false;

            return exists;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ["ABCE","SFCS","ADEE"]  ABCCED
            // expected ans true
            string word = "ABCCED";
            char[,] board = new char[3,4];
            board[0,0] = 'A';
            board[0,1] = 'B';
            board[0,2] = 'C';
            board[0,3] = 'E';
            board[1,0] = 'S';
            board[1,1] = 'F';
            board[1,2] = 'C';
            board[1,3] = 'S';
            board[2,0] = 'A';
            board[2,1] = 'D';
            board[2,2] = 'E';
            board[2,3] = 'E';

            Solution s = new Solution();
            Console.WriteLine(s.Exist(board, word));
        }
    }
}
