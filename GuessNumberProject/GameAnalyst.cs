using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumberProject
{
    //Engine
    public class GameAnalyst
    {
        public int RandomNum { get; set; }
        private enum result
        {
            correct=1,
            less=2,
            more=3
        }
        private GameAnalyst.result Result { get; set; }
        public string ResultInString { get; set; }


        public void GenerateRandomNum()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            RandomNum = number;
        }

        public void Compare(int clientNum) { 
        
            if (clientNum > RandomNum)
            {
                Result = result.more;
                ResultInString = "more";


            }

            else if (clientNum < RandomNum)
            {
                Result =  result.less;
                ResultInString = "less";
            }

            else
            {
                Result = result.correct;
                ResultInString = "correct";
            }
        }

        public void SetResultInString()
        {
            switch (Result)
            {
                case result.correct:
                    ResultInString = "correct";
                    break;
                case result.less:
                    ResultInString = "less";
                    break;
                case result.more:
                    ResultInString = "more";
                    break;
                default:
                    break;
            }
        }

    }
}
