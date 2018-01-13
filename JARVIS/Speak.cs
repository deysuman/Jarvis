using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace JARVIS
{
    public class Speak
    {
        SpeechSynthesizer JARVIS = new SpeechSynthesizer();
        public void noOptionAvailable()
        {
            JARVIS.Speak("There is currently no command for this");
        }

        //Say opening file as well
        public void askForFilename()
        {
            JARVIS.Speak("What file are you looking for?");
        }

        public void sayAppointment(string[] whatToSay)
        {
            //whatToSay[0] = index
            //whatToSay[1] = Subject
            //whatToSay[2] = Date       
            string[] date = whatToSay[2].Split('/');
            string newDate = date[1] + "/" + date[0];
            //whatToSay[3] = Time
            string[] time = whatToSay[3].Split(':');
            string newTime = time[0] + ":" + time[1];
            //whatToSay[4] = Location

            PromptBuilder appointmentBuilder = new PromptBuilder();
            appointmentBuilder.StartVoice("IVONA 2 Brian");
            appointmentBuilder.AppendText("Appointment " + whatToSay[0]);
            appointmentBuilder.AppendText(", subject is: " + whatToSay[1]);
            appointmentBuilder.AppendSsmlMarkup(", on <say-as interpret-as=\"date_md\">" + newDate + "</say-as>");
            appointmentBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"time\">" + newTime + "</say-as>");
            appointmentBuilder.AppendText(", at " + whatToSay[4]);
            appointmentBuilder.EndVoice();

            JARVIS.Speak(appointmentBuilder);
            appointmentBuilder.ClearContent();
        }

        public void sayAppointmentError()
        {
            JARVIS.Speak("No Appointments found for the next 7 days.");
        }

        public void searchFor()
        {
            JARVIS.Speak("What do you want to search for?");
        }

        public void currentTime()
        {
            string timeString = DateTime.Now.ToShortTimeString();
            PromptBuilder timeBuilder = new PromptBuilder();
            timeBuilder.StartVoice("IVONA 2 Brian");
            timeBuilder.AppendText("The time is: ");
            timeBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"time\">" + timeString + "</say-as>");
            timeBuilder.EndVoice();

            JARVIS.Speak(timeBuilder);
        }

        public void currentDate()
        {
            string dateString = DateTime.Now.ToShortDateString();
            PromptBuilder dateBuilder = new PromptBuilder();
            dateBuilder.StartVoice("IVONA 2 Brian");
            dateBuilder.AppendText("The date is: ");
            dateBuilder.AppendSsmlMarkup(" <say-as interpret-as=\"date_md\">" + dateString + "</say-as>");
            dateBuilder.EndVoice();

            JARVIS.Speak(dateBuilder);
        }

        public void hello()
        {
            DateTime timeNow = DateTime.Now;
            string username = Environment.UserName;
            if (timeNow.Hour >= 0 && timeNow.Hour < 12)
            {
                JARVIS.Speak("Good morning " + username);
            }
            else if (timeNow.Hour >= 12 && timeNow.Hour < 18)
            {
                JARVIS.Speak("Good afternoon " + username);
            }
            else if (timeNow.Hour >= 18 && timeNow.Hour < 24)
            {
                JARVIS.Speak("Good evening " + username);
            }
        }

        public void sayForecast(string[] conditions)
        {
            JARVIS.Speak("Tomorrows forecast is " + conditions[5] + " with highs of " + conditions[6] + " and lows of " + conditions[7]);
        }

        public void sayWeather(string[] conditions)
        {
            PromptBuilder builder = new PromptBuilder();
            builder.StartVoice("IVONA 2 Brian");
            builder.AppendText("The weather in hale sowen is " + conditions[0] + " at " + conditions[1] + " degrees. There is a wind speed of " + conditions[2] + " miles per hour with highs of " + conditions[3] + " and lows of " + conditions[4]);
            builder.EndVoice();
            JARVIS.Speak(builder);
        }

        public void loading()
        {
            JARVIS.Speak("Loading, Please hold");
        }

        int originalVolume = 50;
        public void jarvisMute(bool mute)
        {
            if (mute)
            {
                JARVIS.Speak("Muting");
                originalVolume = JARVIS.Volume;
                JARVIS.Volume = 0;
            }
            else
            {
                JARVIS.Volume = originalVolume;
                JARVIS.Speak("Volume levels restored");
            }
        }


        public void jarvisVol(bool sh)
        {
            int volume = JARVIS.Volume;
            if (sh)
            {
                if (JARVIS.Volume == 0 || (JARVIS.Volume - 20) < 0)
                {
                    JARVIS.Volume = 20;
                    JARVIS.Speak("Muted");
                    JARVIS.Volume = 0;
                }
                else
                {
                    JARVIS.Volume -= 20;
                    JARVIS.Speak("Volume decreased");
                }
            }
            else
            {
                if (JARVIS.Volume == 100 || (JARVIS.Volume + 20) > 100)
                {
                    JARVIS.Speak("I cannot get any louder");
                }
                else
                {
                    JARVIS.Volume += 20;
                    JARVIS.Speak("Volume increased");
                }
            }
        }

        public void tooManyRecipients()
        {
            JARVIS.Speak("Maximum number of recipients added");
        }

        public void closing()
        {
            JARVIS.SpeakAsyncCancelAll();
            JARVIS.Dispose();
        }

    }
}
