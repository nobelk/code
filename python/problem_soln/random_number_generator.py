class RandomNumberGenerator:
    def __init__(self, seed: int):
        self.A = 48271
        self.M = pow(2, 31) - 1
        self.C = 0
        self.r_n_1 = seed

    def get_next_random(self) -> int:
        r_n = (self.A * self.r_n_1 + self.C) % self.M
        self.r_n_1 = r_n
        return r_n

    def get_next_random_between(self, l: int, h: int) -> int:
        r_n = self.get_next_random()
        return round(l + ((h - l + 1) * r_n) / self.M)
