﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_dongü_ornkleri_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i=0;i<10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
