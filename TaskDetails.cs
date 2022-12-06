using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDue
{
    public partial class TaskDetails : Form
    {
        private ToDue.Models.Task t = new Models.Task();
        private ToDue.Models.TaskList tasks = new Models.TaskList();
        public TaskDetails(ToDue.Models.Task passedIn, ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            t = passedIn;
            tasks = tasksPassedIn;
            loadInformation();
            anchorWindow();
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            t.IsComplete = !t.IsComplete;
            returnToHomePage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saves changes before returning back to HomePage
            updateInformation();
            returnToHomePage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //returns to HomePage without saving any changes
            returnToHomePage();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //goes to Delete page
            updateInformation();
            goToDeletePage();
        }

        private void loadInformation()
        {
            txtTaskName.Text = t.TaskName;
            txtDueDate.Text = t.DueDate;
            txtPriority.Text = t.Priority;
            txtSubject.Text = t.Subject;
            txtSummary.Text = t.Summary;
            txtXDetails.Text = t.XDetails;
            
            //changing the text of the mark (un)complete button
            if (t.IsComplete == false)
            {
                btnMarkComplete.Text = "Mark Complete";
            }
            else
            {
                btnMarkComplete.Text = "Mark Un-Complete";
            }
        }
        private void updateInformation()
        {
            t.TaskName = txtTaskName.Text;
            t.DueDate = txtDueDate.Text;
            t.Priority = txtPriority.Text;
            t.Subject = txtSubject.Text;
            t.Summary = txtSummary.Text;
            t.XDetails = txtXDetails.Text;
        }
        private void returnToHomePage()
        {
            //moving from TaskDetails back to the HomePage 
            HomePage newForm = new HomePage(tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void goToDeletePage()
        {
            //moving from TaskDetails to the Delete page
            DeleteTask newForm = new DeleteTask(t, tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void anchorWindow()
        {
            this.CenterToParent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
