﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Lockthreat
{
    public class LockthreatClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LockthreatClientModule).GetAssembly());
        }
    }
}
