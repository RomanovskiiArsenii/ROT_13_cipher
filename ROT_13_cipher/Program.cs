using System.Text;
class Program
{
    class ROT13
    {
        /// <summary>
        /// ROT13 представляет собой частный случай алгоритма шифрования, известного как шифр Цезаря
        /// Применение алгоритма ROT13 к части текста требует простой замены каждого буквенного символа 
        /// на соответствующий ему со сдвигом на 13 позиций в алфавите
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <returns>зашифрованное или расшифрованное сообщение</returns>
        public static string CipherDecipher(string message)
        {
            StringBuilder cipheredMsg = new StringBuilder();
            char[] messageChars = message.ToCharArray();

            foreach (var letter in messageChars)
            {
                if (Char.IsUpper(letter))
                {
                    char cifredLtr = letter <= ('A' + 12) ? (char)(letter + 13) : (char)(letter - 13); cipheredMsg.Append(cifredLtr);
                }
                else if (Char.IsLower(letter))
                {
                    char cifredLtr = letter <= ('a' + 12) ? (char)(letter + 13) : (char)(letter - 13); cipheredMsg.Append(cifredLtr);
                }
                else { cipheredMsg.Append(letter); }
            }
            return cipheredMsg.ToString();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ROT13.CipherDecipher("C# is cool!"));
        //P# vf pbby!
        Console.WriteLine(ROT13.CipherDecipher("P# vf pbby!"));
        //C# is cool!
    }
}