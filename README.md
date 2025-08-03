# Car Dealership System

A Windows Forms application for managing a car dealership, including car sales, customer management, service bookings, spare parts, and supplier management. The system uses a SQL Server database backend.

## Features

- **User Authentication:** Login system with user type selection (Admin, Salesperson, Customer).
- **Car Sales Management:** Bookings, transactions, and delivery tracking.
- **Customer Management:** Add, view, and manage customer details.
- **Service Management:** Book and track car services, view service history, and manage service invoices.
- **Spare Parts Management:** Track spare parts inventory and suppliers.
- **Supplier Management:** Add, view, and delete suppliers.
- **Employee Management:** Manage salespersons and their details.
- **Database Integration:** All data is stored in a SQL Server database (`dbproj`), with tables for cars, customers, employees, bookings, services, spare parts, suppliers, and transactions.

## Project Structure

- `Form1.cs` - Login form and main entry point.
- `Form2.cs`, `Form3.cs`, ... - Various forms for different modules (customer, service, booking, etc.).
- `Database/dbproj.sql` - SQL script to create and populate the database.
- `Program.cs` - Application entry point.
- `App.config` - Application configuration.
- `Properties/` - Project settings and resources.

## Database Schema

The database includes the following main tables:
- `CarDetails`
- `CustomerDetails`
- `EmployeeDetails`
- `BookingDetails`
- `BookingTranscaction`
- `Service`
- `ServiceTicket`
- `ServiceInvoice`
- `SparePartsDetails`
- `SupplierDetails`

Refer to `Database/dbproj.sql` for full schema and sample data.

## Getting Started

1. **Database Setup:**
   - Restore or run the SQL script in `Database/dbproj.sql` on your SQL Server instance.

2. **Configure Connection String:**
   - Update the connection strings in the code (e.g., `Form1.cs`, `Form12.cs`, etc.) to match your SQL Server instance.

3. **Build and Run:**
   - Open the solution (`DatabaseProject.sln`) in Visual Studio.
   - Build and run the project.

## Requirements

- .NET Framework 4.7.2 or later
- SQL Server (any recent version)
- Visual Studio (for building and running the WinForms app)
