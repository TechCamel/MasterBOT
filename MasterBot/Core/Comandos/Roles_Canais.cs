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
    public class Roles_Canais : ModuleBase<SocketCommandContext>
    {
        // adicionar inteligencia a tudo
        [Command("AddMe"),Alias("Addme","addme","addMe","ADDME")]
        public async Task Add_me(string Role)
        {
            var user = Context.User;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
            await (user as IGuildUser).AddRoleAsync(role);
        }
        [Command("AddUser"), Alias("Adduser", "adduser", "addUser", "ADDUSER")]
        public async Task Add_user(IUser user2add,string Role)
        {
            var user = user2add;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
            await (user as IGuildUser).AddRoleAsync(role);
        }
        [Command("RemoveMe"), Alias("Removeme", "removeme", "removeMe", "REMOVEME")]
        public async Task Remove_me(string Role)
        {
            var user = Context.User;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
            await (user as IGuildUser).RemoveRoleAsync(role);
        }
        [Command("RemoveUser"), Alias("Removeuser", "removeuser", "removeUser", "REMOVEUSER")]
        public async Task Remove_user(IUser user2add, string Role)
        {
            var user = user2add;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == Role);
            await (user as IGuildUser).RemoveRoleAsync(role);
        }
    }
}
