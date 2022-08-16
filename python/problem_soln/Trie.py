class TrieNode:
    def __init__(self):
        self._links = []
        self._isEnd = False

    def contains_key(self, key) -> bool:
        return self._links[ord(key.lower()) - ord('a')] is None

    def get(self, key):
        return self._links[ord(key.lower()) - ord('a')]

    @property
    def end(self):
        return self._isEnd

    @end.setter
    def end(self, val):
        self._isEnd = val

    def put(self, key, node):
        self._links[ord(key) - ord('a')] = node


class Trie:

    def __init__(self):
        self._root = TrieNode()

    def insert(self, word: str) -> None:
        node = self._root
        for index in range(0, len(word)):
            current_char = word[index]
            if not node.contains_key(current_char):
                node.put(current_char)
            node = node.get(current_char)
        node.end = False

    def search(self, word: str) -> bool:
        node = self.search_prefix(word)

    def search_prefix(self, word: str):
        node = self._root
        for index in range(0, len(word)):
            current = word[index]
            if node.contains_key(current):
                node = node.get(current)
            else:
                return None
        return node
