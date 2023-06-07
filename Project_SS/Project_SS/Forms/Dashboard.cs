﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS
{
    public partial class Dashboard : Form
    {
        int panelWidth;
        bool isCollapse;
        
        public Dashboard()
        {
            InitializeComponent();

            //tb_User.Text = str.getUser();

            timerTime.Start();
            panelWidth = panel_Left.Width;
            isCollapse = false;

        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btn_Roll_Dashboard_Click(object sender, EventArgs e)
        {
            timerRoll.Start();
        }

        private void timerRoll_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel_Left.Width = panel_Left.Width + 10;
                if (panel_Left.Width >= panelWidth)
                {
                    timerRoll.Stop();
                    isCollapse = false;
                    this.Refresh();
                }
            }
            else
            {
                panel_Left.Width = panel_Left.Width - 30;
                if (panel_Left.Width <= 55)
                {
                    timerRoll.Stop();
                    isCollapse = true;
                    this.Refresh();
                }
            }
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}