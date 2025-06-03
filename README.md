# Store Management System

A desktop application in C# for managing a store, including customer, product, and sales management.  
Built with .NET 8, structured into 5 main layers (UI, BL, DAL, Tools, Tests) and implementing design patterns.


## Technologies

- C# / .NET 8
- WinForms
- 3-tier architecture: UI, Business Logic (BL), Data Access Layer (DAL)
- Design Patterns for clean, maintainable code
- Separate testing projects for DAL and BL layers
  

## Project Structure

```
├── UI/ # WinForms user interface
│ ├── Form1.cs # Main form
│ ├── Option.cs # Menu form
│ └── ClientManager.cs # Customer management

├── BL/ # Business Logic
│ ├── BIApi/ # Logic interfaces
│ ├── BLImplementation/ # Logic implementations
│ └── BO/ # Business objects

├── DalFacade/ # General DAL interface
│ ├── DalApi/ # Data access interfaces
│ ├── DO/ # Data objects
│ └── DalList/ # Basic list implementations

├── DalXml/ # DAL implementation using XML files
│ ├── productImplementation.cs
│ ├── clientImplementation.cs
│ ├── saleImplementation.cs
│ └── DalXml.cs

├── Tools/ # General utilities

├── DalTest/ # DAL unit tests
├── BlTest/ # BL unit tests

└── xml/ # Data files in XML format
```


## Screenshots

![Selection Menu ](https://github.com/user-attachments/assets/e2e62770-1814-45bf-be29-23daaac47e39)
![Add Customer Screen](https://github.com/user-attachments/assets/9e7ed109-885b-4d8f-a323-1017092fec13)
![Delete Promotion Screen](https://github.com/user-attachments/assets/6ab19659-b339-43bf-8faf-4f2bc7581b85)
![Order Start - Customer Verification](https://github.com/user-attachments/assets/958c4ab3-fdd2-4f29-a1a4-b73552008d2c)
![Order Processing Screen](https://github.com/user-attachments/assets/70676850-d0ac-4681-931b-19e5e8753ef5)
![Product Display Screen](https://github.com/user-attachments/assets/6724e647-5644-479f-a093-18f4b70bf6ac)


## About

This project was developed as an educational demonstration of a multi-layered management system focusing on clean code principles and architectural design.
