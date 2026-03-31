# Employee Account Generator

A clean architecture C# Console Application built on **.NET 10.0** demonstrating the practical application of **SOLID design principles**, primarily the **Open/Closed Principle (OCP)**, **Dependency Inversion**, and the **Strategy Pattern**.

## Project Overview

The **Employee Account Generator** simulates the process of creating various corporate accounts (Developer, Designer, Executive, Manager, Tester) based on an applicant's prospective role. 

The architecture ensures that introducing new employee roles does not require modifying the existing account generation logic or the runtime execution loop. This adherence to object-oriented best practices produces highly maintainable and decoupled code.

## Architecture & Design Principles

This solution is divided into two primary projects:
- **EmployeeAccountGenerator.Core**: A class library containing the domain entities, interfaces, concrete applicant definitions, and the account generation implementations.
- **EmployeeAccountGenerator.ConsoleUI**: The console-based presentation layer that initializes a list of applicants and processes them through the polymorphic generators.

### Applied Object-Oriented Concepts:
- **Single Responsibility Principle (SRP)**: Each specific account generator class (e.g., `DeveloperAccountGenerator`, `ManagerAccountGenerator`) is exclusively responsible for containing the logic needed to create that specific account type. 
- **Open/Closed Principle (OCP)**: The system is closed for modification but open for extension. To introduce a new role (e.g., Administrator), a developer simply creates new `AdministratorApplicant` and `AdministratorAccountGenerator` classes. The `Program.cs` processing logic requires exactly zero changes to support it.
- **Dependency Inversion Principle (DIP)**: Components depend on abstraction (`IAccountGenerator`, `IApplicant`) rather than concrete classes. The specific generation strategy is abstracted away from the caller. 

## Repository Structure

```text
EmployeeAccountGenerator
│
├── EmployeeAccountGenerator.ConsoleUI/
│   ├── Program.cs             # Entry point, initializes applicants and displays results
│   └── *.csproj               
│
├── EmployeeAccountGenerator.Core/
│   ├── AccountGenerators/     # Role-specific generators (Strategy implementations)
│   │   ├── IAccountGenerator.cs
│   │   ├── DeveloperAccountGenerator.cs
│   │   └── ...
│   ├── Applicants/            # Applicant domain models
│   │   ├── IApplicant.cs
│   │   ├── DeveloperApplicant.cs
│   │   └── ...
│   ├── Account.cs             # Resulting Account data structure
│   ├── EmployeeRole.cs        # Enum defining employee roles
│   └── *.csproj               
```

## Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) installed on your environment.
- Any capable IDE like Visual Studio, JetBrains Rider, or VS Code.

### Execution

1. Clone this repository to your local machine.
   ```bash
   git clone employee-account-generator
   ```
2. Navigate to the UI project directory:
   ```bash
   cd EmployeeAccountGenerator.ConsoleUI
   ```
3. Run the application via the .NET CLI:
   ```bash
   dotnet run
   ```

### Example Console Output
```text
Ada Lovelace: ada.lovelace@developer.com
Role: Developer

Alan Turing: alan.turing@developer.com
Role: Developer

Grace Hopper: grace.hopper@developer.com
Role: Developer

Margaret Hamilton: margaret.hamilton@designer.com
Role: Designer

Charles Babbage: charles.babbage@executive.com
Role: Executive

Claude Shannon: claude.shannon@manager.com
Role: Manager

Katherine Johnson: katherine.johnson@tester.com
Role: Tester
...
```

## License
This project is licensed under standard terms. See the [LICENSE.txt](./LICENSE.txt) file for more information.