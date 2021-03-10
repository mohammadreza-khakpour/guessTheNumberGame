using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumberProject
{
    //IO
    public class ClientHandler
    {
        public int ClientGuess { get; set; }
        public string Message { get; set; }
        public ConsoleColor MessageColor { get; set; }

        public void GetClientGuessWithConsole()
        {
            Console.Write("\nguess the number: ");
            ClientGuess = int.Parse(Console.ReadLine());
        }

        public void SetMessageForClient(string ResultInString)
        {
            switch (ResultInString)
            {
                case "correct":
                    Message = "great job; CORRECT !!";
                    break;
                case "less":
                    Message = "Your guess is less than the number";
                    break;
                case "more":
                    Message = "Your guess is more than the number";
                    break;
                default:
                    break;
            }
        }

        public void SetColorForClient(string ResultInString)
        {
            switch (ResultInString)
            {
                case "correct":
                    MessageColor = ConsoleColor.Green;
                    break;
                case "less":
                    MessageColor = ConsoleColor.Yellow;
                    break;
                case "more":
                    MessageColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
        }

        public void PrintMessageInConsole()
        {
            Console.ForegroundColor = MessageColor;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
