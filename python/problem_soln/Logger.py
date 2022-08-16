

class Logger:

    def __init__(self):
        self.store = dict()
        self.threshold = 10

    def should_print_msg(self, timestamp, msg):
        if msg not in self.store:
            self.store[msg] = timestamp
            return True

        if timestamp - self.store[msg] >= self.threshold:
            self.store[msg] = timestamp
            return True
        else:
            return False
