
from functools import *
fruits = [("apple", 1), ("apple", 2), ("banana", 10), ("pineapple", 1)]
empty_order = { "apple":0, "banana":0, "pineapple":0}
#order = reduce(lambda d,p: d[p[0]] = d[p[0]] + p[1], fruits, empty_order)

def update(d,p):
    d[p[0]] = d[p[0]] + p[1]
    print(d)
    return d

order = reduce(update, fruits, empty_order)

print(order)

