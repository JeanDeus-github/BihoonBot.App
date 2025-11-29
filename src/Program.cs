// <copyright file="Program.cs" company="Jean Deus">
// Copyright (c) Jean Deus. All rights reserved.
// </copyright>

using BihoonBot.App.Services;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides the entry point for the application.
/// </summary>
/// <remarks>This class contains the Main method, which is invoked when the application starts. The Main method is
/// asynchronous and can be used to perform initialization or launch application logic.</remarks>
public class Program
{
    /// <summary>
    /// Serves as the entry point for the application.
    /// </summary>
    /// <param name="args">An array of command-line arguments supplied to the application.</param>
    /// <returns>A task that represents the asynchronous operation of the application's entry point.</returns>
    public static async Task Main(string[] args)
    {
        IServiceProvider services = new ServiceCollection()
            .AddSingleton<DiscordSocketClient>()
            .AddSingleton<DiscordClientService>()
            .BuildServiceProvider();

    }
}