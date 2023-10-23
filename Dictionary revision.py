#Dictionary revision
def creatingDictionary():
    #Empty dictionary
    my_dict = {}
    #Dictionary with integer keys
    my_dict = {1: 'apple', 2: 'ball'}
    #Dictionary with mixed keys
    my_dict = {'name': 'John', 1: [2, 4, 3]}
    #Using dict()
    my_dict = dict({1:'apple', 2:'ball'})
    #From sequence having each item as a pair
    my_dict = dict([(1,'apple'), (2,'ball')])
    print(my_dict)
creatingDictionary()

def accessingElements():
    my_dict = {'name':'Jack', 'age':26}
    #Output: Jack
    print(my_dict['name'])
    #Output: 26
    print(my_dict.get('age'))
    #Trying to access keys which do not exist throws error
    #my_dict.get('address')
    #my_dict['address']
accessingElements()

def changingElements():
    my_dict = {'name':'Jack', 'age':26}
    #Update value
    my_dict['age'] = 27
    #Output dictionary
    print(my_dict)
    #Add item
    my_dict['address'] = 'Downtown'
    #Output dictionary
    print(my_dict)
changingElements()

def dictionaryTasks():
    #Task 1 - concatenate dictionaries
    dict1 = {1:10, 2:20}
    dict2 = {3:30, 4:40}
    dict3 = {5:50, 6:60}
    my_dict = {}
    for x in (dict1, dict2, dict3):
        my_dict.update(x)
    print(my_dict)
    #Task 2 - iterate over dictionaries using loops
    dict4 = {'a': 1, 'b': 2, 'c': 3, 'd': 4, 'e': 5}
    for dict_key, dict_value in dict4.items():
        print(dict_key, '->',dict_value)
    #Task 3
    n = int(input("Enter a number: "))
    dict5 = dict()
    for a in range(1, n+1):
        dict5[a] = a*a
    print(dict5)
dictionaryTasks()
