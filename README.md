This is Assignment 2 for my WEB452 Course at St. Clair College

Over the course of several weeks, I have worked on creating a Database for a book store and using ASP MVC, have created it.
The following code is everything I have done over the last few weeks, and My Read Me file can be found under the MichaelsBookStore folder

Below is also a copy of all the Data I added to my ReadMe.txt

-----------------------------------------------------------------------------------------------
Author Name: Michael MacNeill
Student #:   0237866

Nov 1st

9:30 I have done the following to my file so far

Created the application,
Added a bootswatch
customized the appearance of my webpage
added additional scripts
created this Readme file

10:10 Moved the Data Folder to the .DataAccess Project
      Having Issues installing the Microsoft.EntityFrameworkCore.Relational & Core.SqlServer

10:22 Restarting my project

10:25 commenting out the SSL line in Launch.json and the optional Parameters in the Startup.cs

10:30 deleted and added the bootswatched bootstrap.css file, changed the filepath in Layout.cshtml
also changed some of the design by changing the bg to primary and removing dark text

Injected additional scripts to be used

10:38 Created 3 new projects named:
        MichaelsBooks.DataAccess
        MichaelsBooks.Models
        MichaelsBooks.Utility

10:39 I have returned to the point Where I believe I messed up the last project

10:45 I have Installed Core.Relational and Core.SqlServer successfully

10:49 I have also successfully installed Identity.EntityFrameworkCore

11:00 working on fixing two refference errors
    Namespace does not exist errors in _Layout.cshtml and HomeController.cs

11:05 fixed 1 error, but recieved a new one
    Fixed: error in _layout.cshtml
    New: package downgrade for EntityFrameworkCore.SqlServer from 5.0.11 to 3.1.16

11:35 Fixed the Package downgrade error


Nov 2nd

20:00 Reopened the project and began debugging to get projects to run for up to slide 35 of P1

20:10 fixed a package mismatch error

20:25 Managed to get my Project to run for up to Slide 35 of P1


Nov 14th

Yes I Know I started this very late, I've had a lot of personal Issues going on at home and couldn't find the time to work on anything, Including this proejct

17:30 I rebooted the Project and Began Catching up to everyone else

17:35 I had issues Finding the Customers and Admin areas previously, so I Manually deleted them and restarted those steps

17:57 Added to my ReadMe the work I Have done so far, as well as a comment before it, I also have just finished P1 completely and it runs

------- P2 -------

18:00 Taking a short break to mentally recharge and Finish all of P2 by the end of Tonight, also Starting up my Spotify Gym playlist to get me hyped
    If You're curious, I'll leave the link here: https://open.spotify.com/playlist/50Kdj1XOTODBbMpNjOZ9MD?si=F33zscj4T9-NVnsrIBVGVA&utm_source=copy-link
        It's much smaller than my Main playlist, However I'm looking to keep myself Energized, and don't wanna get distracted by skipping songs and losing track of my thought process

18:25 Finished Taking my Break and I am now ready to Progress with the Rest of what is due for Tomorrow, Nov 15th

18:27 Had an issue where I was trying to upload the Migration to the wrong section, this was a fairly simple correction by changing from MichaelsBookStore to MichaelsBooks.DataAccess

18:29 Migration File name  20221114232924_AddingDefaultIdentityMigration.cs

18:48 Finished the steps for P2.1, I'm making excellent progress so far IMO

19:28 Just got to Slide 7, at the part where is asks to check the Assignment 2 folder, Going to take a small break to eat Dinner, then continue with the rest of the work.

21:07 Took a much longer break than I had origonally intended, but I am ready to finish P.2

22:32 Still working, and everything has been running and working smoothly

22:54 Had an Issue with the AddScoped section, realized I didn't properly publicize the IRepo counterpart and fixed it, I also Finished P2.2 and I'm uploading to Github now

23:00 taking a break after VS19 crashed shortly after uploading to github, Thankfully it uploaded before crashing

23:30 Came back from my break with some coffee ready to finish this

23:52 Finished adding Category Index to Admin area and to the Dropdown, also took the time to properly fix my Dropdown

01:00 I have the functions working and my table loads Data, however my text blends in with the background

01:13 I have finished the assignment save changing the text color

------- P3 -------

Nov 23

17:15 I'm Starting very late again, however this is due to Working Midnights the last 9 days, giving me very little free time between everything, I will do my best to finish everything before 21:00

18:04 Realizing how much of a task this is going to be, even with some shortcuts added to the process

18:17 I Have made it without any Major errors to adding Product, The errors I did encounter were as follows:
    My table was not showing the correct table, This was because I duplicated the Link to the category folder through the dropdown rather than the CoverType folder
    My table did not load data, this was due to not correctly naming the Folder in the URL in the JS file

Migration file for AddProductToDb is 20221124012517_AddProductToDb.cs

18:55 I have Finished Part 3 Section 1, I had a Typo issue at the end where I misspelt IProductRepository, which wouldn't allow it to call the other locations

19:23 I have managed to Finish up to Part 3 Section 2

Nov 30th

22:44 I am begining to Finish up the last of my project, I should be done in roughly 30ish mins

23:45 I have finished all of my work, However I have a weird bug where i cannot view the tables on my personal desktop, but it works on any other device

23:53 I can't figure out why i cannot get my table to work on the desktop, But I can test my work on my laptop so i will just continue P5 on my laptop

Dec 9th

10:09 Adding the finishing Details to my assignment, and then submitting
 
11:10 After spending about an hour working on it, I could not figure out how to get the Images to load, only the URL to them in the Database
    The Changes I made were;
        Adding the Images Table Row
        Added to the js file
