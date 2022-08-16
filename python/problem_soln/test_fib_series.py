import pytest
import fib_series

test_data = [(0, 0), (1, 1), (100, 354224848179261915075)]

@pytest.mark.parametrize("input, expected_output", test_data, ids=["fib_0", "fib_1", "fib_100"])
def test_fib_series(input, expected_output):
    assert expected_output == fib_series.fib_iterative(input)
    assert expected_output == fib_series.fib_memoization(input)

def test_fib_generator():
    last = 1
    for output in fib_series.fib_generator(100):
        last = output
    assert last == 354224848179261915075