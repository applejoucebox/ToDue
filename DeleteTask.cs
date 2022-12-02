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
    public partial class DeleteTask : Form
    {
        private ToDue.Models.Task t = new Models.Task();
        private ToDue.Models.TaskList tasks = new Models.TaskList();
        public DeleteTask(ToDue.Models.Task passedIn, ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            t = passedIn;
            tasks = tasksPassedIn;
            loadInformation();
            anchorWindow();         

            //need to figure out scaling + location of confirmation message
            lblDeleteConfirmation.Text = "Delete " + t.TaskName + "?";
            int center = (434 - (int)(lblDeleteConfirmation.Width / 2));
            lblDeleteConfirmation.Location = new System.Drawing.Point(center, 190);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnToHomePage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tasks.getTasks().Remove(t);
            returnToHomePage();

        }

        private void loadInformation()
        {
            lblTaskName.Text = t.TaskName;
            lblDueDate.Text = t.DueDate;
            lblPriority.Text = t.Priority;
            lblSubject.Text = t.Subject;
            lblSummary.Text = t.Summary;
            lblXDetails.Text = t.XDetails;
        }

        private void returnToHomePage()
        {
            //moving from DeleteTask back to the HomePage 
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
