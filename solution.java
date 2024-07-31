Here is a Java console application that generates all subsets of a list:

```java
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Integer> list = Arrays.asList(1, 2, 3);
        List<List<Integer>> subsets = generateSubsets(list);
        for (List<Integer> subset : subsets) {
            System.out.println(subset);
        }
    }

    public static List<List<Integer>> generateSubsets(List<Integer> list) {
        List<List<Integer>> subsets = new ArrayList<>();
        generateSubsetsHelper(list, subsets, new ArrayList<>(), 0);
        return subsets;
    }

    private static void generateSubsetsHelper(List<Integer> list, List<List<Integer>> subsets, List<Integer> current, int index) {
        subsets.add(new ArrayList<>(current));
        for (int i = index; i < list.size(); i++) {
            current.add(list.get(i));
            generateSubsetsHelper(list, subsets, current, i + 1);
            current.remove(current.size() - 1);
        }
    }
}
```

This program generates all subsets of a list by using a recursive helper function. The helper function adds the current subset to the list of subsets, then for each element in the list that hasn't been included in the current subset yet, it adds the element to the current subset and recursively generates all subsets that include that element. After the recursive call returns, it removes the element from the current subset to prepare for the next iteration.