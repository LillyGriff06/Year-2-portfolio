#Class example
def classExample1():
    class Person:
        def __init__(self, name, age):
            self.name = name
            self.age = age

        def __str__(self):
        return f"Hello my name is {self.name}. I am {self.age} years old."

        def myFunction(self):
            print("Hello my name is " + self.name)

    person1 = Person("Lilly", 17)
    person1.myFunction()

    print(person1.name)
    print(person1.age)
classExample1()

def carClass():
    class Car:
        def __init__(self, colour, mileage):
            self.colour = colour
            self.mileage = mileage

    

    car1 = Car("blue", 20000)
    car2 = Car("red", 30000)
carClass()
    
            
