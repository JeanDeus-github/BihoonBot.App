// <copyright file="Program.cs" company="Jean Deus">
// Copyright (c) Jean Deus. All rights reserved.
// </copyright>

namespace BihoonBot.App.Services
{
    using Discord.WebSocket;

    /// <summary>
    /// Provides core functionality for managing a Discord client connection within the application.
    /// </summary>
    internal class DiscordClientService
    {

        private readonly DiscordSocketClient discordSocketClient;
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordClientService"/> class using the specified DiscordSocketClient.
        /// </summary>
        /// <param name="discordSocketClient">The DiscordSocketClient instance to be used for managing the connection and interactions with the Discord
        /// API. Cannot be null.</param>
        public DiscordClientService(DiscordSocketClient discordSocketClient)
        {
            this.discordSocketClient = discordSocketClient;
        }

    }
}
