from functools import lru_cache
from typing import Generator


def fib_iterative(n: int) -> int:
    n_2 = 0
    n_1 = 1

    if n < 2:
        return n

    for _ in range(1, n):
        n_2, n_1 = n_1, n_2 + n_1

    return n_1


@lru_cache(maxsize=None)
def fib_memoization(n: int) -> int:
    if n < 2:
        return n
    return fib_memoization(n - 2) + fib_memoization(n - 1)


def fib_generator(n: int) -> Generator[int, None, None]:
    yield 0
    if n > 0: yield 1
    n_2: int = 0
    n_1: int = 1
    for _ in range(1, n):
        n_2, n_1 = n_1, n_2 + n_1
        yield n_1
