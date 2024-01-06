# Code Generator for Data Access and Business Layers

This project provides a tool to automatically generate classes for data access and business layers, streamlining database interaction in C# applications.

## Key Features:

Generates C# classes for data access logic:
Retrieves data by ID
Checks for record existence
Adds new records
Updates existing records
Deletes records
Retrieves all records
Generates C# classes for business layer logic:
Manages interactions with data access classes
Enforces business rules and validation

## Usage:

Run the Code Generator:
Open the frmCodeGenerator form in a C# development environment.
Select Database and Table:
Choose the desired database from the "Databases" dropdown.
Select the table for which to generate classes from the "Database Tables" grid.
Generate Classes:
Click the appropriate button to generate classes for the data access layer, business layer, or both.
The generated code will be displayed in the "Generated Code" textbox.
## Generated Code Structure:

Data Access Layer Classes:
Reside in a separate namespace (e.g., DataAccessLayer).
Contain methods for interacting with the database.
Business Layer Classes:
Reside in a separate namespace (e.g., BusinessLayer).
Interact with data access classes to implement business logic.
## Additional Notes:

The generated code utilizes clsDataAccessSettings for database connection details and clsErrorLogger for error logging.
Consider customizing the generated code further to fit specific project needs.