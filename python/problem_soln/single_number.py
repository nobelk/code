def singleNumber(nums) -> int:
    num_store = {}
    for num in nums:
        if num in num_store:
            num_store[num] = num_store[num] + 1
        else:
            num_store[num] = 1
    for key, value in num_store.items():
        if value < 2:
            return key
    return -1


def single_number_alt(nums) -> int:
    r_num = 0b0
    for num in nums:
        r_num = r_num ^ num
    return int(r_num)