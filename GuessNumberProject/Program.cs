using System;

namespace GuessNumberProject
{
    //Flow Controller
    class Program
    {
        static void Main(string[] args)
        {
            ClientHandler uiHandler = new ClientHandler();
            GameAnalyst analyst = new GameAnalyst();
            
            analyst.GenerateRandomNum();

            do
            {
                uiHandler.GetClientGuessWithConsole();

                analyst.Compare(uiHandler.ClientGuess);

                uiHandler.SetColorForClient(analyst.ResultInString);

                uiHandler.SetMessageForClient(analyst.ResultInString);

                uiHandler.PrintMessageInConsole();

            } while (analyst.ResultInString != "correct");

            



        }
    }
}
