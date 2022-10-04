namespace SudokuSolver
{
    internal class Program
    {
        private const int BoardSize = 9;

        static void Main(string[] args)
        {
            var solutions = Solver.ComputeSolutions(InitializeSudoku());
            
            foreach(var sol in solutions)
            {
                Console.WriteLine(Solver.FormatSolution(sol) + Environment.NewLine);
            }
        }

        private static int[][] InitializeSudoku()
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