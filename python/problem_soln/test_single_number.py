from single_number import singleNumber, single_number_alt


def test_single_number():
    single_number = singleNumber([1, 3, 5, 7, 9, 1, 5, 7, 9])
    assert single_number == 3

def test_single_number_alt():
    single_number = single_number_alt([1, 3, 5, 7, 9, 1, 5, 7, 9])
    assert single_number == 3
