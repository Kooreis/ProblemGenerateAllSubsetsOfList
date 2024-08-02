using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3 };
        List<List<int>> subsets = GetSubsets(list, 0);
    }
}