﻿using System;

namespace InstaSharper.Abstractions.API.UriProviders
{
    public interface IDeviceUriProvider
    {
        Uri SyncLauncher { get; }
    }
}