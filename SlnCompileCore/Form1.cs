using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SlnCompileCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonSelDir.Click += new System.EventHandler(this.buttonSelDir_Click);
            this.listBoxSlnRepo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSlnRepo_MouseDoubleClick);
            this.listBoxDirRepo.SelectedIndexChanged += new System.EventHandler(this.listBoxDirRepo_SelectedIndexChanged);
            this.buttonExplorerDir.Click += new System.EventHandler(this.buttonExplorerDir_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += Form1_FormClosing;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.labelInfo.Text = "Info：选择目录，加载该目录下的解决方案，双击解决方案cmd调用devenv编译。";
        }

        bool _isChange = false;
        bool _isLoad = false;
        string _command = "devenv {0} /build debug";

        List<string> _slnPathRepo = new List<string>();
        List<string> _cmdPathRepo = new List<string>();
        List<string> _slnDirRepo = new List<string>();

        string _slnPath = AppDomain.CurrentDomain.BaseDirectory + "sln.txt";
        string _cmdPath = AppDomain.CurrentDomain.BaseDirectory + "cmd.txt";
        string _baseDir = AppDomain.CurrentDomain.BaseDirectory;

        private void Form1_Load(object sender, EventArgs e)
        {
            _slnPathRepo.Clear();
            _cmdPathRepo.Clear();
            _slnDirRepo.Clear();
            //textBoxCommand.Text = _command;
            //comboBoxCommand.Items.Add(_command);
            comboBoxCommand.Text = _command;

            if (!Directory.Exists(_baseDir))
            {
                Directory.CreateDirectory(_baseDir);
            }
            if (File.Exists(_slnPath))
            {

                string[] dirs = File.ReadAllLines(_slnPath);
                if (dirs.Length > 0)
                {
                    foreach (var dir in dirs)
                    {
                        if (string.IsNullOrEmpty(dir)) continue;
                        _slnDirRepo.Add(dir);
                    }
                    listBoxDirRepo.DataSource = _slnDirRepo;
                    //listBoxDirRepo.SelectedIndex = 0;
                    loadSln(listBoxDirRepo.SelectedItem.ToString());
                }
            }
            if (File.Exists(_cmdPath))
            {

                string[] cmds = File.ReadAllLines(_cmdPath);
                if (cmds.Length > 0)
                {
                    foreach (var cmd in cmds)
                    {
                        if (string.IsNullOrEmpty(cmd)) continue;
                        _cmdPathRepo.Add(cmd);
                    }
                    if (_cmdPathRepo.Count > 0)
                        comboBoxCommand.DataSource = _cmdPathRepo;
                    //comboBoxCommand.SelectedIndex = 0;
                }
            }
            _isLoad = true;
        }
        private void buttonSelDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _baseDir;
            var dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string dir = folderBrowserDialog1.SelectedPath;

                if (!Directory.Exists(dir))
                {
                    MessageBox.Show("目录不存在！");
                    return;
                }
                _slnDirRepo.Add(dir);
                listBoxDirRepo.DataSource = null;
                listBoxDirRepo.DataSource = _slnDirRepo;
                _isChange = true;
                loadSln(dir);
            }
        }
        private void buttonExplorerDir_Click(object sender, EventArgs e)
        {
            if (listBoxDirRepo.SelectedItem == null)
                return;
            string dir = listBoxDirRepo.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(dir))
            {
                if (dir.Substring(dir.Length - 3, 3).Equals("sln", StringComparison.OrdinalIgnoreCase))
                    dir = dir.Replace("sln", "src");
                Thread thread = new Thread(new ParameterizedThreadStart(Cmd));
                thread.IsBackground = true;
                thread.Start("0&explorer " + dir);
            }
        }
        private void listBoxSlnRepo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = listBoxSlnRepo.SelectedItem.ToString();
            //string str = textBoxCommand.Text;
            string str = comboBoxCommand.Text;
            string command = string.Format(str, path);
            labelInfo.Text = command;

            if (_cmdPathRepo.IndexOf(str) < 0)
            {
                _cmdPathRepo.Add(str);
                saveCommand();
            }

            Thread thread = new Thread(new ParameterizedThreadStart(Cmd));
            thread.IsBackground = true;
            thread.Start("1&" + command);
        }
        private void listBoxDirRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isLoad) return;
            string dir = listBoxDirRepo.SelectedItem.ToString();
            labelInfo.Text = dir;
            loadSln(dir);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string str = comboBoxCommand.Text;
            if (_cmdPathRepo.IndexOf(str) < 0)
            {
                _cmdPathRepo.Add(str);
            }
            saveCommand();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void savePath()
        {
            if (!Directory.Exists(_baseDir))
            {
                Directory.CreateDirectory(_baseDir);
            }
            if (File.Exists(_slnPath))
            {
                File.Delete(_slnPath);
            }
            using (StreamWriter sw = new StreamWriter(_slnPath, true, Encoding.UTF8))
            {
                foreach (var dir in _slnDirRepo)
                {
                    sw.Write(dir);
                    sw.WriteLine();
                }

                sw.Flush();
                //sw.Close();
            }
        }

        void saveCommand()
        {
            if (!Directory.Exists(_baseDir))
            {
                Directory.CreateDirectory(_baseDir);
            }
            if (File.Exists(_cmdPath))
            {
                File.Delete(_cmdPath);
            }
            var curCmd = comboBoxCommand.Text;
            using (StreamWriter sw = new StreamWriter(_cmdPath, true, Encoding.UTF8))
            {
                if (!string.IsNullOrEmpty(curCmd))
                {
                    sw.WriteLine(curCmd);
                }
                for (int i = _cmdPathRepo.Count - 1; i >= 0; i--)
                {
                    var dir = _cmdPathRepo[i];
                    if (dir == curCmd) continue;
                    sw.Write(dir);
                    sw.WriteLine();
                }

                sw.Flush();
                //sw.Close();
            }
        }

        void loadSln(string dir)
        {
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("目录不存在！");
                return;
            }
            string[] files = Directory.GetFiles(dir, "*.sln");
            if (files.Length > 0)
            {
                _slnPathRepo.Clear();
                listBoxSlnRepo.DataSource = null;
                foreach (var file in files)
                {
                    _slnPathRepo.Add(file);
                }
                listBoxSlnRepo.DataSource = _slnPathRepo;
                if (_isChange)
                    savePath();
            }
        }

        private void Cmd(object cmd)
        {
            string flag = cmd.ToString().Substring(0, 1);
            string command = cmd.ToString().Substring(2);
            if (flag == "1")
            {
                using (Process process = new Process())
                {
                    //指定启动进程是调用的应用程序和命令行参数
                    ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", " /k " + command);
                    process.StartInfo = psi;
                    process.Start();
                    process.WaitForExit();
                    //process.Close();
                }
            }
            else
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                p.Start();//启动程序
                //向cmd窗口发送输入信息
                //p.StandardInput.WriteLine(string.Format(str,path) );//+ "&exit"
                p.StandardInput.WriteLine(command + "&exit");
                //p.StandardInput.WriteLine("ping 127.0.0.1 ");

                p.StandardInput.AutoFlush = true;
                //p.StandardInput.WriteLine("exit");
                //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令

                //获取cmd窗口的输出信息
                //string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
                //Console.WriteLine(output);
            }

        }

    }
}
