﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   CoreModule.cs
// </summary>
// ***********************************************************************

using Ninject.Modules;

namespace STM.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IConnection>().To<PLinkConnection>();
            this.Bind<IConnectionFactory>().ToConstant(new ConnectionFactory(this.Kernel));
            this.Bind<UserSettingsManager>().ToSelf().InSingletonScope();
        }
    }
}