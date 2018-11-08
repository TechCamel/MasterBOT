using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using MasterBot.Core.Segurança;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using MasterBot.Core.Inteligencia;


namespace MasterBot
{
    class Program
    {
        public static string path = $"{AppDomain.CurrentDomain.BaseDirectory.ToString().Replace(@"\bin\Debug\netcoreapp2.0\", string.Empty)}";
        private DiscordSocketClient Client;
        private CommandService Comands;
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug
            });
            Comands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = false,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug
            });
            Client.MessageReceived += Client_MessageReceived;
            Client.MessageUpdated += Client_MessageUpdated;
            await Comands.AddModulesAsync(Assembly.GetEntryAssembly());
            Client.Ready += Client_Ready;
            Client.Log += Client_Log;
            Client.UserJoined += NewUser;
            Encriptação Gettoken = new Encriptação();
            string token = "NTA5MDE4MTUwNTQ1OTE1OTE1.DsT86A.yaLYz7mRC8GvyQAoB-TVHJJ6wZo";
            
            await Client.LoginAsync(TokenType.Bot, token);
            await Client.StartAsync();
            await Task.Delay(-1);
        }

        private async Task Client_MessageUpdated(Cacheable<IMessage, ulong> arg1, SocketMessage arg2, ISocketMessageChannel arg3)
        {
            await Client_MessageReceived(arg2);
        }

        /// <summary>
        /// Roda quando um novo usuario entra no servidor
        /// Falta elaborar o texto de boas vindas
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task NewUser(SocketGuildUser user)
        {
            //Enviar boas vindas
            var c = Discord.UserExtensions.SendMessageAsync(user, $"Bem Vindo {user.Username}");
            string[] texto = new string[] { $"{user.Username}", "0" };
            File.WriteAllLines($@"{path}\Data\Users\{user.Username}", texto);
        }
        /// <summary>
        /// Escrever no ficheiro de log 
        /// </summary>
        /// <param name="logMessage"></param>
        /// <returns></returns>
        private async Task Client_Log(LogMessage logMessage)
        {
            Console.WriteLine($"{DateTime.Now} de {logMessage.Source} -> {logMessage.Message}");
        }

        private async Task Client_Ready()
        {
            await Client.SetGameAsync("Sendo Programado");
        }

        private async Task Client_MessageReceived(SocketMessage arg)
        {
            var mensagem = arg as SocketUserMessage;
            var context = new SocketCommandContext(Client, mensagem);
            if (context.User.IsBot) return;

            int prefixInd = 0;
            if (!(mensagem.HasCharPrefix(Convert.ToChar("a"), ref prefixInd) || mensagem.HasMentionPrefix(Client.CurrentUser, ref prefixInd))) ;// Comando_Desconhecido.Novo_Comando(context.Message.Content, context);

            var result = await Comands.ExecuteAsync(context, prefixInd);
            if(!result.IsSuccess)
            {
                if(result.ErrorReason == "Unknown command.")
                {
                    Comando_Desconhecido.Novo_Comando(context.Message.Content,context);
                }
                Console.WriteLine($"{DateTime.Now} na sala {context.Channel} -> Ocureu um erro com o comando: {context.Message.Content} | Erro: {result.ErrorReason}");
            }
        }
    }
}
