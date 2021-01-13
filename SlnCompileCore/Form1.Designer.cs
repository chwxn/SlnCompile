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
            this.btnCompile = new System.Windows.Forms.Button();
            this.btnCompileCopy = new System.Windows.Forms.Button();
            this.txtDevDir = new System.Windows.Forms.TextBox();
            this.btnDevSel = new System.Windows.Forms.Button();
            this.btnExplorerCur = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelDir
            // 
            this.buttonSelDir.Location = new System.Drawing.Point(588, 12);
            this.buttonSelDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelDir.Name = "buttonSelDir";
            this.buttonSelDir.Size = new System.Drawing.Size(88, 30);
            this.buttonSelDir.TabIndex = 1;
            this.buttonSelDir.Text = "选择";
            this.buttonSelDir.UseVisualStyleBackColor = true;
            // 
            // listBoxSlnRepo
            // 
            this.listBoxSlnRepo.FormattingEnabled = true;
            this.listBoxSlnRepo.ItemHeight = 17;
            this.listBoxSlnRepo.Location = new System.Drawing.Point(31, 110);
            this.listBoxSlnRepo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSlnRepo.Name = "listBoxSlnRepo";
            this.listBoxSlnRepo.Size = new System.Drawing.Size(548, 412);
            this.listBoxSlnRepo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(31, 595);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(36, 17);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "label";
            // 
            // listBoxDirRepo
            // 
            this.listBoxDirRepo.FormattingEnabled = true;
            this.listBoxDirRepo.ItemHeight = 17;
            this.listBoxDirRepo.Location = new System.Drawing.Point(31, 13);
            this.listBoxDirRepo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDirRepo.Name = "listBoxDirRepo";
            this.listBoxDirRepo.Size = new System.Drawing.Size(548, 89);
            this.listBoxDirRepo.TabIndex = 5;
            // 
            // buttonExplorerDir
            // 
            this.buttonExplorerDir.Location = new System.Drawing.Point(588, 50);
            this.buttonExplorerDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExplorerDir.Name = "buttonExplorerDir";
            this.buttonExplorerDir.Size = new System.Drawing.Size(88, 30);
            this.buttonExplorerDir.TabIndex = 6;
            this.buttonExplorerDir.Text = "浏览";
            this.buttonExplorerDir.UseVisualStyleBackColor = true;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(31, 532);
            this.comboBoxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(548, 25);
            this.comboBoxCommand.TabIndex = 7;
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(588, 110);
            this.btnCompile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(88, 30);
            this.btnCompile.TabIndex = 8;
            this.btnCompile.Text = "生成(&F6)";
            this.btnCompile.UseVisualStyleBackColor = true;
            // 
            // btnCompileCopy
            // 
            this.btnCompileCopy.Location = new System.Drawing.Point(588, 148);
            this.btnCompileCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompileCopy.Name = "btnCompileCopy";
            this.btnCompileCopy.Size = new System.Drawing.Size(88, 30);
            this.btnCompileCopy.TabIndex = 9;
            this.btnCompileCopy.Text = "生成复制(&F5)";
            this.btnCompileCopy.UseVisualStyleBackColor = true;
            // 
            // txtDevDir
            // 
            this.txtDevDir.Location = new System.Drawing.Point(31, 564);
            this.txtDevDir.Name = "txtDevDir";
            this.txtDevDir.Size = new System.Drawing.Size(548, 23);
            this.txtDevDir.TabIndex = 10;
            // 
            // btnDevSel
            // 
            this.btnDevSel.Location = new System.Drawing.Point(588, 564);
            this.btnDevSel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevSel.Name = "btnDevSel";
            this.btnDevSel.Size = new System.Drawing.Size(88, 28);
            this.btnDevSel.TabIndex = 11;
            this.btnDevSel.Text = "选择";
            this.btnDevSel.UseVisualStyleBackColor = true;
            // 
            // btnExplorerCur
            // 
            this.btnExplorerCur.Location = new System.Drawing.Point(588, 223);
            this.btnExplorerCur.Name = "btnExplorerCur";
            this.btnExplorerCur.Size = new System.Drawing.Size(88, 30);
            this.btnExplorerCur.TabIndex = 12;
            this.btnExplorerCur.Text = "程序目录";
            this.btnExplorerCur.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(588, 186);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(88, 30);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "复制(&F7)";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 626);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnExplorerCur);
            this.Controls.Add(this.btnDevSel);
            this.Controls.Add(this.txtDevDir);
            this.Controls.Add(this.btnCompileCopy);
            this.Controls.Add(this.btnCompile);
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
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Button btnCompileCopy;
        private System.Windows.Forms.TextBox txtDevDir;
        private System.Windows.Forms.Button btnDevSel;
        private System.Windows.Forms.Button btnExplorerCur;
        private System.Windows.Forms.Button btnCopy;
    }
}

