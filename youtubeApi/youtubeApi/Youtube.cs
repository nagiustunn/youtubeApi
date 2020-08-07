using CodeHollow.FeedReader;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            /* if (dataGridView1.SelectedRows.Count == 0)
                 MessageBox.Show("choose a field");
             else if (dataGridView1.SelectedRows.Count != 0)
             {
                 DataGridViewRow dataGrid = this.dataGridView1.SelectedRows[0];
                 DetailScreen detailScreen = new DetailScreen();
                 detailScreen.ShowDialog();
             }*/
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetRssItems getRssItems = new GetRssItems();
            var rssItem = getRssItems.GetRssDataItems(txtUrl.Text);

            if (rssItem.Status == Response.Status.Success)
                dataGridView1.DataSource = new BindingList<RssModel>(rssItem.Data.ToList());
            else
                MessageBox.Show(rssItem.ErrorMessage);
        }
    }
}
