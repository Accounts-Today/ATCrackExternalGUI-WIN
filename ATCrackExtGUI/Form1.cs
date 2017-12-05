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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCrackExtGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string externalPath = Environment.CurrentDirectory + "/External.jar";
        readonly string licensePath = Environment.CurrentDirectory + "/license.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(licensePath))
            {
                licenseBox.Text = File.ReadAllText(licensePath) == "" ? "License" : File.ReadAllText(licensePath);
            }
            if (File.Exists(externalPath)) return;
            MessageBox.Show("External.jar not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }

        private void usernamesBtn_Click(object sender, EventArgs e)
        {
            if (openUsernames.ShowDialog() == DialogResult.OK)
            {
                usernameBox.Text = Path.GetFileName(openUsernames.FileName);
            }
            else
            {
                MessageBox.Show("Oops! An error has occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optifineBtn_Click(object sender, EventArgs e)
        {
            if (saveOptifine.ShowDialog() == DialogResult.OK)
            {
                optifineBox.Text = Path.GetFileName(saveOptifine.FileName);
            }
            else
            {
                MessageBox.Show("Oops! An error has occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hypixelBtn_Click(object sender, EventArgs e)
        {
            if (saveHypixel.ShowDialog() == DialogResult.OK)
            {
                hypixelBox.Text = Path.GetFileName(saveHypixel.FileName);
            }
            else
            {
                MessageBox.Show("Oops! An error has occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            if (licenseBox.TextLength != 24)
            {
                MessageBox.Show("Invalid License!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.WriteAllText(licensePath, licenseBox.Text);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            if (openUsernames.FileName == "")
            {
                MessageBox.Show("Invalid Username file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(saveHypixel.FileName) && string.IsNullOrEmpty(saveOptifine.FileName))
            {
                MessageBox.Show("You must select a Save Location for Optifine or Hypixel!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string args = " -jar External.jar -l " + licenseBox.Text + " -u \"" + openUsernames.FileName + "\"";
            if (!string.IsNullOrEmpty(saveHypixel.FileName))
            {
                args += " -h \"" + saveHypixel.FileName + "\"";
            }
            if (!string.IsNullOrEmpty(saveOptifine.FileName))
            {
                args += " -o \"" + saveOptifine.FileName + "\"";
            }
            if (jpPleaseCommit.Checked)
            {
                args += " -e";
            }
            MessageBox.Show(args);
            if (RunningCheck())
            {
                Process.Start("java", args);
                Environment.Exit(0);
            }
        }

        private bool RunningCheck()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle.Contains("Accounts Today External"))
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "ATCrack External is already running. Would you like me to shut it down?", "Error!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.Kill();
                        return true;
                    }
                    if (dialogResult != DialogResult.Yes)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}