// <copyright file="DiscordClientService.cs" company="Jean Deus">
// Copyright (c) Jean Deus. All rights reserved.
// </copyright>

namespace BihoonBot.App.Services
{
    using System.Threading.Tasks;
    using BihoonBot.App.Interfaces;
    using Discord;
    using Discord.WebSocket;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Provides core functionality for managing a Discord client connection within the application.
    /// </summary>
    internal class DiscordClientService : IDiscordClientService
    {
        private readonly DiscordSocketClient discordSocketClient;
        private IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscordClientService"/> class using the specified DiscordSocketClient.
        /// </summary>
        /// <param name="discordSocketClient">The DiscordSocketClient instance to be used for managing the connection and interactions with the Discord
        /// API. Cannot be null.</param>
        public DiscordClientService(DiscordSocketClient discordSocketClient)
        {
            this.discordSocketClient = discordSocketClient;
            this.configuration = this.BuildConfiguration();
            this.BuildConfiguration();
            this.StartClient();
        }

        /// <inheritdoc/>
        public IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddEnvironmentVariables("discord_")
                .Build();
        }

        /// <inheritdoc/>
        public async void StartClient()
        {
            this.discordSocketClient.Log += this.LogAsync;
            await this.discordSocketClient.LoginAsync(TokenType.Bot, this.configuration["token"]);
            await this.discordSocketClient.StartAsync();
        }

        /// <inheritdoc/>
        public Task LogAsync(LogMessage message)
        {
            Console.WriteLine(message);
            return Task.CompletedTask;
        }
    }
}
