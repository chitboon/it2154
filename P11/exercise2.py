student_db = [
    {"first_name": "adam", "last_name": "wong",
        "gender": "m",  "admin_no": "190001"},
    {"first_name": "betty", "last_name": "tan",
        "gender": "f", "admin_no": "190002"}
]


def mailing_list(input, gender):
    return list(map(lambda s: s["admin_no"] + "@mymail.nyp.edu.sg", filter(lambda s: s["gender"] == gender, input)))


print(mailing_list(student_db, "f"))