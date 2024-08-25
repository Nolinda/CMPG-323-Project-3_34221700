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

# MY REFERENCE LIST FOR PROJECT 3
1.	CMPG 323 – IT Developments. 2023, 31 Aug. Patterns & Standards [YouTube video]. https://youtu.be/-Xn7i_BcKJg Date of access: 19 Aug. 2024.

2.	CMPG 323 – IT Developments. 2023, 6 Sep. Implementing Design Patterns [YouTube video]. https://youtu.be/_5iD4efyeE8 Date of access: 20 Aug. 2024.


3.	CMPG 323 – IT Developments. 2023, 6 Sep. Background Patterns [YouTube video]. https://youtu.be/E8QQpncP9ts Date of access: 20 Aug. 2024.

4.	CMPG 323 – IT Developments. 2023, 31 Aug Application of Design Patterns to ASP.NET Core 3.1 MVC Web App [YouTube video]. https://youtu.be/VYvgmMkGUfc Date of access: 19 Aug. 2024.

5.	OpenAI (2024) Response from ChatGPT on the topic of concurrency control in web applications. Available at: https://chat.openai.com/ (Accessed: 23 August 2024).

6.	OpenAI (2024) Response from ChatGPT on the topic of How to make repository classes to interact with controller classes . Available at: https://chat.openai.com/ (Accessed: 23 August 2024).

7.	OpenAI (2024) Response from ChatGPT on the topic of how to apply dependency injection correctly. Available at: https://chat.openai.com/ (Accessed: 21 August 2024).

8.	OpenAI (2024) Response from ChatGPT on the topic of How to correct recursive calls in ClientRepository. Available at: https://chat.openai.com/ (Accessed: 21 August 2024).

9.	Microsoft (n.d.) Build web apps with ASP.NET Core for beginners. Available at: https://learn.microsoft.com/en-us/training/paths/build-web-apps-with-aspnet-core/ (Accessed: 25 August 2024).

10.	Microsoft (n.d.) ASP.NET MVC Overview. Available at: https://learn.microsoft.com/en-us/aspnet/mvc/overview/ (Accessed: 23 August 2024).

11.	Microsoft (n.d.) Secure a .NET web app with the ASP.NET Core Identity framework. Available at: https://learn.microsoft.com/en-us/training/modules/secure-aspnet-core-identity/ (Accessed: 23 August 2024).

12.	Agarwal, M. (2023) Design patterns in C# .NET. Available at: https://www.c-sharpcorner.com/article/design-patterns-in-c-sharp/ (Accessed: 22 August 2024).

13.	Jena, B. (2023) Architectural patterns in .NET. Available at: https://www.c-sharpcorner.com/article/architectural-patterns-in-net/ (Accessed: 25 August 2024).

14.	Thumb IKR – Programming examples. 2020, 6 Sep. Use Generic Type Controller and Interface (Repository Pattern) | ASP.NET Core Web API | Basic CRUD [YouTube video]. https://youtu.be/gb-wA2HDSYw Date of access: 19 Aug. 2024.

15.	TutorialUE. 2022, 8 Aug. Dependency Injection for ASP NET Core 6.0. [YouTube video]. https://youtu.be/9J9a77ga9R0 Date of access: 23 Aug. 2024.


