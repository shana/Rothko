using System;
using System.ComponentModel.Composition;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
﻿using NullGuard;

namespace Rothko
{
    [Export(typeof(IAssemblyFacade))]
    public class AssemblyFacade : IAssemblyFacade
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public _Assembly GetExecutingAssembly()
        {
            return Assembly.GetCallingAssembly();
        }

        [return: AllowNull]
        public _Assembly GetEntryAssembly()
        {
            return Assembly.GetEntryAssembly();
        }

        public _Assembly GetAssembly(Type type)
        {
            return Assembly.GetAssembly(type);
        }
    }
}