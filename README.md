# I-Have-I-Need
Sorry no demo available :(

## Preview



## User Roles
Non-Admin:
1) Create account
2) Manage account (change password and avatar)
3) View other users account, this includes the users basic information: email, avatar, previous postings, previous comments
3) Edit/Delete their postings
4) Edit/Delete their comments

Admin:
Includes all the access of a non-admin plus:
1) Can see and access the categories page
2) Edit/Delete all postings and comments


Setting a user as admin:
To set a existing user as an admin account modify the 

Run the following SQL command to set the users 'role' to 1, which will give them admin access:

UPDATE AspNetUsers
SET Role = 1
WHERE Email = 'user-to-be-admin@email.com';

No other tables need to be modified, however a logoff/login to the account may be needed.
Set the Role column to null to return the user to Non-Admin rights.

Running non-locally:
1) Modify the connection string to connect to a non local database
2) Create the necessary tables once connected to the database. To do this easily open "Main.edmx" and right click on the background of the visual editor, select "Generate Database from Model..." this tool will give you the SQL queries required to create the tables.