#Importing module
import sqlite3

connection = sqlite3.connect("aquarium.db")

cursor = connection.cursor()

#Creating the table
#cursor.execute("CREATE TABLE fish (name TEXT, species TEXT, tank_number INTEGER)")

#Inserting data into the table
cursor.execute("INSERT INTO fish VALUES ('Sammy', 'shark', 1)")
cursor.execute("INSERT INTO fish VALUES ('Jamie', 'cuttlefish', 7)")

def inserting_data():
    name1 = input("Enter the fish's name: ")
    species1 = input("Enter the the fish species: ")
    tank_number1 = input("Enter the tank number: ")

    cursor.execute("INSERT INTO fish (name,species,tank_number) VALUES (?,?,?)",(name1, species1, tank_number1)) 
inserting_data()

#Fetching data
rows = cursor.execute("SELECT name, species, tank_number FROM fish").fetchall()
cursor.close

#Displaying data
print(rows)

def searching_database():
    target_fish_name = input("Enter the name of the fish you wish to search for: ")

    rows = cursor.execute(
        "SELECT name, species, tank_number FROM fish WHERE name =?",(target_fish_name,),
    ).fetchall()

    print(rows)
searching_database()


    
