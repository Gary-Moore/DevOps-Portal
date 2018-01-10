using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace DevOps.Portal.Infrastructure.Scripts
{
    public class PowershellScript
    {
        private ICollection<KeyValuePair<string, string>> ArgumentsList { get; }
        private readonly Action<string> _callback;
        protected readonly string ScriptFolderPath;
        private string Name { get;  }

        public PowershellScript(string name, Action<string> callback)
        {
            Name = name;
            _callback = callback;
            ArgumentsList = new List<KeyValuePair<string, string>>();
            var projectDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            ScriptFolderPath = Path.Combine(projectDirectory.FullName, "Scripts");
        }

        public ScriptExecutionResult ExecuteAync()
        {
            var result = new ScriptExecutionResult();
            var runspaceConfiguration = RunspaceConfiguration.Create();

            var runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration);
            runspace.Open();

            using (var powershell = PowerShell.Create())
            {
                powershell.Runspace = runspace;
                var pscommand = new PSCommand();

                var outputCollection = new PSDataCollection<PSObject>();
                outputCollection.DataAdded += OutputCollection_DataAdded;
                powershell.Streams.Error.DataAdded += Error_DataAdded;

                var command = new Command(ResolveFilePath());
                // add the arguments
                foreach (var parameter in ArgumentsList)
                {
                    command.Parameters.Add(parameter.Key, parameter.Value);
                }

                powershell.Commands = pscommand.AddCommand(command);

                var asyncResult = powershell.BeginInvoke<PSObject, PSObject>(null, outputCollection);

                powershell.EndInvoke(asyncResult);

                foreach (var outputItem in outputCollection)
                {
                    if (outputItem != null)
                    {
                        result.Outputs.Add(outputItem.BaseObject);
                    }
                }

                var errorStream = powershell.Streams.Error;
                if (errorStream.Count > 0)
                {
                    result.Suceess = false;
                    foreach (var error in errorStream)
                    {
                        result.ErrorMessages.Add(error.ToString());
                    }
                }
                else
                {
                    result.Suceess = true;
                }
            }

            return result;
        }

        public void AddArgument(string key, string value)
        {
            ArgumentsList.Add(new KeyValuePair<string, string>(key, value));
        }

        protected string ResolveFilePath()
        {
            return Path.Combine(ScriptFolderPath, Name);
        }

        private void OutputCollection_DataAdded(object sender, DataAddedEventArgs e)
        {
            var myp = (PSDataCollection<PSObject>)sender;

            var results = myp.ReadAll();
            foreach (var result in results)
            {
               _callback(result + Environment.NewLine);
            }
        }

        private void Error_DataAdded(object sender, DataAddedEventArgs e)
        {
            var myp = (PSDataCollection<ErrorRecord>)sender;

            var errors = myp.ReadAll();
            foreach (var error in errors)
            {
                _callback(error + Environment.NewLine);
            }
        }
    }
}