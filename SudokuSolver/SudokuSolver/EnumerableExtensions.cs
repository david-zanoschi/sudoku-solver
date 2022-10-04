namespace SudokuSolver
{
    /// <summary>Enumerable extension methods class.</summary>
    public static class EnumerableExtensions
    {
        /// <summary>Split the input enumerable in batches of size <paramref name="batchSize"/>.</summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="items">The enumerable to be split in batches.</param>
        /// <param name="batchSize">The batch size.</param>
        /// <returns>An enumerable with the batches.</returns>
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> items, int batchSize)
            => items.Select((item, inx) => new { item, inx })
                .GroupBy(x => x.inx / batchSize)
                .Select(g => g.Select(x => x.item));
    }
}
