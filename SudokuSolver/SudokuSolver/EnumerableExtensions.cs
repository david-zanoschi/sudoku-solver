namespace SudokuSolver
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> items, int batchSize)
            => items.Select((item, inx) => new { item, inx })
                .GroupBy(x => x.inx / batchSize)
                .Select(g => g.Select(x => x.item));
    }
}
