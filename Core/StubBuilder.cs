using System;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.CSharp;

namespace Pretentious.Core
{
    public static class StubBuilder
    {
        public static void Build(string outputPath, string buildSource, string[] resources, string[] resourcesPayload)
        {
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateExecutable = true;
            compilerParams.OutputAssembly = outputPath;
            compilerParams.CompilerOptions = "/optimize+ /platform:x86 /target:winexe /unsafe";
            compilerParams.TreatWarningsAsErrors = false;

            foreach (string resource in resources)
                compilerParams.EmbeddedResources.Add(resource);
            foreach (string resource in resourcesPayload)
                compilerParams.EmbeddedResources.Add(resource);

            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add("System.Drawing.dll");
            compilerParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Dictionary<string, string> providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v2.0");

            CompilerResults results = new CSharpCodeProvider(providerOptions).CompileAssemblyFromSource(compilerParams, buildSource);
            foreach (CompilerError error in results.Errors)
                MessageBox.Show("Error: " + error.ErrorText, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}