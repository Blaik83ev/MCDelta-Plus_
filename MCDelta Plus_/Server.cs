using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace MCDelta_Plus
{
    class Server
    {
        public static string ServerName = "[MCDelta] Server";
        public static Level MainLevel;

        public void Run()
        {
            this.Init();
        }

        void Init()
        {
            Log("Initalizing Server");
            while (true)
            {
                Console.ReadLine();
            }
        }

        #region == Sockets
        public static TcpListener listener;
        public static void StartListening()
        {
            startretry:
            try
            {
                listener = new TcpListener(System.Net.IPAddress.Any, 25565);
                listener.Start();
            }
            catch { }
        }
        #endregion

        public static void Log(string message)
        {
            Log(message, ConsoleColor.White, ConsoleColor.Black);
        }
        /// <summary>
        /// Write an error to the Console and the GuiLog using Red on black colors
        /// </summary>
        /// <param name="E">The error exception to write.</param>
        public static void Log(Exception E)
        {
            Log("[ERROR]: ", ConsoleColor.Red, ConsoleColor.Black);
            Log(E.Message, ConsoleColor.Red, ConsoleColor.Black);
            Log(E.StackTrace, ConsoleColor.Red, ConsoleColor.Black);
        }
        /// <summary>
        /// Write a message to the console and GuiLog using a specified TextColor and BackGround Color
        /// </summary>
        /// <param name="message">The Message to show</param>
        /// <param name="TextColor">The color of the text to show</param>
        /// <param name="BackgroundColor">The color behind the text.</param>
        public static void Log(string message, ConsoleColor TextColor, ConsoleColor BackgroundColor)
        {
            Console.ForegroundColor = TextColor;
            Console.BackgroundColor = BackgroundColor;
            Console.WriteLine(message.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }
    }
}
