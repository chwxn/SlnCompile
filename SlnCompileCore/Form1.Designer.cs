namespace SlnCompileCore
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelDir = new System.Windows.Forms.Button();
            this.listBoxSlnRepo = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxDirRepo = new System.Windows.Forms.ListBox();
            this.buttonExplorerDir = new System.Windows.Forms.Button();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSelDir
            // 
            this.buttonSelDir.Location = new System.Drawing.Point(588, 17);
            this.buttonSelDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelDir.Name = "buttonSelDir";
            this.buttonSelDir.Size = new System.Drawing.Size(88, 33);
            this.buttonSelDir.TabIndex = 1;
            this.buttonSelDir.Text = "选择";
            this.buttonSelDir.UseVisualStyleBackColor = true;
            // 
            // listBoxSlnRepo
            // 
            this.listBoxSlnRepo.FormattingEnabled = true;
            this.listBoxSlnRepo.ItemHeight = 17;
            this.listBoxSlnRepo.Location = new System.Drawing.Point(31, 115);
            this.listBoxSlnRepo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSlnRepo.Name = "listBoxSlnRepo";
            this.listBoxSlnRepo.Size = new System.Drawing.Size(548, 412);
            this.listBoxSlnRepo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(31, 572);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelInfo.TabIndex = 4;
            // 
            // listBoxDirRepo
            // 
            this.listBoxDirRepo.FormattingEnabled = true;
            this.listBoxDirRepo.ItemHeight = 17;
            this.listBoxDirRepo.Location = new System.Drawing.Point(31, 18);
            this.listBoxDirRepo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDirRepo.Name = "listBoxDirRepo";
            this.listBoxDirRepo.Size = new System.Drawing.Size(548, 89);
            this.listBoxDirRepo.TabIndex = 5;
            // 
            // buttonExplorerDir
            // 
            this.buttonExplorerDir.Location = new System.Drawing.Point(588, 58);
            this.buttonExplorerDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExplorerDir.Name = "buttonExplorerDir";
            this.buttonExplorerDir.Size = new System.Drawing.Size(88, 33);
            this.buttonExplorerDir.TabIndex = 6;
            this.buttonExplorerDir.Text = "浏览";
            this.buttonExplorerDir.UseVisualStyleBackColor = true;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(31, 537);
            this.comboBoxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(548, 25);
            this.comboBoxCommand.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 626);
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.buttonExplorerDir);
            this.Controls.Add(this.listBoxDirRepo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxSlnRepo);
            this.Controls.Add(this.buttonSelDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelDir;
        private System.Windows.Forms.ListBox listBoxSlnRepo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxDirRepo;
        private System.Windows.Forms.Button buttonExplorerDir;
        private System.Windows.Forms.ComboBox comboBoxCommand;
    }
}

