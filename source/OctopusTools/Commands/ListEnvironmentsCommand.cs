﻿using System;
using log4net;

namespace OctopusTools.Commands
{
    public class ListEnvironmentsCommand : ApiCommand
    {
        public ListEnvironmentsCommand(IOctopusRepositoryFactory repositoryFactory, ILog log) : base(repositoryFactory, log)
        {
        }

        protected override void Execute()
        {
            var environments = Repository.Environments.FindAll();
            Log.Info("Environments: " + environments.Count);

            foreach (var environment in environments)
            {
                Log.InfoFormat(" - {0} (ID: {1})", environment.Name, environment.Id);
            }
        }
    }
}