namespace BigFileSearch
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.stopSearchButton = new System.Windows.Forms.Button();
            this.searchListView = new System.Windows.Forms.ListView();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(830, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 27);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "马上搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonTouched);
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Location = new System.Drawing.Point(26, 112);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(889, 23);
            this.searchProgressBar.TabIndex = 1;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "搜索路径";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(83, 40);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(628, 21);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "选择路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectDirectoryButton);
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(22, 88);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 21);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "00:00";
            // 
            // stopSearchButton
            // 
            this.stopSearchButton.Location = new System.Drawing.Point(830, 69);
            this.stopSearchButton.Name = "stopSearchButton";
            this.stopSearchButton.Size = new System.Drawing.Size(85, 23);
            this.stopSearchButton.TabIndex = 8;
            this.stopSearchButton.Text = "停止搜索";
            this.stopSearchButton.UseVisualStyleBackColor = true;
            this.stopSearchButton.Click += new System.EventHandler(this.stopSearchButton_Click_1);
            // 
            // searchListView
            // 
            this.searchListView.Location = new System.Drawing.Point(26, 141);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(889, 293);
            this.searchListView.TabIndex = 9;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            this.searchListView.SelectedIndexChanged += new System.EventHandler(this.searchListView_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(728, 69);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(85, 23);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "返回上级菜单";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 446);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.searchListView);
            this.Controls.Add(this.stopSearchButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchProgressBar);
            this.Controls.Add(this.searchButton);
            this.Name = "MainForm";
            this.Text = "Big File Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar searchProgressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button stopSearchButton;
        private System.Windows.Forms.ListView searchListView;
        private System.Windows.Forms.Button returnButton;

    }
}

