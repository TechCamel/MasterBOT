using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasterBot.Core.Comandos
{
    class Anuncios : ModuleBase<SocketCommandContext>
    {/*
        [Command("hello"), Alias("Hello World", "hello world", "hello World", "Hello World", "HELLO WORLD")]
        public async Task hello()
        {
            SocketUser user = Context.User;
            StreamReader amizade = new StreamReader($@"{Program.path}\Data\Users\{user.Username}.txt");
            amizade.ReadLine();
            int LVL_amizade = Convert.ToInt32(amizade.ReadLine().ToString());
            if (LVL_amizade != 0)
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} Hello World");
            else
                await Context.Channel.SendMessageAsync($"Mas eu conheço-te?? {Context.User.Mention}");
        }*/
    }
}
