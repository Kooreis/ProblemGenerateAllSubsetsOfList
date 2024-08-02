else:
        main_subset = []
        for small_subset in power_set(input_list[1:]):
            main_subset += [small_subset]
            main_subset += [[input_list[0]] + small_subset]
        return main_subset