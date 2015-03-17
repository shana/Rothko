﻿using System;
using System.Runtime.Serialization;

namespace Rothko
{
    public interface IOperatingSystemInfo : ICloneable, ISerializable
    {
        PlatformID Platform { get; }
        string ServicePack { get; }
        Version Version { get; }
        string VersionString { get; }
        string Name { get; }
        string Edition { get; }
    }
}