using System;
using System.Text;

namespace ObjectCalisthenics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var board_bad = new Board_Bad();
            board_bad.BuildBoard();

            var board_good = new Board_Good();
            board_good.BuildBoard();

            Console.WriteLine("End");
        }
    }

    class Board_Bad
    {
        public String BuildBoard()
        {
            StringBuilder buf = new StringBuilder();

            // 0
            for (int i = 0; i < 10; i++)
            {
                // 1
                for (int j = 0; j < 10; j++)
                {
                    // 2
                    buf.Append($"{i} - {j}");
                }
                buf.Append("\n");
            }

            return buf.ToString();
        }
    }

    class Board_Good
    {
        public String BuildBoard()
        {
            StringBuilder buf = new StringBuilder();

            CollectRows(buf);

            return buf.ToString();
        }

        private void CollectRows(StringBuilder buf)
        {
            for (int i = 0; i < 10; i++)
            {
                CollectRow(buf, i);
            }
        }

        private void CollectRow(StringBuilder buf, int row)
        {
            for (int i = 0; i < 10; i++)
            {
                buf.Append($"{row} - {i}");
            }

            buf.Append("\n");
        }
    }
}
