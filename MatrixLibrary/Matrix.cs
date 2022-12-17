namespace MatrixLibrary;

public class Matrix
{
    public static double[,] GenerateMatrix(int columns, int rows)
    {
        var matrix = new double[columns, rows];
        return FillMatrix(matrix);
    }

    private static double[,] FillMatrix(double[,] matrix)
    {
        var columnsCount = matrix.GetUpperBound(0) + 1;
        var rowsCount = matrix.Length / columnsCount;

        for (var columnIndex = 0; columnIndex < columnsCount; columnIndex++)
        {
            for (var rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                matrix[columnIndex, rowIndex] =
                    Math.Pow((double)-1 * (2 + columnIndex + 1) / (3 + rowIndex + 1), columnIndex + 1) -
                    Math.Exp(Math.Cos(rowIndex + 1)) - 3 * Math.PI;
            }
        }

        return matrix;
    }

    public static double[] CalculateVector(double[,] matrix)
    {
        var columnsCount = matrix.GetUpperBound(0) + 1;
        var rowsCount = matrix.Length / columnsCount;

        var result = new double[columnsCount];
        for (var columnIndex = 0; columnIndex < columnsCount; columnIndex++)
        {
            double elementsSum = 0;
            for (var rowIndex = 0; rowIndex < rowsCount; rowIndex++)
                elementsSum += matrix[columnIndex, rowIndex];

            result[columnIndex] = elementsSum / rowsCount;
        }

        return result;
    }

    public static double CalculateFunction(double[,] matrix)
    {
        var columnsCount = matrix.GetUpperBound(0) + 1;
        var rowsCount = matrix.Length / columnsCount;

        double multResult = 1;
        for (var columnIndex = 0; columnIndex < columnsCount; columnIndex++)
        {

            double sumResult = 0;
            for (var rowIndex = 0; rowIndex < rowsCount; rowIndex++)
                sumResult += Math.Abs(matrix[columnIndex, rowIndex] - Math.E);

            multResult *= 3 * sumResult;
        }

        return Math.Log2(Math.Abs(multResult));
    }
}