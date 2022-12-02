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
    public partial class AddNewTask : Form
    {
        //creating Task object that the user will be working with
        private ToDue.Models.Task t = new Models.Task();
        private ToDue.Models.TaskList tasks = new Models.TaskList();

        public AddNewTask(ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            anchorWindow();

            tasks = tasksPassedIn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //updating the Task object
            t.TaskName = txtTaskName.Text;
            t.DueDate = txtDueDate.Text;
            t.Priority = txtPriority.Text;
            t.Subject = txtSubject.Text;
            t.Summary = txtSummary.Text;
            t.XDetails = txtXDetails.Text;

            //ADD TO TASKLIST  
            tasks.addTask(t);

            //going to TaskDetails with updated information for preview
            goToTaskDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //returning to HomePage without updating Task or TaskList
            returnToHomePage();
        }

        private void goToTaskDetails()
        {
            //moving from AddNewTask to TaskDetails
            TaskDetails newForm = new TaskDetails(t, tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void returnToHomePage()
        {
            //moving from AddNewTask back to the HomePage 
            HomePage newForm = new HomePage(tasks);
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
