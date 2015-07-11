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
        private List<FileInfo> searchResult = new List<FileInfo>();
        private DateTime start;
        private string searchCriteria = "";
        public MainForm()
        {
            InitializeComponent();
            // 初始化
            stopSearchButton.Enabled = false;
        }

        private void searchButtonTouched(object sender, EventArgs e)
        {
            // 准备搜索
            start = DateTime.Now;
            progressTimer.Enabled = true;
            progressTimer.Start();
            stopSearchButton.Enabled = true;

            // 搜索
            searchResult.Clear();
            startSearch();
            
        }

        private void startSearch()
        {
            var dir = new DirectoryInfo(searchCriteria);
            searchResult = dir.GetFiles().ToList();
        }
        private void stopSearchButton_Click_1(object sender, EventArgs e)
        {
            progressTimer.Enabled = false;
            progressTimer.Stop();
            stopSearchButton.Enabled = false;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - start;
            timeLabel.Text = String.Format("Total time: {0:hh\\:mm\\:ss}", elapsed);
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

    }
}
