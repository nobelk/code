import pytest

from LRU_cache import LRUCache


def test_LRU_cache():
    obj = LRUCache(5)
    for counter in range(1, 10000):
        obj.put(counter, counter)

    assert obj.get(9999)