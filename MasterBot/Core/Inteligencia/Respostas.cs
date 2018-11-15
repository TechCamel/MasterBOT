using System;
using System.Collections.Generic;
using System.Text;
using Discord.WebSocket;
using Discord.Commands;

namespace MasterBot.Core.Inteligencia
{
    class Respostas
    {
        public static string Aceitar_Resp(SocketCommandContext Context)
        {
            Random rand = new Random();
            switch (rand.Next(1, 2)){
                case 1:
                    return $"Tu é que mandas chefe {Context.User.Mention} ❤";
                case 2:
                    return $"Ta feito. Só porque gosto de ti {Context.User.Mention} ❤";
                default:
                    return $"Ta feito. Só porque gosto de ti {Context.User.Mention} ❤";
            }

        }
        public static string Rejeitar_Resp(SocketCommandContext Context)
        {
            Random rand = new Random();
            switch (rand.Next(1, 2))
            {
                case 1:
                    return $"{Context.User.Mention} Não, és feio 😂";
                case 2:
                    return $"Não. Não mandas em mim {Context.User.Mention} ❤";
                default:
                    return $"Só porque gosto de ti adiciono-te {Context.User.Mention} ❤";
            }

        }
        public static string NãoConheco(SocketCommandContext Context)
        {
            Random rand = new Random();
            switch (rand.Next(1, 5))
            {
                case 1:
                    return $"{Context.User.Mention} Vai po caralho feio 😂";
                case 2:
                    return $"Ouvi dizer que eras paneleiro {Context.User.Mention} ❤";
                case 3:
                    return $"{Context.User.Mention} Não conheço essa merda fala-me direito caralho";
                case 4:
                    return $"{Context.User.Mention} Aiii toniii";
                case 5:
                    return $"{Context.User.Mention} A tua mae ontem não se queixou";
                default:
                    return $"Só porque gosto de ti adiciono-te {Context.User.Mention} ❤";
            }
        }
    }
}
