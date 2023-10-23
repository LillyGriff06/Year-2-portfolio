#Importing the module
import sqlite3

connection = sqlite3.connect("contactBook.db")
cursor = connection.cursor()

#Creating the table
#cursor.execute("CREATE TABLE contact (contactID INTEGER, firstName TEXT, lastName TEXT, addressID INTEGER, phoneNumber TEXT, email TEXT)")
#cursor.execute("CREATE TABLE address (contactID INTEGER, addressID INTEGER, postCode TEXT, houseNumber INTEGER, streetName TEXT, townName TEXT, country TEXT)")

#Function 1 - adding a contact to the database
def addContact(tempContactID):
    print("\n")
    #Assigning data to variables with the correct data type
    contactID = tempContactID
    firstName = input("Enter the contact's first name: ")
    lastName = input("Enter the contact's last name: ")
    addressID = int(input("Enter the contact's address ID: "))
    phoneNumber = input("Enter the contact's phone number: ")
    email = input("Enter the contact's email address: ")
    #Inserting the data into the contact table
    cursor.execute("INSERT INTO contact (contactID,firstName,lastName,addressID,phoneNumber,email) VALUES (?,?,?,?,?,?)", (contactID, firstName, lastName, addressID, phoneNumber, email))

#Function 2 - adding an address to the database
def addAddress(tempAddressID):
    print("\n")
    #Assigning data to variables with the correct data type
    contactID = int(input("Enter the contact ID: "))
    addressID = tempAddressID
    postCode = input("Enter the post code: ")
    houseNumber = int(input("Enter the house number: "))
    streetName = input("Enter the name of the street: ")
    townName = input("Enter the name of the town: ")
    country = input("Enter the name of the country: ")
    #Inserting the data into the address table
    cursor.execute("INSERT INTO address (contactID,addressID,postCode,houseNumber,streetName,townName,country) VALUES (?,?,?,?,?,?,?)", (contactID, addressID, postCode, houseNumber, streetName, townName, country))

#Function 3 - searching for a contact by its name
def searchContact():
    print("\n")
    print(" 1.) Search by first name \n 2.) Search by last name \n 3.) Search by first and last name")
    print("\n")
    choice = int(input("Choose how you wish to search. Enter the number: "))
    print("\n")
    if choice == 1:
        #Inputting name to search contact table for
        targetFirstName = input("Enter a name (first name) to search for: ")
        #Searching the database table for the contact with this name
        rows = cursor.execute(
            "SELECT contactID, firstName, lastName, addressID, phoneNumber, email FROM contact WHERE firstName =?", (targetFirstName,),
        ).fetchall()
        #Displaying the result of the search
        print(rows)
    if choice == 2:
        #Inputting name to search contact table for
        targetLastName = input("Enter a name (last name) to search for: ")
        #Searching the database table for the contact with this name
        rows = cursor.execute(
            "SELECT contactID, firstName, lastName, addressID, phoneNumber, email FROM contact WHERE lastName =?", (targetLastName,),
        ).fetchall()
        #Display the result of the search
        print(rows)
    if choice == 3:
        #Inputting name to search contact table for
        targetFirstName = input("Enter a name (first name) to search for: ")
        targetLastName = input("Enter a name (last name) to search for: ")
        #Searching the database table for the contact with these names
        rows = cursor.execute(
            "SELECT contactID, firstName, lastName, addressID, phoneNumber, email FROM contact WHERE firstName =? AND lastName =?", (targetFirstName, targetLastName,),
        ).fetchall()
        #Display the result of the search
        print(rows)

#Function 4 - displaying all contacts in the contact table
def displayContact():
    print("\n")
    #Fetching data from database
    rows = cursor.execute("SELECT contactID, firstName, lastName, addressID, phoneNumber, email FROM contact").fetchall()
    cursor.close
    print(rows)

#Function 5 - displaying all addresses in the address table
def displayAddress():
    print("\n")
    #Fetching data from database
    rows = cursor.execute("SELECT contactID, addressID, postCode, houseNumber, streetName, townName, country FROM address").fetchall()
    cursor.close
    print(rows)
    
#Function 6 - deleting a contact
def deleteContact():
    print("\n")
    #Inputting contact ID to delete from the database
    deleteContact = int(input("Enter the contact ID of the contact you wish to delete: "))
    cursor.execute("DELETE FROM contact WHERE contactID =?", (deleteContact,),)
    connection.commit()
    #cursor.close()

#Function 7 - deleting address
def deleteAddress():
    print("\n")
    #Inputting address ID to delete from the database
    deleteAddress = int(input("Enter the address ID of the address you wish to delete: "))
    cursor.execute("DELETE FROM address WHERE addressID =?", (deleteAddress,),)
    connection.commit()
    #cursor.close()
    
#Function 8 - modifying a contact
def modifyContact():
    print("\n")
    chosenContactID = int(input("Enter the ID of the contact you wish to modify: "))
    print("\n")
    print(" What would you like to modify today? \n 1.) First name \n 2.) Last name \n 3.) address ID \n 4.) Phone number \n 5.) Email")
    modify = int(input("Choose something to modify (enter number): "))
    if modify == 1:
        newFirstName = input("Enter the new name (first name): ")
        cursor.execute("UPDATE contact SET firstName =? WHERE contactID = ?", (newFirstName, chosenContactID,),)
        connection.commit()
    elif modify == 2:
        newLastName = input("Enter the new name (last name): ")
        cursor.execute("UPDATE contact SET lastName =? WHERE contactID = ?", (newLastName, chosenContactID,),)
        connection.commit()
    elif modify == 3:
        newAddressID = int(input("Enter the new address ID: "))
        cursor.execute("UPDATE contact SET addressID =? WHERE contactID = ?", (newAddressID, chosenContactID,),)
        connection.commit()
    elif modify == 4:
        newPhoneNumber = input("Enter the new phone number: ")
        cursor.execute("UPDATE contact SET phoneNumber =? WHERE contactID = ?", (newPhoneNumber, chosenContactID,),)
        connection.commit()
    elif modify == 5:
        newEmail = input("Enter the new email: ")
        cursor.execute("UPDATE contact SET email =? WHERE contactID = ?", (newEmail, chosenContactID,),)
        connection.commit()
    
#Function 9 - the menu
def menu():
    global tempContactID
    tempContactID = 0
    global tempAddressID
    tempAddressID = 0
    #Options that the program should be able to carry out
    print("1. Add contact")
    print("2. Add address")
    print("3. Search for contact by name")
    print("4. Display contact table")
    print("5. Display address table")
    print("6. Delete a contact")
    print("7. Delete an address")
    print("8. Modify a contact")
    print("9. Exit")
    #Choosing an option
    option = int(input("\nChoose an option:"))
    while option > 0 and option < 9:
        if option == 1:
            cursor = connection.cursor()
            tempContactID = tempContactID + 1
            addContact(tempContactID)
            option = int(input("\nChoose an option:"))
        if option == 2:
            cursor = connection.cursor()
            tempAddressID = tempAddressID + 1
            addAddress(tempAddressID)
            option = int(input("\nChoose an option:"))
        if option == 3:
            cursor = connection.cursor()
            searchContact()
            option = int(input("\nChoose an option:"))
        if option == 4:
            cursor = connection.cursor()
            displayContact()
            option = int(input("\nChoose an option:"))
        if option == 5:
            cursor = connection.cursor()
            displayAddress()
            option = int(input("\nChoose an option:"))
        if option == 6:
            cursor = connection.cursor()
            deleteContact()
            option = int(input("\nChoose an option:"))
        if option == 7:
            cursor = connection.cursor()
            deleteAddress()
            option = int(input("\nChoose an option:"))
        if option == 8:
            cursor = connection.cursor()
            modifyContact()
            option = int(input("\nChoose an option:"))
            
menu()
