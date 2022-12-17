using MatrixLibrary;

const int columnsCount = 8;
const int rowsCount = 4;

var matrix = Matrix.GenerateMatrix(columnsCount, rowsCount);

for (var columnIndex = 0; columnIndex < columnsCount; columnIndex++)
{
    for (var rowIndex = 0; rowIndex < rowsCount; rowIndex++)
    {
        Console.Write($"{matrix[columnIndex, rowIndex]:F2} ");
    }

    Console.WriteLine();
}

Console.WriteLine();


var vector = Matrix.CalculateVector(matrix);

for (var index = 0; index < columnsCount; index++)
{
    Console.Write($"{vector[index]:F2} ");
}
Console.WriteLine('\n');

var functionResult = Matrix.CalculateFunction(matrix);
Console.WriteLine($"G = {functionResult}"); 