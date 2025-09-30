# Dance Competition App

This is a simple **C# Windows Forms** application developed as part of my university coursework.

## Features

### User Mode
- List all announced dance competitions.
- Register for a competition by providing:
  - Competitor name (individual or team)
  - Performance name and style
  - Music title, artist, and duration
  - Registration date
- View competitions where registration has been accepted.
- List performances and their average scores.
- After the competition, view scores and winners for each competition.

### Admin Mode
- Create, edit, or cancel competitions with details:
  - Name, date, location
  - Opening and closing registration times
  - Competition duration
- Approve or reject registrations; when approving, assign a start time.
- Assign scores to performances.
- Display a bar chart of the number of registrations per month for competitions.
- View pending registrations for a specific competition.
- Export approved performances for a competition to XML for judges (available only after registration closes).
- Display a bar chart of points scored by competitors in a competition.

## Database
The project uses a **SQL Server** database to store competitors and results.  
The database file is **not included** in this repository, but it is required to run the application.

## Usage
1. Open the `tancverseny_applikacio.sln` file in Visual Studio.
2. Run the project by pressing the `Start` button.

## Technologies
- C# 
- Windows Forms
- Visual Studio
