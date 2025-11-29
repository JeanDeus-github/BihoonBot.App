// <copyright file="IDiscordClientService.cs" company="Jean Deus">
// Copyright (c) Jean Deus. All rights reserved.
// </copyright>

namespace BihoonBot.App.Interfaces
{
    using Discord;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Represents a service that provides core functionality for a Discord client implementation.
    /// </summary>
    internal interface IDiscordClientService
    {
        /// <summary>
        /// Builds and applies the configuration settings required for the component to operate.
        /// </summary>
        IConfiguration BuildConfiguration();

        /// <summary>
        /// Starts the client and initiates its connection process.
        /// </summary>
        void StartClient();

        /// <summary>
        /// Asynchronously writes a log entry using the configured logging provider.
        /// </summary>
        /// <returns>A task that represents the asynchronous logging operation.</returns>
        Task LogAsync(LogMessage message);
    }
}
