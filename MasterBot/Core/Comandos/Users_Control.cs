using Discord;
using Discord.Commands;
using Discord.WebSocket;
using MasterBot.Core.Inteligencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MasterBot.Core.Comandos
{
    public class Users_Control : ModuleBase<SocketCommandContext>
    {
        [Command("BanUser"), Alias("Banuser", "banuser", "banUser", "BANUSER")]
        public async Task Ban_user(IUser user2add)
        {
            if (Decisoes.Decidir_Double(Context.User, user2add))
            {
                var user = user2add;
                await Context.Guild.AddBanAsync(user2add);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));
            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
        [Command("UnbanUser"), Alias("Unanuser", "unbanuser", "unbanUser", "UNBANUSER")]
        public async Task Unban_user(IUser user2unban)
        {
            if (Decisoes.Decidir_Double(Context.User, user2unban))
            {
                
                await Context.Guild.RemoveBanAsync(user2unban);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));
            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
    }
}
