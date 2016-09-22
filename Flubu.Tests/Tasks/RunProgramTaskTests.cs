﻿using Flubu.Tasks.Dotnet;
using Microsoft.DotNet.Cli.Utils;
using Xunit;

namespace Flubu.Tests.Tasks
{
    public class RunProgramTaskTests : TaskTestBase
    {
        [Fact(Skip = "Implement task first")]
        public void ExecuteCommand()
        {
            ExecuteDotnetTask task = new ExecuteDotnetTask("D:/apps/adb/adb.exe");

            task.Execute(Context.Object);
        }
    }
}