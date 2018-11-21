using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasterBot.Core.Comandos
{
    class Anuncios : ModuleBase<SocketCommandContext>
    {
        [Command("Anunciar"), Alias("Anunciar", "anunciar", "ANUNCIAR")]
        public async Task Anunciar(string Anuncio)
        {
            DiscordSocketClient _client = new DiscordSocketClient(); 
            ulong id = 513312735006687232; 
            var chnl = _client.GetChannel(id) as IMessageChannel; 
            await chnl.SendMessageAsync($"Novo Anuncio por {Context.User}!\n {Anuncio} \n \n {Context.User.Mention}");
            
        }
    }
}
