using System.ComponentModel.DataAnnotations;

namespace HangMan; // here use name of your project

class Program
{
    // No variable declarations in this area!!
    static void Main(string[] args)
    {
        // Variable declarations allowed here
        
        while (true)                     // The game repeats until finished by player 1
        {
            // Variable declarations allowed here
           
            int lifes = 6;
            string? guessed = null;
            string? missed = null;
            string SecretWord = ReadSecretWord();            // Player 1: Enter the secret word to be guessed by player 2
            string? SecretWord_Invisible = null;
            int stop = 0;
            for (int i = 0; i < SecretWord.Length; i++)
            {
               SecretWord_Invisible = SecretWord_Invisible + "_";
            }
            HangTheMan();                // Screen output for a good start
            while (true)                 // Player 2: Make your guesses
            {
                string newChar = ReadOneChar();           // Handle input of one char. 
                EvaluateTheSituation(SecretWord,newChar, ref lifes, ref guessed, ref missed, ref SecretWord_Invisible, ref stop);  // Game Logic goes here
                HangTheMan();            // Screen output goes here
                if (stop == 1)
                {
                    break;
                }
            }
            QuitOrRestart(); // Ask if want to quit or start new game
        }
    }

    static string ReadSecretWord() // Modification of method declaration recommended: Add return value and parameters
                                   // If there are rules and constraints on allowed secrets (e.g. no digits), check them in here
    {
        Char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        while (true)
        {

            Console.Write("Enter secret word:");
            string secretW = Console.ReadLine();
            secretW = secretW.ToUpper();
            bool isValid = true;

            foreach (char c in secretW)
            {
                if (!alphabet.Contains(c))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                return secretW;
            }
            else
            {
                Console.WriteLine("Invalid word. Please try again");
            }
        }
    }

    static string ReadOneChar() // Modification of method declaration recommended: Add return value and parameters
                                // If there are rules and constraints on allowed secrets (e.g. no digits), make sure the input is allowed
    {
        // Variable declarations allowed here

        Char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        while (true)
        {

            Console.Write("Enter Char:");
            string Char = Console.ReadLine();
            Char = Char.ToUpper();
            bool isValid = true;

            if (Char.Length != 1)
            {
                isValid = false;
                Console.WriteLine("Please enter only one character");
                
            }
            else
            {
                foreach (char c in Char)
                {
                    if (!alphabet.Contains(c))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    return Char;
                }
                else
                {
                    Console.WriteLine("Only letters allowed. Please try again");
                }
            }
        }

        // Console.Write() etc. allowed here!
    }

    static void EvaluateTheSituation(string SecretWord, string newChar, ref int lifes, ref string guessed, ref string missed, ref string SecretWord_Invisible, ref int stop) // Modification of method declaration recommended: Add return value and parameters
                                       // In here, evaluate the char entered: Is it part of the secret word?
                                       // Calculate and return the game status (Hit or missed? Where? List and number of missed chars?...)
    {
        
        char[] secretWordArray = SecretWord.ToCharArray();
        char[] secretWordInvisibleArray = SecretWord_Invisible.ToCharArray();

        // Variable declarations allowed here

        if (!SecretWord.Contains(newChar))
            {
            lifes--;
            Console.WriteLine("not contained");
            Console.WriteLine(lifes);   //test
            missed = missed+newChar; 
           
            }
            else
            {
                Console.WriteLine("contained");
                guessed = guessed+newChar; 
            for (int i = 0; i < secretWordArray.Length; i++)
            {
                if (secretWordArray[i].ToString() == newChar)
                {
                    secretWordInvisibleArray[i] = secretWordArray[i];
                }
            }
            SecretWord_Invisible = new string(secretWordInvisibleArray);
            Console.WriteLine(SecretWord_Invisible); //test
        }
            
            if(lifes <= 0)
        {
            stop = 1;
            Console.WriteLine("game over");
        }
        if (SecretWord == SecretWord_Invisible)
            {
            stop = 1;
            Console.WriteLine("Good Job!");
        }



        // NO Console.Write() etc. in here!
    }



    static void HangTheMan() // Modification of method declaration recommended: Add return value and parameters
                             // In here, clear the screen and redraw everything reflecting the actual game status
    {
        // Variable declarations allowed here
        // all Console.Write() etc. go here
    }
    static void QuitOrRestart() // Modification of method declaration recommended: Add return value and parameters
                                // If there are rules and constraints on allowed secrets (e.g. no digits), check them in here
    {
        Char[] validNUM = { '1', '2' };
  
        foreach (char c in validNUM)
        {
            if (validNUM.Contains(c))
            {
                while (true)
                {
                    Console.WriteLine("1: Quit or 2: Restart?");
                    string QuitOrRestart = Console.ReadLine();
                    if (QuitOrRestart == "1")
                    {
                        Console.WriteLine("Bye Bye");
                        Environment.Exit(0);
                    }
                    else if (QuitOrRestart == "2")
                    {
                        Console.WriteLine("Restart initiated");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Please try again.");
                    }
                }

            }
        }



        // Variable declarations allowed here
        // Console.Write() etc. allowed here!
    }

    
}