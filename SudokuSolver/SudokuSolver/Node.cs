namespace SudokuSolver
{
    public class Node<T> where T : notnull
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
