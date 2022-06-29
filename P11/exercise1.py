vals = [1,2,3,4,5,6,7,8,9,10]

vals_plus_2 = []

for v in vals:
    vals_plus_2.append(v+2)

vals_plus_2_divisible_by_3 = []

for v in vals_plus_2:
    if v % 3 == 0:
        vals_plus_2_divisible_by_3.append(v)

sum = 0

for v in vals_plus_2_divisible_by_3:
    sum = sum + v

print(sum)