from random_number_generator import RandomNumberGenerator
import time


def test_random_number():
    rn = RandomNumberGenerator(0)
    assert rn.get_next_random() == 0


def test_random_number_with_seed():
    rn = RandomNumberGenerator(round(time.time() * 1000))
    assert rn.get_next_random() > 0