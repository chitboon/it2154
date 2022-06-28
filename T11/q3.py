from functools import *

students = [ {"name": "Seah Bo Keng", "score": 0, "status" : "withdraw" }, 
{"name": "Sum Ting Wong", "score": 79, "status" : "enrolled" }, 
{"name": "Annie How", "score": 80, "status" : "enrolled" },  
{"name": "Lee Kum Kee", "score": 90, "status" : "enrolled" } ]
r1 = filter(lambda s:s["status"] != "withdraw", students)
r2 = list(map(lambda s:s["score"], r1))
r3 = reduce(lambda x,y: x+y, r2) / len(r2)

print(r3)



sum = 0
count = 0
for s in students:
    if s["status"] != "withdraw":
        sum += s["score"]
        count += 1
r4 = sum / count

print(r4)