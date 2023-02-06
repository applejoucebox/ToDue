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
        //passing in "the" tasklist to the homepage
        private ToDue.Models.TaskList tasks = new ToDue.Models.TaskList();
        public HomePage(ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            anchorWindow();

            tasks = tasksPassedIn;
            addAllTasksFromList();

        }
         
        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            goToAddNewTask();
        }

        private void cboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            var temp = tasks.getTasks().OrderBy(o => o.DueDate).ToList();
            for(int i = 0; i < temp.Count(); i++)
            {
                tasks.getTasks()[i] = temp.ElementAt(i);
            }


            HomePage newForm = new HomePage(tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
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

            //customizing the appearance of each button
            if (t.IsComplete != true)
            {
                newTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
                newTaskButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
            else
            {
                newTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
                newTaskButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
               
            }

            //common styles between the buttons
            newTaskButton.Size = new System.Drawing.Size(204, 37);
            newTaskButton.Text = t.TaskName;
            newTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            newTaskButton.UseVisualStyleBackColor = false;

            //changing the location of the buttons 
            newTaskButton.Location = new System.Drawing.Point(79, 197 + 50 * location);

            //adding the event handlers for individual buttons
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

            }
        }
        private void anchorWindow()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
