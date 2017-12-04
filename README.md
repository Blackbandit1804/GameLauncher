# GameLauncher
An Open Source game launcher, Written using Visual Studio 2017 and .net framework.
This application was updated and upgraded over time. Development will continue as open source.

To get notifications on when this repository is updated, join my discord server and use the #github channel: https://discord.gg/JJXWAnw

# Section 1 - Setup
This application requires you have the following software installed and available to you.
* Visual Studio 2017 - If it helps, this was built in Visual Studio Community 2017.
* .net Framework 4.6.1 or higher. Lower versions will not work.
* Windows 7 or above.

This application requires you install the following NuGet Packages and Dependencies in vb.net: 
* MaterialDesignColors
* MaterialDesignThemes
* MaterialSkin.Updated
* Microsoft.Toolkit.Uwp.Notifications
* ZipForge.NET
* MySql Connector

All above dependencies should be installed to their default installation locations for easy loading of dependencies. If installed elsewhere, you will need to load the dependencies manually.

(Note: Some dependencies may not be listed here. If you find an unlisted dependency, please create an Issue so I can add it.)

To set up the application for editing, clone the repository via Git GUI or Command Line. Open the .sln file in Visual Studio.

# Section 2 - Settings
All settings, except for a select few, are stored in Form1.vb at the top of the code. More settings will be moved to this location later.
Setting locations are listed below.

-- Form1.vb contains: 
* DownloadURL - This is the link to the latest update. It MUST be a ZIP file, with no encrption or password.
* remoteBuildFile - Link to a TXT file containing the latest version number of the application which this launcher manages.
* ThisLocation - The location of the launcher set as a variable. You shouldn't need to change this, unless you wish to store and install applications to another folder, though doing this is untested, and may require extra work from you on the code to make compatible.
* DownloadFileName - Choose a name here for the file you download. This can be anything, and doesn't need to be the same as the one linked at DownloadURL.
* allowSignUp - Set to true or false. Allows users to sign up through the launcher. (TODO)
* sideMenuIsHidden - Choose to hide the sidebar on startup

-- login.vb
(Note that this is left over from original versions of the software where I just haven't moved functions yet. The dialog in this form is no longer used.)

* server - The url/ip to the database server. Must be mysql. MariaDB will work as well.
* user - Username of the user to use to log into the database.
* passwd - Password to the user who is used to log into the database.
* db - The actual database to use upon login for usernames and passwords for the launcher.

Note: Passwords are encrypted in SHA-256 encryption from the client and sent to the server. SHA-256 hashes cannot be used to login, the client hashes it then checks that it matches on the server.

# Section 3 - Compiling
To compile, ensure all requrements are met (see Section 1) and click Build -> Debug OR Build -> Publish.

# Section 4 - Licence
This applications licence is located at the LICENCE section of this repository. Please read it carefully.

# Section 5 - Disclaimer
I am not responsible for issues, errors, crashes, etc, which occur while this application is in use, as mentioned in the MIT Licence.
