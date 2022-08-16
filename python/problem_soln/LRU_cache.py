from collections import OrderedDict


class LRUCache(OrderedDict):
    def __init__(self, capacity: int):
        self.capacity = capacity

    def get(self, key):
        if key not in self:
            return -1
        self.move_to_end(key)
        return self[key]

    def put(self, key, val):
        if key in self:
            self.move_to_end(key)
        self[key] = val
        if len(self) > self.capacity:
            self.popitem(last=False)
