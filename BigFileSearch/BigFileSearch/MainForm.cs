using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BigFileSearch
{
    public partial class MainForm : Form
    {
        private List<ListView.ListViewItemCollection> searchResult = new List<ListView.ListViewItemCollection>();
        private DateTime start;
        private string searchCriteria = "";
        public MainForm()
        {
            InitializeComponent();
            // 初始化
            stopSearchButton.Enabled = false;
            searchListView.Columns.Add("文件名称");
            searchListView.Columns.Add("文件大小");
            searchListView.Columns[0].Width = 120;
            searchListView.Columns[1].Width = 120;

            // 点击事件
            searchListView.ItemActivate += new EventHandler(itemTouched);
            returnButton.Click += new EventHandler(returnButton_Click);
        }

        void returnButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void searchButtonTouched(object sender, EventArgs e)
        {
            // 搜索
            searchResult.Clear();
            startSearch();
            
        }

        private void startSearch()
        {
            if (searchCriteria.Length == 0)
            {
                MessageBox.Show("请选择路径!");
                return;
            }

            // 准备搜索
            start = DateTime.Now;
            progressTimer.Enabled = true;
            progressTimer.Start();
            stopSearchButton.Enabled = true;


            DirectoryInfo dirInfo = new DirectoryInfo(searchCriteria);
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            FileInfo[] fiInfo = dirInfo.GetFiles();

            foreach (DirectoryInfo di in dirs)
            {
                var item = new ListViewItem();
                item.Text = di.Name;
                //得到文件夾的路徑
                item.Tag = di.FullName;

                var subItem = new ListViewItem.ListViewSubItem();
                //文件夾沒有大小
                subItem.Text = "";
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = di.CreationTime.ToString();
                item.SubItems.Add(subItem);

                searchListView.Items.Add(item);
            }

            foreach (FileInfo fi in fiInfo)
            {
                var item = new ListViewItem();
                item.Text = fi.Name;

                var subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = fi.Length.ToString();
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = fi.CreationTime.ToString();
                item.SubItems.Add(subItem);

                searchListView.Items.Add(item);
            }

            searchResult = searchListView.Items();

            stopSearch();
        }

        private void stopSearch()
        {
            progressTimer.Enabled = false;
            progressTimer.Stop();
            stopSearchButton.Enabled = false;
            var foundString = String.Format("找到{0}个文件!", searchResult.Count.ToString());
            MessageBox.Show(foundString);
        }
        private void stopSearchButton_Click_1(object sender, EventArgs e)
        {
            stopSearch();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - start;
            timeLabel.Text = String.Format("Total time: {0:hh\\:mm\\:ss}", elapsed);
        }

        private void itemTouched(object sender, EventArgs e)
        {

        }
        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void selectDirectoryButton(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (!dlg.SelectedPath.Equals(""))
                {
                    searchTextBox.Text = dlg.SelectedPath;
                }
            }	
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchCriteria = searchTextBox.Text;
        }

        private void searchListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
