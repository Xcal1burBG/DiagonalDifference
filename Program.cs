using System;
using System.Collections.Generic;
using System.Linq;


class Solution
{


    static void Main(string[] args)
    {
        int numberOfSides = int.Parse(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();


        for (int i = 0; i < numberOfSides; i++)
        {
            matrix.Add(Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList());

        }

        int result = diagonalDifference(matrix);
        Console.WriteLine($"Diagonal difference is {result}");

    }

    public static int diagonalDifference(List<List<int>> matrix)
    {
        int leftToRightDiagonal = 0;
        int rightToLeftDiagonal = 0;

        //calculating the sum of the leftToRightDiagonal (sum = arr[0][0] + arr[1][1] and so on.
        for (int i = 0; i < matrix.Count; i++)
        {
            leftToRightDiagonal += matrix[i][i];
        }

        //calculating the sum of the rightToLeftDiagonal (sum = arr[0][2] + arr[1][1] + arr[2][0] and so on.
        for (int i = 0; i < matrix.Count; i++)
        {
            rightToLeftDiagonal += matrix[i][Math.Abs(i + 1 - matrix.Count)];
        }


        return (int)Math.Abs(leftToRightDiagonal - rightToLeftDiagonal);
    }
}

