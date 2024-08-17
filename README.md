# CMPG-323-Project-3_34221700

# Project Overview
This project involves enhancing and improving an existing Web Application that manages CRUD functionality for project and client data. As a developer, I am  expected to focus on the reading and understanding of code while also enhancing the application through the implementation of architectural patterns, coding principles, and design patterns.

# The core functionality of the system includes:

# Project Management:
Create, Read, Update, and Delete (CRUD) operations for managing project data such as ProjectId, ProjectName, ProjectDescription, ProjectCreationDate, ProjectStatus, ClientId.
# Client Management:
CRUD operations for managing client information such as ClientId, ClientName, PrimaryContactEmail, DateOnboarded.

# Non-Functional Requirements
In addition to functional requirements, the project adheres to best practices in software development, which include:

*Security: Ensuring that no sensitive credentials are exposed within the codebase and that data is securely stored.
*Scalability: The system is built to scale with increased usage without sacrificing performance.
*Maintainability: The use of design patterns like the Repository Pattern ensures that the system can be easily maintained and extended.

# Technologies Used
.NET Core MVC: The web framework used to build the application.
Entity Framework Core: For data access and management of database operations.
Azure SQL Database: The database for storing project and client data, hosted on Azure.
Git & GitHub: Version control and project repository hosting.
Azure App Service: Cloud hosting for the deployed application.

# User Guide for this  Web App
#Step 1: Accessing the Application
Web App URL: Once you have deployed the application to Azure, provide the URL to users so they can access the app through their web browser.
Example: https://yourappname.azurewebsites.net

#Step 2: Navigating the Application
Your web app has features for managing projects and clients, enabling users to Create, Read, Update, and Delete (CRUD) data.

# Homepage
When the user lands on the homepage, they will typically see a dashboard or list of existing projects and clients.
Project Management
View Projects: The user can view all the projects by clicking the "Projects" link or button in the navigation bar.
Create a New Project:
Click on the “Create Project” button.
Fill out the form with details such as Project Name, Description, Date, Status, and Client.
Submit the form to create a new project. The project will be added to the list.
Edit a Project:
Click on the "Edit" button next to the project you wish to update.
Modify the project details in the form and submit.
# Delete a Project:
Click on the "Delete" button next to the project you want to remove.
Confirm the deletion to remove the project from the list.
Client Management
View Clients: Users can view the list of clients by selecting the "Clients" section.
# Create a New Client:
Click the “Create Client” button.
Fill out the client’s details (name, onboard date, etc.) and submit the form.
# Edit a Client:
Click on the "Edit" button next to the client you want to update.
Make the necessary changes and submit the form.
# Delete a Client:
Click on the "Delete" button next to the client you want to remove.
Confirm the action to delete the client.

# Step 3: Data Storage
Connection to Database: The application connects to a database hosted on Azure. When users create, edit, or delete projects and clients, the data is saved directly to the database. All actions are persisted, so the next time the user logs in, their data will be up-to-date.

# Step 4: Error Handling
If any action fails (e.g., a project is not found or a database connection error occurs), the application will display an appropriate error message and prompt the user to retry or take corrective action.

# Step 5: Security
Authentication: If the application is secured with authentication (e.g., Azure Active Directory), users will need to log in with their credentials to access the app.
Data Protection: Sensitive information such as database credentials is not exposed in the code and is stored securely using environment variables or Azure’s secret management services.

