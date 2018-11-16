using Discord;
using Discord.Commands;
using MasterBot.Core.Inteligencia;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MasterBot.Core.Comandos
{
    public class Rule34 : ModuleBase<SocketCommandContext>
    {
        [Command("Rule34"), Alias("rule34", "regra34", "Regra34", "REGRA34")]
        public async Task Rule34_Comand(string tags)
        {
            bool encontrado = false;
            var embed = new EmbedBuilder();
            ;
            var wc = new WebClient();
            string xml = wc.DownloadString("https://rule34.xxx/index.php?page=dapi&s=post&q=index&limit=1&tags=" + tags);
            if(xml.Contains("https") || xml.Contains("http"))
            {
                string image = xml.Substring(xml.IndexOf("file_url=")+10);
                image = image.Substring(0, image.LastIndexOf("parent_id=")-2);
                encontrado = true;
                embed.WithTitle("Aqui esta o que eu encontrei sobre: " + tags + "\n Boas punhetas 😊😂✊");
                embed.WithImageUrl(image);
                await ReplyAsync(Context.User.Mention, false, embed);
            }
            else{
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} Desculpa mas não encontrei nada sobre isso.😢😢 \nAcho que vais ter que ser tu a fazer primeiro 😇😏✊✊");
            }
        }
    }
}
