﻿using Rothko.Infrastructure;

namespace Rothko
{
    public class OperatingSystemFacade : IOperatingSystem
    {
        public OperatingSystemFacade()
        {
            Assembly = new AssemblyFacade();
            Dialog = new DialogFacade();
            Directory = new DirectoryFacade();
            Environment = new Environment();
            File = new FileFacade();
            MemoryMappedFiles = new MemoryMappedFileFactory();
            ProcessLocator = new ProcessLocator();
            ProcessStarter = new ProcessStarter();
            Registry = new Registry();
            Browser = new Browser(ProcessStarter, Environment);
        }

        public IAssemblyFacade Assembly { get; private set; }
        public IDialogFacade Dialog { get; private set; }
        public IDirectoryFacade Directory { get; private set; }
        public IEnvironment Environment { get; private set; }
        public IFileFacade File { get; private set; }
        public IMemoryMappedFileFactory MemoryMappedFiles { get; private set; }
        public IProcessLocator ProcessLocator { get; private set; }
        public IProcessStarter ProcessStarter { get; private set; }
        public IRegistry Registry { get; private set; }

        public IBrowser Browser { get; private set; }
    }
}
