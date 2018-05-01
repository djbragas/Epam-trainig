﻿using URLParser;
using Ninject;
using Ninject.Modules;

namespace Tests
{
    internal class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IURLAddresesProvider>().ToProvider<FileUrlProviderCreator>();
            Bind<IURLConverterToXML>().To<DefaultURLConverterToXML>();
            Bind<IURLParser>().To<DefaultURLParser>();
        }
    }
}