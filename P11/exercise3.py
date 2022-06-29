from functools import reduce


def update(d,w):
    d[w] = d[w]+1 if w in d else 1
    return d

def wc(sent):
    return reduce(update, sent.split(" "), {})

print(wc("twinkle twinkle little star how i wonder what you are"))