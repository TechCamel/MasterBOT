using System;
using System.Collections.Generic;
using System.Text;
using Discord.WebSocket;
using Discord.Commands;
namespace MasterBot.Core.Inteligencia
{
    class Comando_Desconhecido
    {
        public static SocketCommandContext Context;
        public static void Novo_Comando(string mensagem,SocketCommandContext context)
        {
            Context = context;
            Anti_PalavraoAsync(mensagem);
        }
        public static async System.Threading.Tasks.Task Anti_PalavraoAsync(string mensagem)
        {
            if(mensagem.ToLower().Contains("caralho") || mensagem.ToLower().Contains("puta") || mensagem.ToLower().Contains("merda") || mensagem.ToLower().Contains("fodase") || mensagem.ToLower().Contains("foda-se"))
            {
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} Não se diz palavrões caralho... Ups foda-se que merda 😂");
            }
        }
    }
}
