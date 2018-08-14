using DCGBot.Discord;
using DCGBot.Discord.Entities;
using System;
using System.Threading.Tasks;

namespace DCGBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello Discord!");
            var dBotConfig = new DiscordBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }

    }
}
