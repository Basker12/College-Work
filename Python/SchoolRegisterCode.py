class group:

    def __init__(self, firstName, lastName, genderIdentify):
        self.firstName = firstName
        self.lastName = lastName
        self.genderIdentify = genderIdentify

    def getName(self):
        fName = input("Please write your name: ")
        if fName == fName:
                firstName = fName.title()
                self.firstName = firstName

    def getLastName(self):
        lName = input("Please write your last name: ")
        if lName == lName:
                lastName = lName.title()
                self.lastName = lastName

    def getGender(self):
        print("""1: Male
2: Female
3: Other""")

        gender = input("Please write your gender: ")
        if gender == "Male" or "male" or "M" or "1":
            gender = self.genderIdentify
            print("Your gender is:", self.genderIdentify)

        elif gender == "Female" or "female" or "F" or "2":
            gender = self.genderIdentify 
            print("Your gender is:", self.genderIdentify)

        elif gender == "Other" or "other" or "3":
            self.genderIdentify = input("Please write your genderf: ")
            print("Your gender is:", self.genderIdentify)


bluegroup = group("Kacper" ,"Galecki", "Male")
bluegroup.getName()
bluegroup.getLastName()
bluegroup.getGender()
