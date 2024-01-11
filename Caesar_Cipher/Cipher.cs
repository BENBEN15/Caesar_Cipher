using System.Text;

namespace Caesar_Cipher
{
    public static class Cipher
    {
        private const int ALPHABET_SIZE = 26;

        public static string Encrypt(string? message, int shift)
        {
            //Parameters validation
            if (message == null) return "";
            if (string.IsNullOrEmpty(message) || shift == 0) return message;

            //Encrypting

            StringBuilder encryptedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (Char.IsLetter(c)) 
                {
                    //Char incrementation, Modulo is used to stay within the range of the alphabet
                    char shiftedChar = (char) (c + (shift % ALPHABET_SIZE));
                    encryptedMessage.Append(shiftedChar);
                } 
                else
                {
                    encryptedMessage.Append(c);
                }
            }

            return encryptedMessage.ToString();
        }

        public static string Decrypt(string? encryptedMessage, int shift)
        {
            //Parameters validation
            if (encryptedMessage == null) return "";
            if (string.IsNullOrEmpty(encryptedMessage) || shift == 0) return encryptedMessage;

            //Decryptring

            StringBuilder decryptedMessage = new StringBuilder();

            foreach (char c in encryptedMessage)
            {
                if (Char.IsLetter(c))
                {
                    //Char decrementation, Modulo is used to stay within the range of the alphabet
                    char shiftedChar = (char)(c - (shift % ALPHABET_SIZE));
                    decryptedMessage.Append(shiftedChar);
                }
                else
                {
                    decryptedMessage.Append(c);
                }
            }

            return decryptedMessage.ToString();
        }
    }
}
