using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using WindowsFirewallHelper;
using WindowsFirewallHelper.FirewallAPIv2;
using WindowsFirewallHelper.FirewallAPIv2.Rules;
using System.Diagnostics;
using Utilities;
using System.Security;
using Gma.System.MouseKeyHook;
using System.IO;

namespace LagSwitchEFT
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        static int TimeoutMS = 0;
        static bool isRunning = true;
        static string ButtonScan;
        static string StatusLabelStr = "Waiting for startup";
        static string location;
        static string firewhash = System.Guid.NewGuid().ToString();
        private static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            ButtonScan = e.Button.ToString();
        }
        public void StatusTimer()
        {
            System.Windows.Forms.Timer StatusTimer = new System.Windows.Forms.Timer();
            StatusTimer.Tick += new EventHandler(SetStatusLabel);
            StatusTimer.Interval = 1000;
            StatusTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hooking
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;

            //Starting timer
            StatusTimer();

        }

        static void KB()
        {
            // Creating a new Process
            Process process = new Process();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = "netsh.exe";

            while (isRunning)
            {
                
                Thread.Sleep(40);

                if (ButtonScan == "XButton1")
                {
                    process.StartInfo.Arguments = ("advfirewall firewall add rule name =\"" + firewhash + "\" dir=in action=block program=\"" + location + "\" enable=yes");
                    process.StartInfo.Arguments = ("advfirewall firewall add rule name =\"" + firewhash + "\" dir=out action=block program=\"" + location + "\" enable=yes");
                    process.Start();
                    process.Start();
                    StatusLabelStr = "Blocking...";
                    ButtonScan = "";
                    Thread.Sleep(TimeoutMS);
                    process.StartInfo.Arguments = ("advfirewall firewall delete rule name=\"" + firewhash + "\" ");
                    process.Start();
                    StatusLabelStr = "Waiting for input...";
                }
            }
        }
        static void Start()
        {
            Thread TH = new Thread(KB);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void SetStatusLabel(object sender, EventArgs e)
        {
            StatusLabel.Text = StatusLabelStr;

            //Change Form Title
            this.Text = RandomString(16);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+-*/#&%[]{}";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void TimeoutScroll(object sender, EventArgs e)
        {
            TimeoutMS = TimeoutTrackbar.Value * 1000;
            MsLabel.Text = TimeoutMS.ToString() + " ms";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (TextBoxPath.Text != "" && TextBoxPath.Text != "C:/MyGame.exe")
            {
                location = TextBoxPath.Text;
                if (File.Exists(location))
                {
                    StartButton.Enabled = false;

                    Start();
                    
                }
                else
                {
                    StatusLabelStr = "File Doesn't Exists.";
                }
            }
            else { StatusLabelStr = "You need to input a file path."; }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextBoxPath.Text = OpenFile.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            System.Windows.Forms.Application.Exit();
        }
    }
}
