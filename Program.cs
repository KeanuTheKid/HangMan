namespace HangMan; // here use name of your project

class Program
{
    // No variable declarations in this area!!
    static void Main(string[] args)
    {
        // Variable declarations allowed here
        int[] lifes;
        lifes = new int[6] { 0, 0, 0, 0, 0, 0 };
        
        

        while (true)                     // The game repeats until finished by player 1
        {
            // Variable declarations allowed here
            string secretWord = ReadSecretWord();            // Player 1: Enter the secret word to be guessed by player 2
            HangTheMan();                // Screen output for a good start
            while (true)                 // Player 2: Make your guesses
            {
                Console.WriteLine(secretWord);
                ReadOneChar();           // Handle input of one char. 
                EvaluateTheSituation();  // Game Logic goes here
                HangTheMan();            // Screen output goes here
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
            int wLength = secretW.Length; //length of word
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

    static void ReadOneChar() // Modification of method declaration recommended: Add return value and parameters
                              // If there are rules and constraints on allowed secrets (e.g. no digits), make sure the input is allowed
    {
        // Variable declarations allowed here
        // Console.Write() etc. allowed here!
    }

    static void EvaluateTheSituation() // Modification of method declaration recommended: Add return value and parameters
                                       // In here, evaluate the char entered: Is it part of the secret word?
                                       // Calculate and return the game status (Hit or missed? Where? List and number of missed chars?...)
    {
        // Variable declarations allowed here
        // NO Console.Write() etc. in here!
    }

    static void QuitOrRestart() // Modification of method declaration recommended: Add return value and parameters
                                // If there are rules and constraints on allowed secrets (e.g. no digits), check them in here
    {
        // Variable declarations allowed here
        // Console.Write() etc. allowed here!
    }

    static void HangTheMan() // Modification of method declaration recommended: Add return value and parameters
                             // In here, clear the screen and redraw everything reflecting the actual game status
    {
        // Variable declarations allowed here
        // all Console.Write() etc. go here
    }
}