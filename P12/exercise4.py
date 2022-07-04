'''
def sw(x,y):
    t = x
    y = t
    x = y
    return 

def so(a):
    n = len(a)
    for i in range(n):
        for j in range(0, n-i-1):
            if a[j] > a[j+1]:
                sw(a[j],a[j+1]) 
    return a
'''


def sw(x,y):
    return (y,x)

def so(a):
    n = len(a)
    for i in range(n):
        for j in range(0, n-i-1):
            if a[j] > a[j+1]:
                a[j], a[j+1] = sw(a[j],a[j+1]) 
    return a

print(so([3,1,4,5,6,2]))
