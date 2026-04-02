# PetRec

PetRec is a personal project focused on making pet care easier to organize in everyday life. It is a **.NET MAUI** mobile app that aims to bring together important pet-related information such as pet profiles, calendar reminders, food records, and photos of documents like the EU pet passport.

## Why I built it

A lot of pet-related information ends up scattered across photos, notes, chats, paper documents, and calendar apps. I wanted to explore how a mobile app could centralize that information into one place and make it easier to manage.

PetRec is also a project through which I am practicing software architecture, separation of concerns, and building maintainable applications with a layered structure.

## Project vision

The long-term goal of PetRec is to become a small personal companion app for pet owners, where they can:

- Keep profiles for one or more pets
- Store useful pet-related information in one place
- Save photos of important documents such as the EU pet passport
- Track food-related entries
- Add calendar events and reminders
- Expand the app with additional pet care records over time

## Current state

PetRec is still a **work in progress**, but the current version already includes the foundations of the app:

- A **.NET MAUI** mobile application
- A layered project structure
- SQLite-backed persistence
- Pet records
- Calendar records
- Basic UI pages and view models
- GitHub Actions CI setup for build and test

At the moment, the project is more focused on establishing a clean structure and experimenting with the main flows than on polishing the final user experience.

## Architecture

One of the main goals of this project is to keep the codebase easy to grow as new pet-related features are added.

### Core

The `PetRec.Core` project contains the shared abstractions and contracts used across the application.

Examples include:

- `IPet`
- `ICalendarEntry`
- `IRepository<T>`
- `IDatabase`
- `IDatabaseRecord`

### Infrastructure

The infrastructure layer handles persistence concerns and data access.

Current examples include:

- `PetRecord`
- `CalendarRecord`
- Repository implementations
- SQLite-oriented storage classes
- App data path support

### Mobile

The MAUI app contains the UI and app startup logic, including:

- `AppShell`
- `MainPage`
- `CalendarPage`
- View models
- Dependency injection setup in `MauiProgram`

## Tech stack

- **C#**
- **.NET 10**
- **.NET MAUI**
- **SQLite**
- **XAML**
- **GitHub Actions**

## Implemented so far

Based on the current code, the app already supports:

- Listing pets
- Adding pet entries
- Displaying calendar entries
- Adding calendar entries
- Navigating between pages using Shell
- Persisting data through repository abstractions

## Planned next steps

The project is still evolving, and the next improvements will likely focus on features that are closer to the original idea behind the app, such as:

- Food entry support
- Better pet profile details
- Linking calendar entries more clearly to the selected pet
- Photo support for pet-related documents
- Better editing and deletion flows
- Improved UI and overall app experience

## Project structure

```text
PetRec
├─ PetRec.Core
├─ PetRec.Infrastructure
└─ PetRec.Mobile
```

## Running the project

### Prerequisites

To work with the project locally, you will need:

- .NET 10 SDK
- .NET MAUI workload
- Visual Studio with MAUI support

### Clone the repository

```bash
git clone https://github.com/sarabadjieva/PetRec.git
cd PetRec
```

### Restore packages

```bash
dotnet restore
```

### Build the solution

```bash
dotnet build
```

### Build the MAUI Android app

```bash
dotnet build PetRec.Mobile/PetRec.Mobile.csproj -f net10.0-android
```

## CI

The project includes a GitHub Actions workflow that:

- Sets up .NET 10
- Installs the MAUI Android workload
- Restores packages
- Builds shared projects
- Builds the MAUI Android target
- Runs tests

## What this project represents

For me, PetRec is both a practical app idea and a learning project. It reflects my interest in building software with a clean structure, thinking about extensibility early, and designing applications around real user needs rather than just isolated features.

## License

This project currently does not include a license. Add one if you plan to distribute it as an open-source project.
