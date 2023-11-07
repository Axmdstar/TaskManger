using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Taskcombo.Items.Add("Select One");
            Taskcombo.SelectedItem = "Select One";
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            String UserInput = TaskInput.Text;
            if(TaskInput.Text == "")
            {
                MessageBox.Show(" Please Enter a Task");
                return;
            }
            

            String Selected = Taskcombo.SelectedItem.ToString();
            // Checks if userinput is Found on other list
            bool InFinished = FinishedList.Items.Contains(UserInput);
            bool InPending = PendingList.Items.Contains(UserInput);
            bool InProgress = ProgressList.Items.Contains(UserInput);

            

            switch (Selected)
            {
                case "Finished":
                    if (InFinished) { MessageBox.Show("Already In Finished"); return; }
                    // Remove if user input found on other List
                    if (InProgress) { ProgressList.Items.Remove(UserInput);}
                    if (InPending) {  PendingList.Items.Remove(UserInput);}
                    FinishedList.Items.Add(UserInput);
                    break;

                case "Progress":
                    if (InProgress) { MessageBox.Show("Already In Progress"); return; }
                    if (InPending) {  PendingList.Items.Remove(UserInput);}
                    if (InFinished) { FinishedList.Items.Remove(UserInput); }
                    ProgressList.Items.Add(UserInput);
                    break;

                case "Pending":
                    if (InPending) { MessageBox.Show("Already In Pending"); return; }
                    if (InFinished) { FinishedList.Items.Remove(UserInput); }
                    if (InProgress) { ProgressList.Items.Remove(UserInput); }

                    PendingList.Items.Add(UserInput);
                    break;

                default:
                    MessageBox.Show("Selected a Task Type");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to TaskManager");
        }
    }
}
