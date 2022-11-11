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
        public TaskDetails(string taskName, string dueDate, string priority, string subject, string summary, string xDetails)
        {
            InitializeComponent();
            txtTaskName.Text = taskName;
            txtDueDate.Text = priority;
            txtPriority.Text = taskName;
            txtSubject.Text = subject;
            txtSummary.Text = summary;
            txtXDetails.Text = xDetails;
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
