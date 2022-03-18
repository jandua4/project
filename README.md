
# Important Information

---

***NB - you will need to ensure that all of the necessary packages are installed. Ensure they are installed for .NET Core 5.0.12***

**To set up this web application for local testing, you need to take the following steps**:
1. Clone the repository and move Restaurant.Tests up one directory level so that the folder is one level above the project solution
2. Use Microsoft SQL Management Studio to import the schema.sql, then data.sql file (if you are building the database from scratch, skip to the next heading).
3. Create an empty folder called Menus on the same directory level as the Controllers
4. Check the appsettings.json and ensure the database connection credentials are accurate
5. Run the application and apply any migrations that are required
6. Register as a user on the application
7. Go to the database and create a new row in the AspNetUserRoles table with the values of the UserId of the user you just registered, and RoleId of the Administrator Role
8. Run the application, and logout/login to reload the user permissions

**Alternatively, you can avoid using the SQL files and take the following steps instead**:
1. Run the application
2. Apply any migrations required
3. Create an empty folder called Menus on the same directory level as the Controllers
4. Register as a user on the application
5. Edit the RolesController and temporarily comment out the Authorization policies
6. Go to /Roles/Create in the application and create the following 3 roles
- > Administrator
- > Restaurant
- > User
7. Go to the database and create a new row in the AspNetUserRoles table with the values of the UserId of the user you just registered, and RoleId of the Administrator Role
8. Uncomment the Authorization policies in the RolesController
9. Restart the application and relog to have access as an administrative user on the application

**To Run the Unit Tests, take the following steps:**
1. Clone the repository
2. Move the Restaurant.Tests folder up one directory (so that the tests are one level above the project solution)
3. Open the project and open the Test Explorer window so that you can run the tests.