using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageServer
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        // declare constants for admin login
        const string ADMIN_NAME = "admin";
        const string ADMIN_PW = "adminPw";




        // update the status strip error message
        private void ShowErrorMessage(string errMess) =>
            sslblErrorMessage.Text = errMess;

        // read the user name box
        private string GetUserName()
        {
            // return the user name if one was found
            return GetTextValue(tbUserName, "please enter a user name");

        }

        // read the password box
        private string GetUserPw()
        {
            // return the user name if one was found
            return GetTextValue(tbUserPassword, "please enter a password");

        }

        // clear the User text boxes
        private void ClearUserTextBoxes()
        {
            // clear the text boxes
            tbUserName.Clear();
            tbUserPassword.Clear();

        }

        // read and validate a text box 
        private string GetTextValue(TextBox sourceBox, string errorMessage)
        {
            // declare local variables
            string NewName = string.Empty;

            // get the value from the text box
            NewName = sourceBox.Text;

            // test that there is a value
            // throw an exception if no name is found
            if (string.IsNullOrWhiteSpace(NewName))
                throw new Exception(errorMessage);

            // return the user name if one was found
            return NewName;

        }

        // clear the message received box
        private void ClearMessageReceivedList() =>
            lstMessagesReceived.Items.Clear();

        // add a received message to the list
        private void AddMessageReceived(string message) =>
            lstMessagesReceived.Items.Add(message);

        // clear the message send box
        private void ClearMessageSendBox() =>
            tbSendMessage.Clear();

        // get the message to send
        private string GetSendMessage()
        {
            // return the user name if one was found
            return GetTextValue(tbSendMessage, "please enter a message");

        }

        // get the name of the pipe to use
        private string GetPipeName()
        {
            // return the user name if one was found
            return GetTextValue(tbPipeName, "please enter a pipe name");

        }

        // process a login attempt
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // declare local variables
            string ClientName = string.Empty;
            string ClientPw = string.Empty;

            // try to get the values from the textboxes
            try
            {
                ClientName = GetUserName();
                ClientPw = GetUserPw();

                // attempt to login
                // Login(ClientName, ClientPw);

                // clear the text boxes
                ClearUserTextBoxes();

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);

            }

        }

        // process a log off request
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            // declare local variables
            string ClientName = string.Empty;

            // try to get the values from the textboxes
            try
            {
                ClientName = GetUserName();

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);

            }

            // attempt to log out
            // Logout(ClientName);

            // clear the text boxes
            ClearUserTextBoxes();

        }


        // process a new client creation
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            // declare local variables
            string ClientName = string.Empty;
            string ClientPw = string.Empty;

            // try to get the values from the textboxes
            try
            {
                ClientName = GetUserName();
                ClientPw = GetUserPw();
                // create the user
                // CreateNewClient(ClientName, ClientPw);
                // report sucess
                ShowErrorMessage($"user: {ClientName} created");

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);

            }

            // clear the text boxes
            ClearUserTextBoxes();

        }

        // clear any received messages
        private void btnReceivedClear_Click(object sender, EventArgs e)
        {
            ClearMessageReceivedList();

        }

        // clear send text box
        private void btnSendClear_Click(object sender, EventArgs e)
        {
            ClearMessageSendBox();

        }

        // close the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // start the server from the button
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            // StartServerThread();

        }

        // send a message from the send button
        private void btnSendSend_Click(object sender, EventArgs e)
        {
            // SendCurrentMessage();

        }


        // run this when a client record is selected
        private void lstCurrentUsers_Click(object sender, EventArgs e)
        {
            // enable the disconnect button if a client record is selected
            // the user is logged in and the admin record is not selected
            btnDisconnectUser.Enabled = lstCurrentUsers.SelectedIndex >= 0
                && lstCurrentUsers.SelectedItem.ToString().Contains("True")
                && !lstCurrentUsers.SelectedItem.ToString().Contains(ADMIN_NAME);

        }

        // disconnect the selected client using the button
        private void btnDisconnectUser_Click(object sender, EventArgs e)
        {
            // DisconnectSelectedUser();

        }



    }


}
