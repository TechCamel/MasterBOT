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
        
        //https://rule34.xxx/index.php?page=dapi&s=post&q=index&limit=1&tags={}
        [Command("Rule34"), Alias("rule34", "regra34", "Regra34", "REGRA34")]
        public async Task Rule34_Comand(string tags)
        {
            XmlDocument xml = new XmlDocument();
            var wc = new WebClient();
            xml.LoadXml(wc.DownloadString("https://rule34.xxx/index.php?page=dapi&s=post&q=index&limit=1&tags=mite"));

            XmlNodeList xnList = xml.SelectNodes("/Names/Name");
            foreach (XmlNode xn in xnList)
            {
                string firstName = xn["FirstName"].InnerText;
                string lastName = xn["LastName"].InnerText;
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
            var embed = new EmbedBuilder(); embed.WithTitle("Ultimus Raid - Level 40");

            embed.WithImageUrl("https://cdn.discordapp.com/attachments/430797829078908928/441255069518921728/Lvl40raid.png");

            await ReplyAsync("", false, embed);
        }
    }
}
