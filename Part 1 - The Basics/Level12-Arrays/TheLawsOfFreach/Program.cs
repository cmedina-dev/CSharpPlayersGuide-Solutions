﻿/**
* Creator: Christian M.
* Date: September 16, 2023
* Description: foreach loop example
**/

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int num in array)
    total += num;
float average = (float)total / array.Length;
Console.WriteLine(average);