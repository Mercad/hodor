﻿/*This file just needs to be sinked up with the XMl call file to display the users in the dropdown menu and 
 * display the proper screen for if the actor is a user or admin. 
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cycle1gui
{
    public partial class Login : Form
    {
        public List<Student> users;
        public Login()
        {
            InitializeComponent();
            dropDownLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            refreshUserList();
        }
  

        //bool IsTeacher = false;//admin or user
        //string UName;//user name

        public Dictionary<int, string> userValues;

        //object for calling functions of the xmlbackend class
        xmlBackend AA = new xmlBackend();

        //the cancel button for canceling window
        private void closeButton_Click(object sender, EventArgs e){
            Close();
        }

        public void refreshUserList()
        {
             users = AA.selectAll();
             users = users.OrderBy(x => x.getName()).ToList();
             userValues= new Dictionary<int, string>();
            if (users.Count > 0)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    userValues.Add(i, users[i].getName() + " " + users[i].getId());
                }
                dropDownLogin.DataSource = new BindingSource(userValues, null);
                dropDownLogin.DisplayMember = "Value";
                dropDownLogin.ValueMember = "Key";
            }
        }

         //Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            Student selectedUser = Student.authenticate_User(users, dropDownLogin.Text);
            if (selectedUser.getName() == null)
            {
                MessageBox.Show("ERROR: Cannot Login - User is not selected");
                return;
            }
            Action refresh = refreshUserList;
            new Update(selectedUser, refresh).Show();
        }
        //Create New User Button
        private void button3_Click(object sender, EventArgs e)
        {
                //new CreateNewUser().Show();
                 Action refresh = refreshUserList;
                CreateNewUser fred = new CreateNewUser(refresh);
                fred.Show();
                fred.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);

        }
        //supose to refresh the dropdown menu on this form, it isntdoing that
        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        //Dropdown Menu for the list of users
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //The login button that will either take a user to the game or the admin to the admin screen
        private void button1_Click(object sender, EventArgs e)
        {
            Student selectedUser = Student.authenticate_User(users, dropDownLogin.Text);
            if (selectedUser.getName() == null)
            {
                MessageBox.Show("ERROR: Cannot Login - User is not selected");
                return;
            }
            if (selectedUser.getisTeacher() == false)
            {
                if (new xmlBackend().selectStudentGameInfo(selectedUser) == null)
                {
                    MessageBox.Show("No Available Tests.");
                    return;
                }
                //needs to know which user it is
                //string StName = selectedUser.getName();
                GameScreen gs = new GameScreen(selectedUser);
                gs.Show();
                MessageBox.Show("Welcome to Sheriff Hodor!");
            }
            else
            {
                //go to admin screen
                Administration AD = new Administration();
                AD.Show();
            }
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}