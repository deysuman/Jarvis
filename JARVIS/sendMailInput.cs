using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARVIS
{
    public partial class sendMailInput : Form
    {
        public sendMailInput()
        {
            InitializeComponent();
            sendToInput.Items.Clear();
            messageInput.Clear();
            attachmentsList.Items.Clear();
        }

        public string getMessage()
        {
            string message = messageInput.Text;
            return message;
        }

        public string subject()
        {
            string subject = subjectInput.Text;
            return subject;
        }

        public string[] sendTo()
        {
            string[] reciepients = new string[20];
            int index = 0;

            //Add all the e-mail addresses for the message to be sent to
            foreach (string reciepient in sendToInput.Items)
            {
                if (!reciepient.Equals(String.Empty))
                {
                    reciepients[index] = reciepient;
                }
                index++;
                Console.WriteLine(reciepient);
            }
            return reciepients;
        }

        private void sendMail_Load(object sender, EventArgs e)
        {
            sendToInput.Items.Clear();
        }

        private void addToList_Click(object sender, EventArgs e)
        {
            if (sendToInput.Items.Count != 20)
            {
                sendToInput.Items.Add(recipientInput.Text);
            }
            else
            {
                Speak informToMany = new Speak();
            }
            Console.WriteLine(sendToInput.Items.Count.ToString());
        }

        public string[] getAttachments()
        {
            string[] attachments = new string[20];
            int index = 0;

            //Add all the attachment paths
            foreach (string attachment in attachmentsList.Items)
            {
                if (!attachment.Equals(String.Empty))
                {
                    attachments[index] = attachment;
                }
                index++;
            }
            return attachments;      
        }

        private void addAttachments_Click(object sender, EventArgs e)
        {
            //Open up a window to select a file to attach
            OpenFileDialog attachments = new OpenFileDialog();
            attachments.Title = "Select a file to attach";
            attachments.ShowDialog();
            if (attachments.FileName.Length > 0)
            {
                attachmentsList.Items.Add(attachments.FileName);
            }
        }
    }
}
