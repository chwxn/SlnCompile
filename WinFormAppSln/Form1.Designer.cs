﻿namespace SlnCompile
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
            this.buttonSelDir.Location = new System.Drawing.Point(504, 12);
            this.buttonSelDir.Name = "buttonSelDir";
            this.buttonSelDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSelDir.TabIndex = 1;
            this.buttonSelDir.Text = "选择";
            this.buttonSelDir.UseVisualStyleBackColor = true;
            // 
            // listBoxSlnRepo
            // 
            this.listBoxSlnRepo.FormattingEnabled = true;
            this.listBoxSlnRepo.ItemHeight = 12;
            this.listBoxSlnRepo.Location = new System.Drawing.Point(27, 81);
            this.listBoxSlnRepo.Name = "listBoxSlnRepo";
            this.listBoxSlnRepo.Size = new System.Drawing.Size(470, 292);
            this.listBoxSlnRepo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(27, 404);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(431, 12);
            this.labelInfo.TabIndex = 4;
            // 
            // listBoxDirRepo
            // 
            this.listBoxDirRepo.FormattingEnabled = true;
            this.listBoxDirRepo.ItemHeight = 12;
            this.listBoxDirRepo.Location = new System.Drawing.Point(27, 13);
            this.listBoxDirRepo.Name = "listBoxDirRepo";
            this.listBoxDirRepo.Size = new System.Drawing.Size(470, 64);
            this.listBoxDirRepo.TabIndex = 5;
            // 
            // buttonExplorerDir
            // 
            this.buttonExplorerDir.Location = new System.Drawing.Point(504, 41);
            this.buttonExplorerDir.Name = "buttonExplorerDir";
            this.buttonExplorerDir.Size = new System.Drawing.Size(75, 23);
            this.buttonExplorerDir.TabIndex = 6;
            this.buttonExplorerDir.Text = "浏览";
            this.buttonExplorerDir.UseVisualStyleBackColor = true;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(27, 379);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(470, 20);
            this.comboBoxCommand.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.buttonExplorerDir);
            this.Controls.Add(this.listBoxDirRepo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxSlnRepo);
            this.Controls.Add(this.buttonSelDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

