def greet(fname,lname,gender):
    salute = "" 
    if gender.lower() == "m":
        salute = "Mr. "
    else:
        salute = "Ms. "
    return salute + fname + " " + lname

fn = input("First Name:")
ln = input("Last Name:")
g  = input("Gender (M or F):")
print("Hello " + greet(fn,ln,g))
