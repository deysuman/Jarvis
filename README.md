# Jarvis
Jarvis is my personal assistant. 

Replicating J.A.R.V.I.S from the Iron Man movies.

Created using C# to develop my understanding of the language and to use the Text to Speech and Speech to Text libraries.

Interacts with Microsoft Outlook to open the application, check calender and read aloud appointments, send emails and get J.A.R.V.I.S to read received e-mails aloud.

Also uses yahoo's weather api to get current weather and tomorrow's forecast. To get this for your local area change the WOEID in source code within the Weather class. The WOEID for your area can be found here http://woeid.rosselliot.co.nz 

You can also search for files locally, however the initial search path will need to be changed in the source code for your local area.

Says current date and time aloud.

Can google search.

Also interacts with ITunes allowing you to say commands such as Play, Next, Previous, Pause, Volume Up, Volume Down and Shuffle.

By saying 'Open Chrome' a Google chrome browser will launch and on th flip side saying 'Close Chrome' will cancel all current Google Chrome processes.
This also works for ITunes and Outlook.
