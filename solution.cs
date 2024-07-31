Here is a C# console application that generates all subsets of a list:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3 };
        List<List<int>> subsets = GetSubsets(list, 0);
        foreach (var subset in subsets)
        {
            Console.Write("{ ");
            foreach (var num in subset)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("}");
        }
    }

    static List<List<int>> GetSubsets(List<int> list, int index)
    {
        List<List<int>> allSubsets;
        if (list.Count == index)
        {
            allSubsets = new List<List<int>>();
            allSubsets.Add(new List<int>());
        }
        else
        {
            allSubsets = GetSubsets(list, index + 1);
            int item = list[index];
            List<List<int>> moreSubsets = new List<List<int>>();
            foreach (var subset in allSubsets)
            {
                List<int> newSubset = new List<int>();
                newSubset.AddRange(subset);
                newSubset.Add(item);
                moreSubsets.Add(newSubset);
            }
            allSubsets.AddRange(moreSubsets);
        }
        return allSubsets;
    }
}
```

This program generates all subsets of a list by using a recursive function. It starts by adding an empty subset to the list of all subsets. Then, for each element in the original list, it creates a new subset by adding the element to each existing subset, and adds these new subsets to the list of all subsets. This process is repeated until all elements in the original list have been processed.