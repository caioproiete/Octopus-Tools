﻿using log4net;
using Octopus.Client;
using OctopusTools.Util;

namespace OctopusTools.Importers
{
    public interface IImporterLocator
    {
        IImporterMetadata[] List();
        IImporter Find(string name, IOctopusRepository repository, IOctopusFileSystem fileSystem, ILog log);
    }
}