using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class BoardManager
{
    public static int[,] generateBoard() {
        Debug.Log("Starting board generation");
        int[,] returnBoard = new int[5, 5];
        for (int x = 0; x < 5; x++) {
            int[] newColumn = genColumn(x * 15, x * 15 + 15);
            for (int y = 0; y < 5; y++)
            {
                returnBoard[x, y] = newColumn[y];
            }
        }
        returnBoard[2, 2] = -1;
        Debug.Log(print2D(returnBoard));
        return returnBoard;
    }

    private static int[] genColumn(int rangeMin, int rangeMax)
    {
        int[] returnArray = new int[5];

        HashSet<int> uniqueValues = new HashSet<int>();

        // Generate random numbers until the array is filled
        var random = new System.Random();
        while (uniqueValues.Count < returnArray.Length)
        {
            int randomValue = random.Next(rangeMin, rangeMax + 1);
            uniqueValues.Add(randomValue);
        }

        // Copy unique values to the array
        returnArray = uniqueValues.ToArray();
        return returnArray;
    }

    public static string print2D(int[,] data)
    {
        string output = "";
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                output += data[i, j] + " ";
            }
            output += "\n";
        }
        return output;
    }

}