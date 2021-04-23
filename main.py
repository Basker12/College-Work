def calc():
    #global age
    #age = None

    print("COVID-19 AGE CALCULATOR")
    age = int(input("Please enter your age: "))
    if age <= 20:
        age = 20
    if age >= 85:
        age = 85

    gender = input("Please write your gender: ").upper()
    if gender == "Male" or "Female":
        print("")


calc()