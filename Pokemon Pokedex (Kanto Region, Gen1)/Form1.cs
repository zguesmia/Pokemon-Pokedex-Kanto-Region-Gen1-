﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Pokedex__Kanto_Region__Gen1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create an instance of Form2
            Form2 form2 = new Form2();
            //Shows that instance of Form2
            //This is going to be where the dropdown menu for the Pokedex is
            form2.Show();
            
        }
    }
}
