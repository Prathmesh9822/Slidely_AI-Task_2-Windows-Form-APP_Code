# SlidelyAI_Prathmesh_Gaikwad_Task-2
**SlidelyAI Task-2 creating a windows from in visual studio and this is it's Windows Application or Form code which is done in the Visual Code using VB language as per stated. as well as all the basic functionality are working along with the connections to the database or in this case the backend.**

# Windows App for Submissions

## Overview
This is a Windows Forms application built with Visual Basic .NET that allows users to create and view submissions. The application interacts with a backend server to fetch and submit data. The application includes functionality to start, pause, and resume a stopwatch, and shortcuts for ease of use.

## Features
- **Create New Submissions**: Users can enter their name, email, phone, GitHub link, and elapsed stopwatch time.
- **View Submissions**: Users can view the list of submissions fetched from the backend server.
- **Stopwatch Functionality**: Users can start, pause, and resume a stopwatch, with the elapsed time displayed in a formatted manner.
- **Keyboard Shortcuts**:
  - `Ctrl + S`: Submit a new submission.
  - `Ctrl + T`: Toggle the stopwatch.
  - `Ctrl + P`: View the previous submission.
  - `Ctrl + N`: View the next submission.

## Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.8 or later
- Newtonsoft.Json library (install via NuGet)

## Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/your-repository.git
2. **Open the Solution**:
Open the cloned repository in Visual Studio by opening the .sln file.
3. **Restore NuGet Packages**:
In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution and restore any missing packages.
**Running the Application**
1. Start the Backend Server:
Ensure your backend server is running at http://localhost:3000/.
2. Run the Application:
Press F5 in Visual Studio to build and run the application.
** Usage **
* Creating a Submission:
* Open the application and click Create Submission.
* Fill in the form with your details and click Start to begin the stopwatch.
* Click Pause to pause the stopwatch and Resume to resume it.
* Once done, press Ctrl + S or click Submit to save your submission.
** Viewing Submissions **:
* Open the application and click View Submissions.
* Use the Next and Previous buttons or the keyboard shortcuts (Ctrl + N and Ctrl + P) to navigate through the submissions.
