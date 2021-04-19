class group:

    def __init__(self, firstName, lastName, genderIdentify):
        self.firstName = firstName
        self.lastName = lastName
        self.genderIdentify = genderIdentify

    def getName(self):
        self.firstName = input("Please write your name: ")

    def getLastName(self):
        self.lastName = input("Please write your last name: ")

    def getGender(self):
        print("""1: Male
2: Female
3: Other""")

        self.genderIdentify = input("Please write your gender: ")
        if self.genderIdentify == "Male" or "male" or "M" or "1":
            genderM = "Male"
            self.genderIdentify = genderM
            print("Your gender is: ", self.genderIdentify)

        elif self.genderIdentify == "Female" or "female" or "F" or "2":
            genderF = "Female"
            self.genderIdentify = genderF
            print("Your gender is: ", self.genderIdentify)

        elif self.genderIdentify == "Other" or "other" or "3":
            self.genderIdentify = input("Please write your gender: ")
            print("Your gender is: ", self.genderIdentify)


bluegroup = group("Kacper" ,"Galecki", "Male")
bluegroup.getName()
bluegroup.getLastName()
bluegroup.getGender()
