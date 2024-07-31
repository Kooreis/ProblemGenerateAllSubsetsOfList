Here is a Python console application that generates all subsets of a list:

```python
def power_set(input_list):
    # An empty list is the base case for recursion
    if len(input_list) == 0:
        return [[]]
    else:
        main_subset = []
        for small_subset in power_set(input_list[1:]):
            main_subset += [small_subset]
            main_subset += [[input_list[0]] + small_subset]
        return main_subset

def main():
    input_list = input("Enter elements of list separated by space: ").split()
    print("All subsets of the list are: ", power_set(input_list))

if __name__ == "__main__":
    main()
```

You can run this console application, it will ask you to enter elements of a list separated by space. After entering the elements, it will print all subsets of the list.