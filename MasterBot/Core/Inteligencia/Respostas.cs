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
                    return $"Tu é que mandas chefe {Context.User} ❤";
                case 2:
                    return $"Ta feito. Só porque gosto de ti {Context.User} ❤";
                default:
                    return $"Ta feito. Só porque gosto de ti {Context.User} ❤";
            }

        }
        public static string Rejeitar_Resp(SocketCommandContext Context)
        {
            Random rand = new Random();
            switch (rand.Next(1, 2))
            {
                case 1:
                    return $"{Context.User} Não, és feio 😂";
                case 2:
                    return $"Não. Não mandas em mim {Context.User} ❤";
                default:
                    return $"Só porque gosto de ti adiciono-te {Context.User} ❤";
            }

        }
    }
}
