# Flight Centre - Flight Finder application

Description:

This ASP.NET Web API project implements a simple Flight Finder API that allows clients to count instances of the word "flight" in a supplied string.


Requirements:
* .NET Framework (version 8.0)
* Visual Studio 



Installation:
* Clone this repository to your local machine.
* Open the solution file (FlightFinderAPI.sln) in Visual Studio.
* Build the solution to restore packages and dependencies.


Usage:
* To Run the API and the Web project together
* Startup project - Set the "Start multiple prjects" option by right clicking the solution .
* Run the project (press F5 or click the Start button in Visual Studio).



Project Structure:
This solution contains 2 projects:

* FlightFinder.API --> Rest API
* FlightFinder.Web  --> UI


How would I improve this App ?

* By configuring the API urls in app settings and injecting them through configuration
* Using UI components like like Telerik UI instead of using Javascript or I would implement SPA (single PAge Application) using angular depending on the functional requirements
* Provide security by authentication and authorization (Azure AD as Identity provider).
* Design the app with clean architecture which offers easy maintenance, separation of concern, testing, extensibility and scalability of the application.
* Implement logging to monitor the application behavior and error (logger, AppInsights).
