using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace MasterBot.Core.Comandos
{
    public class Hello_World : ModuleBase<SocketCommandContext>
    {
        [Command("hello"),Alias("Hello World","hello world", "hello World", "Hello World", "HELLO WORLD")]
        public async Task hello()
        {
            await Context.Channel.SendMessageAsync("Hello World");
        }
        
    }
}
