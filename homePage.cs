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
    public partial class HomePage : Form
    {
        //will eventually want to pass in a TaskList to the HomePage
        //public HomePage(ToDue.Models.TaskList tList)
        //for now just testing with a singular task
        private ToDue.Models.TaskList tasks = new ToDue.Models.TaskList();
        public HomePage(ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            tasks = tasksPassedIn;
            addAllTasksFromList();
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            goToAddNewTask();
        }

        private void cboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goToAddNewTask()
        {
            //moving from HomePage to the AddNewTask form
            AddNewTask newForm = new AddNewTask(tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private Button addSingleTaskButton(ToDue.Models.Task t, int location)
        {
            Button newTaskButton = new Button();
            this.Controls.Add(newTaskButton);

            //styling and location of the button
            newTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            newTaskButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newTaskButton.Location = new System.Drawing.Point(79, 197 + 50*location);
            newTaskButton.Size = new System.Drawing.Size(204, 37);
            newTaskButton.TabIndex = 5;
            newTaskButton.Text = t.TaskName;
            newTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            newTaskButton.UseVisualStyleBackColor = false;
            
            newTaskButton.Click += new EventHandler((sender, e) => taskButtonClick(sender, e, t));

            return newTaskButton;
        }

       
        private void taskButtonClick (object sender, EventArgs e, ToDue.Models.Task t)
        {
            //moving from HomePage to the TaskDetails form
            TaskDetails newForm = new TaskDetails(t, tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void addAllTasksFromList()
        {
            for (int i = 0; i < tasks.getTasks().Count(); i++)
            {
                //creating the buttons for each task
                Button currentTaskBtn = addSingleTaskButton(tasks.getTasks()[i], i);

                //adding the event handlers
                //currentTaskBtn.Click += new EventHandler((sender, e) => taskButtonClick(sender, e, tasks.getTasks()[i]));
            }
        }

    }
}
