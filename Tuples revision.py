#Tuple revision
def creatingTuples():
    #Empty tuple
    #Output: ()
    my_tuple1 = ()
    print(my_tuple1)
    #Tuple having integers
    #Output: (1,2,3)
    my_tuple2 = (1,2,3)
    print(my_tuple2)
    #Tuple with mixed datatypes
    #Output: (1, "Hello", 3.4)
    my_tuple3 = (1, "Hello", 3.4)
    print(my_tuple3)
    #Nested tuple
    #Output: ("mouse", [8,4,6], (1,2,3))
    my_tuple4 = ("mouse", [8,4,6], (1,2,3))
    print(my_tuple4)
creatingTuples()

def indexingTuples():
    my_tuple = ['h','e','l','l','o']
    #Output: h
    print(my_tuple[0])
    #Output: e
    print(my_tuple[1])
    #Output: l
    print(my_tuple[3])
    #Negative index
    #Output: l
    print(my_tuple[-3])
    #Output: o
    print(my_tuple[-1])
indexingTuples()

def slicingTuples():
    my_tuple = ['c','o','m','p','u','t','i','n','g']
    #Elements 4th to 6th
    print(my_tuple[3:6])
    #Element beginnig to 5th
    print(my_tuple[:-4])
    #Elements 6th to end
    print(my_tuple[5:])
    #Elements beginning to end
    print(my_tuple[:])
slicingTuples()

def tupleMembershipTesting():
    my_tuple = ('a','p','p','l','e')
    #In operation
    #Output: True
    print('a' in my_tuple)
    #Output: False
    print('b' in my_tuple)
    #Not in operation
    #Output: True
    print('g' not in my_tuple)
tupleMembershipTesting()

def iteratingTuples():
    #Output: Hello John and Output: Hello Kate
    for name in ('John','Kate'):
        print("Hello", name)
iteratingTuples()
