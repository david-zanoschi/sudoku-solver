using SudokuSolver;
using SudokuSolver.UnitTests;

namespace SudokuSolve.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [TestCaseSource(nameof(TestCasesDataSource))]
        public void Return_Correct_Result(int[][] sudoku, string correctSolution)
        {
            var solutions = Solver.ComputeSolutions(sudoku);

            Assert.That(solutions.Count, Is.EqualTo(1));
            Assert.That(solutions[0], Is.EqualTo(correctSolution));
        }

        private static IEnumerable<TestCaseData> TestCasesDataSource
        {
            get
            {
                yield return new TestCaseData(SudokuTestData.InitializeEasySudoku(), SudokuTestData.EasySudokuSolution);
                yield return new TestCaseData(SudokuTestData.InitializeMediumSudoku(), SudokuTestData.MediumSudokuSolution);
                yield return new TestCaseData(SudokuTestData.InitializeHardSudoku(), SudokuTestData.HardSudokuSolution);
            }
        }


    }
}