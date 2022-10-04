namespace SudokuSolver.UnitTests
{
    internal class SudokuTestData
    {
        public const string EasySudokuSolution = "2 6 4 8 5 9 3 1 7 9 8 1 7 3 4 6 5 2 7 5 3 6 2 1 8 4 9 1 3 5 2 9 7 4 8 6 8 9 2 5 4 6 7 3 1 4 7 6 3 1 8 9 2 5 3 1 8 9 7 5 2 6 4 6 4 9 1 8 2 5 7 3 5 2 7 4 6 3 1 9 8";
        public const string MediumSudokuSolution = "2 3 8 5 9 7 4 1 6 6 9 4 2 3 1 8 5 7 5 1 7 8 6 4 2 3 9 1 7 3 4 2 9 6 8 5 8 6 2 3 1 5 9 7 4 9 4 5 6 7 8 3 2 1 4 5 9 1 8 2 7 6 3 7 8 6 9 5 3 1 4 2 3 2 1 7 4 6 5 9 8";
        public const string HardSudokuSolution = "1 4 5 3 2 7 6 9 8 8 3 9 6 5 4 1 2 7 6 7 2 9 1 8 5 4 3 4 9 6 1 8 5 3 7 2 2 1 8 4 7 3 9 5 6 7 5 3 2 9 6 4 8 1 3 6 7 5 4 2 8 1 9 9 8 4 7 6 1 2 3 5 5 2 1 8 3 9 7 6 4";

        public static int[][] InitializeEasySudoku()
            => new int[Solver.BoardSize][]
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

        public static int[][] InitializeMediumSudoku()
            => new int[Solver.BoardSize][]
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

        public static int[][] InitializeHardSudoku()
            => new int[Solver.BoardSize][]
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
