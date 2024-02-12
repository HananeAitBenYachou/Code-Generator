# Code Generator for Data Access and Business Layers

This project automates the generation of efficient and reliable code for interacting with a database, including data access and business logic. With the added feature of stored procedure generation, it further simplifies database operations by providing ready-to-use stored procedures for CRUD operations.

## Key Features:

- **Generates C# classes for data access logic:**
    - Retrieves data by ID using stored procedures
    - Checks for record existence using stored procedures
    - Adds new records using stored procedures
    - Updates existing records using stored procedures
    - Deletes records using stored procedures
    - Retrieves all records using stored procedures
    - Generates stored procedures for the selected tables

- **Generates C# classes for business layer logic:**
    - Manages interactions with data access classes
    - Enforces business rules and validation
      
- **Generates stored procedures:**
    -New feature: The code generator now generates stored procedures for the selected tables

## Usage:

1. Run the Code Generator:
    - Open the frmCodeGenerator form in a C# development environment.
2. Select Database and Table:
    - Choose the desired database from the "Databases" dropdown.
    - Select the table for which to generate classes and stored procedures from the "Database Tables" grid.
3. Generate Classes and Stored Procedures:
    - Click the appropriate button to generate classes for the data access layer, business layer, or both, along with the corresponding stored procedures.
4. View Generated Code:
    - The generated code will be displayed in the "Generated Code" textbox.

## Generated Code Structure:

- Data Access Layer Classes:
  - Reside in a separate namespace (e.g., DataAccessLayer).
  - Contain methods for interacting with the database using stored procedures.

- Business Layer Classes:
  - Reside in a separate namespace (e.g., BusinessLayer).
  - Interact with data access classes to implement business logic.

## Additional Notes:

- The generated code utilizes clsDataAccessSettings for database connection details and clsErrorLogger for error logging.
- Consider customizing the generated code further to fit specific project needs, such as modifying the stored procedures or adding additional functionality.
