#Importing module
import sqlite3

connection = sqlite3.connect("pet_shop.db")

cursor = connection.cursor()

#Creating the table
#cursor.execute("CREATE TABLE dogs (name TEXT, species Text, pet_id INTEGER)")

#Inserting data into the table
def inserting_data():
    name = input("Enter the dog's name: ")
    species = input("Enter the dog species: ")
    pet_id = input("Enter the pet id for the dog: ")

    cursor.execute("INSERT INTO dogs (name,species,pet_id) VALUES (?,?,?)", (name, species, pet_id))

def displaying_data():
    #Feching data from database
    rows = cursor.execute("SELECT name, species, pet_id FROM dogs").fetchall()
    cursor.close

    print(rows)

#Searching the database using the name
def search_by_name():
    #Inputting name to search for
    target_dog_name = input("Enter a name to search for a dog that matches: ")

    rows = cursor.execute(
        "SELECT name, species, pet_id FROM dogs WHERE name =?",(target_dog_name,),
    ).fetchall()
    
    #Displaying result of search
    print(rows)

#Searching the database using the species
def search_by_species():
    #Inputting species to search for
    target_dog_species = input("Enter a species to search for matching dogs: ")

    rows = cursor.execute(
        "SELECT name, species, pet_id FROM dogs WHERE species =?",(target_dog_species,),
    ).fetchall()

    #Displaying result of search
    print(rows)

#Searching te database using the pet ID
def search_by_pet_id():
    #Inputting pet ID to search for
    target_dog_pet_id = input("Enter a pet ID to search for a matching dog: ")

    rows = cursor.execute(
        "SELECT name, species, pet_id FROM dogs WHERE pet_id =?",(target_dog_pet_id,),
    ).fetchall()

    #Displaying result of search
    print(rows)
    
#Menu
def menu():
    print("1. Inserting data into the database")
    print("2. Displaying data from the database")
    print("3. Searching the database by name")
    print("4. Searching the database by species")
    print("5. Searching the database by pet_id")
    option = int(input("\nChoose an option: "))
    while option > 0 and option < 6:
        if option == 1:
            inserting_data()
            option = int(input("\nChoose an option: "))
        if option == 2:
            displaying_data()
            option = int(input("\nChoose an option: "))
        if option == 3:
            search_by_name()
            option = int(input("\nChoose an option: "))
        if option == 4:
            search_by_species()
            option = int(input("\nChoose an option: "))
        if option == 5:
            search_by_pet_id()
            option = int(input("\nChoose an option: "))
menu()
    
