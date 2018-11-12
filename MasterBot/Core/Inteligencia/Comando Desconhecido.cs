using System;
using System.Collections.Generic;
using System.Text;
using Discord.WebSocket;
using Discord.Commands;
using System.Threading.Tasks;
namespace MasterBot.Core.Inteligencia
{
    class Comando_Desconhecido
    {
        public static SocketCommandContext Context;
        public static async Task Novo_ComandoAsync(string mensagem,SocketCommandContext context,bool HasMentionPrefix)
        {
            Context = context;
            await Anti_PalavraoAsync(mensagem);
            if (HasMentionPrefix)
            {
                await ComandoAsync(mensagem);
            }
        }
        public static async System.Threading.Tasks.Task Anti_PalavraoAsync(string mensagem)
        {
            if(mensagem.ToLower().Contains("caralho") || mensagem.ToLower().Contains("puta") || mensagem.ToLower().Contains("merda") || mensagem.ToLower().Contains("fodase") || mensagem.ToLower().Contains("foda-se"))
            {
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} Não se diz palavrões caralho... Ups foda-se que merda 😂");
            }
        }
        public static async Task ComandoAsync(string mensagem)
        {
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} Não conheço essa merda fala-me direito caralho");
        }
    }
}
