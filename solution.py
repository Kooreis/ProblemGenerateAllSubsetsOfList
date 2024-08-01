def power_set(input_list):
    # An empty list is the base case for recursion
    if len(input_list) == 0:
        return [[]]