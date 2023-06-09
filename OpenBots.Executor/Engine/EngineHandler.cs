﻿using Autofac;
using OpenBots.Agent.Core.Enums;
using OpenBots.Agent.Core.Model;
using OpenBots.Agent.Core.Utilities;
using OpenBots.Core.Model.EngineModel;
using OpenBots.Core.Script;
using OpenBots.Engine;
using OpenBots.Executor.Utilities;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpenBots.Executor
{
    public class EngineHandler
    {
        private IContainer _container;
        public EngineHandler()
        {
        }

        public void LoadProjectAssemblies(List<string> projectAssemblies)
        {
            var builder = AssembliesManager.LoadBuilder(projectAssemblies);
            _container = builder.Build();
        }

        public void ExecuteScript(JobExecutionParams executionParams)
        {
            var engineContext = GetEngineContext(executionParams);
            var engine = new AutomationEngineInstance(engineContext);
            engine.ExecuteScriptSync();
        }
        
        private EngineContext GetEngineContext(JobExecutionParams executionParams)
        {
            return new EngineContext
            {
                FilePath = executionParams.MainFilePath,
                ProjectPath = executionParams.ProjectDirectoryPath,
                EngineLogger = new Logging().GetLogger(executionParams),
                Container = _container,
                Arguments = executionParams.JobParameters?.Select(arg =>
                new ScriptArgument
                {
                    ArgumentName = arg.Name,
                    ArgumentValue = arg.Value
                }).ToList()
            };
        }
    }
}
