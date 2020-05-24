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
using System.Threading;
using LiteDB;


namespace EzSkidPlay
{
    public partial class Form1 : Form
    {
        public static bool Is64Bit = false;
        public bool IsStarted = false;
        public string PLocation;
        public Process proc;
        public int Port = 0;
        public string Server;

        public Form1() => InitializeComponent();

        public async Task pr()
        {
            try
            {
                proc = new Process();
                proc.StartInfo.FileName = ("cmd.exe");
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                //proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.Arguments = $"/c {Server}";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.PriorityClass = ProcessPriorityClass.Normal;
                proc.WaitForExit();
            }
            catch (Exception Ex) { MessageBox.Show($"{Ex.ToString()}", $"{Ex.Source}"); }
        }


        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServer1.Text == "" && txtPort1.Text == "") { MessageBox.Show("Requires Valid Input for the Server and Port!"); return; }

                if (int.TryParse(txtPort1.Text, out int port)) Port = port;
                if (!(int.TryParse(txtPort1.Text, out int p))) { MessageBox.Show("Port Must be a number!"); return; }

                string server = $"{txtServer1.Text.Trim(' ')}:{Port}";
                Server = $"{PLocation} -server {server}";
                using (var n = new BackgroundWorker())
                {
                    n.DoWork += BWDoWork;
                    n.RunWorkerCompleted += BWDone;
                    n.RunWorkerAsync();
                }
                Thread.Sleep(150);
            }
            catch (Exception Ex) { MessageBox.Show("Make sure you only have one phantom applcation open"); }
        }

        private void BWDone(object sender, RunWorkerCompletedEventArgs e) => HandyHelper.Background.Dispose((BackgroundWorker)sender, 1);

        private async void BWDoWork(object sender, DoWorkEventArgs e) => await pr();

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Manual Select
            if (tabControl1.SelectedTab.Name == "tabPage1") { Form1.ActiveForm.Width = 325; Form1.ActiveForm.Height = 246; return; }

            //Custom Server
            else if (tabControl1.SelectedTab.Name == "tabPage2") { ActiveForm.Width = 325; Form1.ActiveForm.Height = 411; return; }
            else if (tabControl1.SelectedTab.Name == "tabPage3") { Form1.ActiveForm.Width = 325; Form1.ActiveForm.Height = 246; return; }
            //else if (tabControl1.SelectedTab.Name == "tabPage2") { tabControl1.SelectedIndex = 0; MessageBox.Show("Coming Soon! :)"); }
        }

        private void rdAddServer_CheckedChanged(object sender, EventArgs e) { if(rdAddServer.Checked) PanelAddServer.BringToFront(); }

        private void rdUseExisting_CheckedChanged(object sender, EventArgs e) {
            ListServers.ContextMenu = null;
            if (rdUseExisting.Checked)
            {
                
                PanelExistingServer.BringToFront();
                btnConnect.Enabled = true;
                PanelExistingServer.ContextMenuStrip = null;
                string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db");

                //Fills ListBox and populates database
                CreatePromtionalServers();

                //if (!File.Exists(SavedServers)) 
                //else { btnConnect.Enabled = false; rdUseExisting.Checked = false; MessageBox.Show("You must add a server to be able to join an existing one!", "No Servers in the database!"); }
            }
        }

        //PLocation = $"\"{Environment.CurrentDirectory}\"\\{GetPhantom()}";
        private void Form1_Load(object sender, EventArgs e) { Thread.Sleep(100); Is64Bit = Environment.Is64BitOperatingSystem; PLocation = $"{GetPhantom()}";  }

        private static string GetPhantom()
        {
            if (Is64Bit) return "phantom-windows.exe";
            else return "phantom-windows-32bit.exe";
        }

        #region Custom Server...
        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            //Blank Boxes
            if (txtServerIP.Text == "" || txtPort.Text == "") { MessageBox.Show("You must have a valid IP and port!", "The IP Field and Port are blank!"); return; }

            //Default Display Text
            if (txtServerIP.Text == "IP Address or Hostname here") { MessageBox.Show("Enter a valid ServerIP!", "The Servers IP box is using the default display text!"); return; }

            //Actually Correctly Formatted stuff
            if (txtServerIP.Text != "" && int.TryParse(txtPort.Text, out int Port))
            {
                //Server IP to save
                string IP = txtServerIP.Text;

                //Port above is the Servers Port to save

                //Location the servers are saved
                string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db"); string Server = ($"{IP}:{Port}").Replace("\n", ""); int ID = 1;

                //Updates server listing
                if (File.Exists(SavedServers))
                {
                    using (var db = new LiteDatabase(SavedServers))
                    {
                        var DB = db.GetCollection<ServerDatabase>("Servers");

                        //Sets ID to the highest ID + 1 to make the IDs not be duplicates
                        ID = DB.FindAll().Max(x => x.ID) +1;

                        //Server Info
                        var SInfo = new ServerDatabase { ID = ID, Promotional = false, Server = Server, ServerName = txtServerName.Text};

                        //Adds server to collection
                        DB.Insert(SInfo.ID, SInfo);
                        db.Dispose();
                    }
                }
                else
                {
                    //New Database Listing
                    using (var db = new LiteDatabase(SavedServers))
                    {
                        var DB = db.GetCollection<ServerDatabase>("Servers");

                        //Server Info
                        var SInfo = new ServerDatabase { ID = ID, Promotional = false, Server = Server, ServerName = txtServerName.Text };

                        //Adds server to collection
                        DB.Insert(1, SInfo);
                        db.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Function that deals with joining custom servers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ListServers.SelectedItem == null) { MessageBox.Show("Select a server then try again!"); return; }
            else
            {
                try
                {
                    string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db");

                    string server = "";

                    //Gets ServerData
                    using (var db = new LiteDatabase(SavedServers))
                    {
                        var DB = db.GetCollection<ServerDatabase>("Servers");

                        var sinfo = DB.FindAll().ToList().Find(x => x.ServerName == ListServers.SelectedItem.ToString());
                        server = sinfo.Server;
                        db.Dispose();
                    }

                    
                    Server = $"{PLocation} -server {server}";
                    using (var n = new BackgroundWorker())
                    {
                        n.DoWork += BWDoWork;
                        n.RunWorkerCompleted += BWDone;
                        n.RunWorkerAsync();
                    }
                    Thread.Sleep(150);
                }
                catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
            }
        }

        private void removeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListServers.SelectedItem == null) { MessageBox.Show("Select a server then try again!"); return; }
            else
            {
                string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db");

                bool D = false;
                try
                {
                    //Gets ServerData
                    using (var db = new LiteDatabase(SavedServers))
                    {
                        var DB = db.GetCollection<ServerDatabase>("Servers");

                        var sinfo = DB.FindAll().ToList().Find(x => x.ServerName == ListServers.SelectedItem.ToString());

                        if (!sinfo.Promotional)
                        {
                            if ((MessageBox.Show("Are you sure you want to delete this server?", "Delete Question", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                            {
                                DB.Delete(sinfo.ID);

                                if (DB.FindAll().Count() == 0) D = true;

                            }
                        }
                        else { MessageBox.Show("You cannot delete Promotional Servers"); }

                        db.Dispose();
                    }

                    if (D == true) File.Delete(SavedServers);
                    rdUseExisting.Checked = false;
                    rdUseExisting.Checked = true;
                }
                catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }

                
            }

        }

        #endregion
        #region Promotional Area...
        private async void CreatePromtionalServers()
        {

            //Adds Items to the DB 
            string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db");
            if (!File.Exists(SavedServers))
            {
                await AddServersToDatabase("DBH Offical Survival Server", "dbh-playmc.ddns.net", 19132);
                await AddServersToDatabase("HyperLands", "play.hyperlandsmc.net", 19132);
                await AddServersToDatabase("MinePlex -1", "mco.mineplex.com", 19132);
                await AddServersToDatabase("MinePlex -2", "pe.mineplex.com", 19132);
                await AddServersToDatabase("Grand Theft Auto - PocketMine Server", "grandtheft.mcpe.me", 19132);
                await AddServersToDatabase("SkyblockPE - Nukkit Server", "Play.SkyBlockpe.com", 19132);
                await AddServersToDatabase("Nightfall - Prison Server", "play.nightfall.xyz", 19132);
            }

            //Refreshes the ListBox
            ListServers.Items.Clear();

            using (var db = new LiteDatabase(SavedServers))
            {
                var DB = db.GetCollection<ServerDatabase>("Servers");


                foreach (var s in DB.FindAll())
                {
                    if (s.Promotional == true) { ListServers.Items.Add(s.ServerName); }
                    else ListServers.Items.Add(s.ServerName);
                }
                db.Dispose();
            }
            btnConnect.Enabled = true;
            PanelExistingServer.ContextMenuStrip = ExistingServerContextMenu;
        }

        private async Task AddServersToDatabase(string Name, string Hostname, int Port = 19132)
        {
            string SavedServers = ($"{Environment.CurrentDirectory}\\SavedServers.db");

            using (var db = new LiteDatabase(SavedServers))
            {
                var DB = db.GetCollection<ServerDatabase>("Servers");

                int ID = 0;


                //Sets ID to the highest ID + 1 to make the IDs not be duplicates
                if (DB.FindAll().Count() > 0) ID = DB.FindAll().Max(x => x.ID) + 1;

                string ser = $"{Hostname}:{Port}";

                //Server Info
                var SInfo = new ServerDatabase { ID = ID, Promotional = true, Server = ser, ServerName = Name };

                //Adds server to collection
                DB.Insert(SInfo.ID, SInfo);
                db.Dispose();
            }
        }
        #endregion Promotional Area...

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/twsWsbB");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://minecraftpocket-servers.com/");
        }
    }

    /// <summary>
    /// Server class for the LiteDB
    /// </summary>
    public class ServerDatabase
    {
        public int ID { get; set; }
        public bool Promotional { get; set; }
        public string Server { get; set; }
        public string ServerName { get; set; }
    }

}
