from collections import deque


class MovingAverage:
    capacity = 0
    size = 0
    store = deque()
    sum = 0

    def __init__(self, size):
        assert 0 < size < 100
        self.capacity = size

    def next(self, val: int) -> float:
        self.size += 1
        self.store.append(val)

        tail = self.store.popleft() if self.size > self.capacity else 0

        self.sum = self.sum - tail + val

        return self.sum / min(self.size, self.capacity)






