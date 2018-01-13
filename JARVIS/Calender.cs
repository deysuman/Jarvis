using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;
using System.IO;
using System.Reflection;
using System.Threading;

namespace JARVIS
{
    public class Calender
    {
        Speak jarvis;
        Application outLookApp = new Application();
        public void calenderAppointments()
        {
            Console.WriteLine("Checking Calender");
            jarvis = new Speak();
            try
            {
                DateTime start = DateTime.Now;
                DateTime end = start.AddDays(7);
                int index = 1;
                bool appointmentFound = false;

                NameSpace outlookNameSpace = outLookApp.GetNamespace("MAPI");
                MAPIFolder calender = outlookNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);
                Items calenderItems = getAppointmentsInRange(calender, start, end);
                if (calenderItems != null)
                {
                    Console.WriteLine("Appointments Found");
                    //set bool here change in foreach ask after foreach for change
                    foreach (AppointmentItem appointment in calenderItems)
                    {
                        Console.WriteLine("Appointment " + index.ToString());
                        string[] appointmentContent = { index.ToString(), appointment.Subject, appointment.Start.Date.ToString("d"), appointment.Start.TimeOfDay.ToString(), appointment.Location };
                        Thread sayAppointment = new Thread(new ThreadStart(() => jarvis.sayAppointment(appointmentContent)));
                        sayAppointment.IsBackground = true;
                        sayAppointment.Start();
                        Thread.Sleep(8000);
                        index++;
                        appointmentFound = true;
                    }

                    if (!appointmentFound)
                    {
                        Console.WriteLine("Nothing found");
                        noAppointments();
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found");
                    noAppointments();

                }
            }
            catch
            {
                noAppointments();
            }

        }

        public Items getAppointmentsInRange(MAPIFolder folder, DateTime start, DateTime end)
        {
            string filter = "[Start] >= '" + start.ToString("g") + "' AND [End] <= '" + end.ToString("g") + "'";

            try
            {
                Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Items restictItems = calItems.Restrict(filter);
                if (restictItems.Count > 0)
                {
                    return restictItems;
                }
                else
                {
                    return null;
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        private void noAppointments()
        {
            Thread noAppointment = new Thread(new ThreadStart(() => jarvis.sayAppointmentError()));
            noAppointment.IsBackground = true;
            noAppointment.Start();
        }
    }
}
