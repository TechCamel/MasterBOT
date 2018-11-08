using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using MasterBot.Core.Inteligencia;
using Discord.WebSocket;

namespace MasterBot.Core.Comandos
{
    public class Roles_Canais : ModuleBase<SocketCommandContext>
    {
        // adicionar inteligencia a tudo
        [Command("AddMe"), Alias("Addme", "addme", "addMe", "ADDME")]
        public async Task Add_me(string Role)
        {
            if (Decisoes.Decidir_Single(Context.User))
            {
                var user = Context.User;
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
                await (user as IGuildUser).AddRoleAsync(role);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));
            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
        [Command("AddUser"), Alias("Adduser", "adduser", "addUser", "ADDUSER")]
        public async Task Add_user(IUser user2add,string Role)
        {
            if (Decisoes.Decidir_Double(Context.User,user2add))
            {
                var user = user2add;
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
                await (user as IGuildUser).AddRoleAsync(role);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));
            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
        [Command("RemoveMe"), Alias("Removeme", "removeme", "removeMe", "REMOVEME")]
        public async Task Remove_me(string Role)
        {
            if (Decisoes.Decidir_Single(Context.User))
            {
                var user = Context.User;
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
                await (user as IGuildUser).RemoveRoleAsync(role);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));
            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
        [Command("RemoveUser"), Alias("Removeuser", "removeuser", "removeUser", "REMOVEUSER")]
        public async Task Remove_user(IUser user2add, string Role)
        {
            if (Decisoes.Decidir_Double(Context.User, user2add))
            {
                var user = user2add;
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
                await (user as IGuildUser).RemoveRoleAsync(role);
                await Context.Channel.SendMessageAsync(Respostas.Aceitar_Resp(Context));

            }
            else
            {
                await Context.Channel.SendMessageAsync(Respostas.Rejeitar_Resp(Context));
            }
        }
    }
}
