using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        // Sätter ut nya privata fält
        private int _number;
        private int _count;

        //Sätter MaxNumberOfGuesses som konstant
        public const int MaxNumberOfGuesses = 7;
        //Konstruktor
        public SecretNumber()
        {
            Initialize();
        }   
        
        public void Initialize()
        {
            //Gör så att count ska börja på 0, och sätter att number ska vara ett nummer mellan 1 och 100.
            _count = 0;
            Random Random = new Random();
            _number = Random.Next(1, 101);

        }

        

        public bool MakeGuess(int guessNumber)
        {
          if (guessNumber < 1 || guessNumber > 100)
          {
              throw new ArgumentOutOfRangeException();
          }
          
          if (_count < MaxNumberOfGuesses)
          {
              _count++;
             if (guessNumber > _number)
             {
                 Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar!", guessNumber, MaxNumberOfGuesses - _count);        
             }

            

             if (guessNumber < _number)
             {
                 Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar!",guessNumber, MaxNumberOfGuesses - _count);
             }
             
             if (guessNumber == _number)
             {
                 Console.ForegroundColor = ConsoleColor.DarkGreen;
                 Console.WriteLine("Bra! Du gissade rätt på {0} försök!", _count);
                 Console.ResetColor();

                 return true;

             }
             if (_count == MaxNumberOfGuesses)
             {
                 Console.WriteLine("");

                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Du har gissat fel {0} gånger! Det hemliga talet är : {1}", MaxNumberOfGuesses, _number);
                 Console.ResetColor();
             }
             return false;

          }
          else
          {
              throw new ApplicationException();
          }
        }

    }
}
