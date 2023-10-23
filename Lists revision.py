#List revision
def accessingData():
    my_list = ['p','r','o','b','e']
    #Output: p
    print(my_list[0])
    #Output: o
    print(my_list[2])
    #Output: e
    print(my_list[4])
    #Negative indexing
    #Output: e
    print(my_list[-1])
    #Output: p
    print(my_list[-5])
accessingData()

def sliceLists():
    my_list = ['p','r','o','g','r','a','m','i','z']
    #Elements 3rd to 5th
    print(my_list[2:5])
    #Elements beginning to 4th
    print(my_list[:-5])
    #Elements 6th to end
    print(my_list[5:])
    #Elements beginning to end
    print(my_list[:])
sliceLists()

def changeOrAdd():
    #Mistake value
    odd = [2,4,6,8]
    #Change the 1st item
    odd[0] = 1
    #Change 2nd to 4th items
    odd[1:4] = [3,5,7]
    #Output:[1,3,5,7]
    print(odd)
changeOrAdd()

def appendingLists():
    odd = [1,3,5]
    #Append 7
    odd.append(7)
    #Output list
    print(odd)
    #Add 9, 11 and 13
    odd.extend([9,11,13])
    #Output list
    print(odd)
appendingLists()

def deleteOrRemove():
    deleteList = ['p','r','o','b','l','e','m']
    #Output list
    print(deleteList)
    #Delete one item
    del deleteList[2]
    #Output list
    print(deleteList)
    #Delete multiple items
    del deleteList[1:5]
    #Output list
    print(deleteList)
    #delete entire list
    del deleteList
    #Output list - error message
    #print(deleteList)
deleteOrRemove()

def tasksEasy():
    #List
    teams = ["Ferrari","Williams","Haas","Racing Point"]
    print(teams)
    #Task 1 - Output first in list
    print("Current bonus payment: ",teams[0])
    #Task 2 - Output second in list
    print("Current rival: ",teams[1])
    #Task 3 - Change Racing Point
    teams[3] = "Aston Martin"
    print("Racing Point is now", teams[3])
    #Task 4 - Append two new teams + output list
    teams.append("McLaren")
    teams.append("Red Bull")
    print(teams)
    #Task 5 - User input to replace a team
    print("0 - ",teams[0])
    print("1 - ",teams[1])
    print("2 - ",teams[2])
    print("3 - ",teams[3])
    print("4 - ",teams[4])
    print("5 - ",teams[5])
    replace = int(input("Which team would you like to replace? \nEnter the number: "))
    name = input("Enter the name of the new team: ")
    if replace == 0:
        teams[0] = name
        print(teams)
    if replace == 1:
        teams[1] = name
        print(teams)
    if replace == 2:
        teams[2] = name
        print(teams)
    if replace == 3:
        teams[3] = name
        print(teams)
    if replace == 4:
        teams[4] = name
        print(teams)
    if replace == 5:
        teams[5] = name
        print(teams)
tasksEasy()

def tasksCont():
    #Lists
    #Task 1 - Create two lists
    drivers = ["Sebastian Vettel","Charles Leclerc","Kevin Magnussen", "Lando Norris"]
    wagesMillions = [21, 17, 3, 5]
    #Task 2 - Loop and output the drivers and wages
    for x in range(4):
        print(drivers[x])
        print(wagesMillions[x], "million")
    #Task 3 - Loop and add all wages to a variable and output it
    totalWage = 0
    for x in range(4):
        totalWage += wagesMillions[x]
    print("The total wages in millions for all of the drivers is" , totalWage)
tasksCont()


    
