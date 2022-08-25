﻿using Immense.RemoteControl.Server.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immense.RemoteControl.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRemoteControlServer(this IServiceCollection services)
        {
            services.AddSingleton<IHubEventPublisher, HubEventPublisher>();
        }
    }
}
