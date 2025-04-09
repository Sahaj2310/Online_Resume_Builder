# Online Resume Builder

A web-based application that allows users to create, manage, and download resumes in multiple formats. It provides several customizable templates, a rich text editor, and features like live preview, resume analytics, and AI-powered suggestions.

## Installation

### Prerequisites

Before running the project, ensure you have the following installed:

- [.NET 6 or later](https://dotnet.microsoft.com/download/dotnet) (for ASP.NET Core applications)
- [SQLite](https://www.sqlite.org/download.html) (for database)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) (optional)

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/online-resume-builder.git
   cd online-resume-builder

2. Install the necessary dependencies:
   ```bash
   dotnet restore

3. Configure the database connection in appsettings.json:
   ```bash
   {
  "ConnectionStrings": {
    "ResumeContext": "Data Source=your_database_file.db"
     }
    }

