namespace SudokuSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = Solver.ComputeSolutions(Initialize15x15Sudoku());
            
            foreach(var sol in solutions)
            {
                Console.WriteLine(Solver.FormatSolution(sol) + Environment.NewLine);
            }

            Console.ReadLine();
        }

        private static int[][] Initialize9x9Sudoku()
            => new int[9][]
            {
                new[] { 0, 0, 5, 3, 0, 0, 0, 0, 0 },
                new[] { 8, 0, 0, 0, 0, 0, 0, 2, 0 },
                new[] { 0, 7, 0, 0, 1, 0, 5, 0, 0 },
                new[] { 4, 0, 0, 0, 0, 5, 3, 0, 0 },
                new[] { 0, 1, 0, 0, 7, 0, 0, 0, 6 },
                new[] { 0, 0, 3, 2, 0, 0, 0, 8, 0 },
                new[] { 0, 6, 0, 5, 0, 0, 0, 0, 9 },
                new[] { 0, 0, 4, 0, 0, 0, 0, 3, 0 },
                new[] { 0, 0, 0, 0, 0, 9, 7, 0, 0 }
            };

        public static int[][] Initialize15x15Sudoku()
            => new int[15][]
            {
                new[] { 11, 0, 0, 0, 0, 8, 7, 5, 0, 4, 0, 3, 1, 0, 0 },
                new[] { 13, 0, 8, 0, 14, 12, 0, 0, 15, 2, 0, 0, 9, 0, 10 },
                new[] { 2, 3, 0, 0, 0, 11, 0, 10, 9, 0, 6, 0, 0, 5, 12 },

                new[] { 5, 8, 9, 0, 0, 0, 0, 6, 0, 7, 2, 15, 14, 0, 0 },
                new[] { 0, 0, 6, 11, 10, 0, 2, 12, 0, 13, 3, 7, 4, 1, 0 },
                new[] { 0, 4, 0, 3, 13, 0, 15, 0, 0, 8, 11, 12, 0, 9, 0 },

                new[] { 0, 7, 5, 2, 0, 4, 3, 0, 1, 15, 13, 0, 10, 0, 6 },
                new[] { 3, 12, 0, 0, 15, 0, 0, 8, 14, 6, 4, 0, 0, 0, 7 },
                new[] { 0, 14, 10, 6, 11, 7, 0, 0, 0, 9, 5, 0, 0, 8, 0 },

                new[] { 0, 5, 1, 0, 3, 10, 0, 0, 11, 12, 8, 2, 0, 0, 0 },
                new[] { 0, 0, 15, 13, 0, 2, 5, 7, 0, 0, 0, 0, 12, 0, 14 },
                new[] { 0, 9, 7, 0, 0, 15, 14, 4, 6, 3, 0, 11, 0, 0, 1 },

                new[] { 9, 6, 0, 0, 0, 0, 4, 0, 3, 11, 12, 0, 13, 0, 15 },
                new[] { 0, 0, 0, 7, 8, 0, 9, 14, 0, 0, 0, 10, 2, 4, 0 },
                new[] { 1, 0, 11, 0, 12, 0, 0, 0, 0, 0, 14, 5, 3, 0, 0 },
            };
    }
}