# 🚜 FarmManagement - .NET Portfolio Project

This project is a farm management platform developed during the **.NET Extended** course at **Karel de Grote Hogeschool (KdG)**. The goal was to build a complex web application that demonstrates core principles of modern .NET development, layered architecture, and professional testing.

## 📖 About the Project

This application allows users to manage multiple farms, focusing on two core pillars:

1. **Animal Management:** Animals are linked to specific farms via a **join entity** (`FarmAnimal`). This allows for tracking how many animals a specific farm has.
2. **Harvest Tracking:** Harvests that give info about what they harvested over the past years.

## 🏗 Architecture & Design

I implemented an **N-Layer Architecture** to ensure a clean Separation of Concerns (SoC) and high maintainability:

* **UI Layer:** Built with ASP.NET Core MVC. I utilized Tag Helpers and Razor views to create a dynamic and user-friendly interface.
* **Business Layer (BL):** Contains the core logic. This layer is decoupled from the database, using services to process data.
* **Domain Layer:** The blueprint of the application, containing all entities including the specialized join entity for the animals.
* **Data Access Layer (DAL):** Uses the Repository Pattern and Entity Framework Core (EF Core) to abstract database communication.

## 🛠 Tech Stack

* **Backend:** .NET 9 / C#
* **Database:** Entity Framework Core with SQLite
* **Security:** ASP.NET Identity (Authentication & Authorization)
* **Testing:** xUnit for unit and integration tests, Moq for mocking the Data Access Layer
* **CI/CD:** GitLab CI pipeline for automated builds and code coverage reporting

## 💡 Key Learnings

Building this project helped me bridge the gap between theory and practice in several technical areas:

### The Join Entity (Many-to-Many)
The most challenging part was the relationship between `Farm` and `Animal`. Instead of a simple collection, I used an explicit join entity. This gave me full control via the **Fluent API** in EF Core, allowing me to store specific data on the relationship itself.

### Security & Validation
I learned how to properly secure an application beyond just a login screen. By integrating **ASP.NET Identity**, I implemented role-based access. I also wrote **Custom Validation Attributes** to enforce business rules, such as ensuring a farm's established year can't be in the future.

### Testing & Mocking
Rather than "coding blind," I adopted a test-driven mindset using **xUnit**. By using **Moq**, I was able to test the Business Layer in isolation without needing a live database. This gave me the confidence to refactor code knowing that the core logic remained solid.

## 🚀 Getting Started

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/](https://github.com/)[your-username]/FarmManagement.git
