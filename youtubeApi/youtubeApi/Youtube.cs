﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubeApi
{
    public partial class Youtube : Form
    {
        public Youtube()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailScreen detailScreen = new DetailScreen();
            detailScreen.ShowDialog();
        }
    }
}
