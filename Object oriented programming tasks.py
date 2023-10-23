#Object oriented programming 

class Student:
    #Initiating object class
    def __init__(self, name, student_id, student_class):
        self.name = name
        self.student_id = student_id
        self.student_class = student_class

    def __str__(self):
        return f"{self.name} is in class {self.student_class} with the student id {self.student_id}."

#Displaying the class
def student():
    student1 = Student("Ava", "M2012345", "A")
    print(student1)
student()

#Displaying the attributes for the object
def student_data(student):
    print(student.student_id)
    print(student.name)
    print(student.student_class)
    
student2 = Student("Finley", "M2345678", "C")
student_data(student2)

def classTask():
    print(Student.__dict__)
    print(Student.__module__)
classTask()

#Modifying the attribute data
def modify():
    #Original data
    student3 = Student("Jackson", "M2154321", "D")
    print(student3.name)
    print(student3.student_id)
    print(student3.student_class)

    #Modified data
    student3.student_class = "C"
    student3.name = "Jaxson"
    print("\n")
    print(student3.name)
    print(student3.student_id)
    print(student3.student_class)
    
modify()

#Object with attributes inputted by the user.
def user_input():
    #Input the attributes
    student_name_input = input("Enter the student's name")
    student_id_input = input("Enter the student's id")
    student_class_input = input("Enter the student's class")

    #Assign to an object
    student4 = Student(student_name_input, student_id_input, student_class_input)
    #Output class with user inputted attributes
    print(student4)
user_input()

#Deleting an atrribute
def delete():
    class Students:
        def __init__(self, name, student_id, student_class):
            self.name = name
            self.student_id = student_id
            self.student_class = student_class

    student = Students("Harrison", "M2209876", "B")
    print( student.name, "\n", student.student_id, "\n", student.student_class)
    del student.name
    print( student.student_id, "\n", student.student_class)
delete()
