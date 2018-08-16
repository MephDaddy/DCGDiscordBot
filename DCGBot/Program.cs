using DCGBot.Discord;
using DCGBot.Discord.Entities;
using DCGBot.Storage;
using System;
using System.Threading.Tasks;

namespace DCGBot
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new DiscordBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}
