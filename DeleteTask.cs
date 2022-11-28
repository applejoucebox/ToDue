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
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
    }
}
