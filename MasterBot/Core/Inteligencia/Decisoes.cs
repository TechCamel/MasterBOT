using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Discord.WebSocket;
using Discord.Commands;
using Discord;

namespace MasterBot.Core.Inteligencia
{
    public class Decisoes
    {
        public static bool Decidir_Single(SocketUser user)
        {
            StreamReader amizade = new StreamReader($@"{Program.path}\Data\Users\{user.Username}.txt");
            amizade.ReadLine();
            int LVL_amizade = Convert.ToInt32(amizade.ReadLine().ToString());
            Random rand = new Random();
            int numero = rand.Next(0,10);
            if(numero <= LVL_amizade)
            {
                return true;
            }else
                return false;
        }
        public static bool Decidir_Double(SocketUser user,IUser user2add)
        {
            StreamReader amizade = new StreamReader($@"{Program.path}\Data\Users\{user.Username}.txt");
            amizade.ReadLine();
            int LVL_amizade = Convert.ToInt32(amizade.ReadLine().ToString());
            StreamReader amizade2 = new StreamReader($@"{Program.path}\Data\Users\{user2add.Username}.txt");
            amizade2.ReadLine();
            LVL_amizade += Convert.ToInt32(amizade2.ReadLine().ToString());
            Random rand = new Random();
            int numero = rand.Next(0, 10);
            if (numero <= LVL_amizade)
            {
                return true;
            }
            else
                return false;
        }
    }
}
