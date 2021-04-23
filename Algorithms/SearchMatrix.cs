namespace Algorithms
{
    public class SearchMatrix
    {
        public bool Search(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }

            var rows = matrix.Length;
            var cols = matrix[0].Length;
            var left = 0;
            var right = rows * cols - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var row = mid / cols;
                var col = mid % cols;
                if (matrix[row][col] == target) return true;
                else if (matrix[row][col] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
    }
}
