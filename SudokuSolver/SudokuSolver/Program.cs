namespace SudokuSolver
{
    internal class Program
    {
        private const int BoardSize = 9;

        static void Main(string[] args)
        {
            var solutions = Solver.ComputeSolutions(InitializeHardestSudoku());
            
            foreach(var sol in solutions)
            {
                Console.WriteLine(sol);
                Console.WriteLine();
                Console.WriteLine(Solver.FormatSolution(sol));
            }
        }

        private static int[][] InitializeEasySudoku()
            => new int[BoardSize][]
            {
                new[] { 0, 0, 4, 0, 5, 0, 0, 0, 0 },
                new[] { 9, 0, 0, 7, 3, 4, 6, 0, 0 },
                new[] { 0, 0, 3, 0, 2, 1, 0, 4, 9 },
                new[] { 0, 3, 5, 0, 9, 0, 4, 8, 0 },
                new[] { 0, 9, 0, 0, 0, 0, 0, 3, 0 },
                new[] { 0, 7, 6, 0, 1, 0, 9, 2, 0 },
                new[] { 3, 1, 0, 9, 7, 0, 2, 0, 0 },
                new[] { 0, 0, 9, 1, 8, 2, 0, 0, 3 },
                new[] { 0, 0, 0, 0, 6, 0, 1, 0, 0 }
            };

        private static int[][] InitializeHardSudoku()
            => new int[BoardSize][]
            {
                new[] { 2, 0, 0, 5, 0, 7, 4, 0, 6 },
                new[] { 0, 0, 0, 0, 3, 1, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 2, 3, 0 },
                new[] { 0, 0, 0, 0, 2, 0, 0, 0, 0 },
                new[] { 8, 6, 0, 3, 1, 0, 0, 0, 0 },
                new[] { 0, 4, 5, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 9, 0, 0, 0, 7, 0, 0 },
                new[] { 0, 0, 6, 9, 5, 0, 0, 0, 2 },
                new[] { 0, 0, 1, 0, 0, 6, 0, 0, 8 }
            };

        private static int[][] InitializeHardestSudoku()
            => new int[BoardSize][]
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
    }
}