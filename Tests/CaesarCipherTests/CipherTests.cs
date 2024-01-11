using Caesar_Cipher;

namespace Tests.CaesarCipherTests
{
    public class CipherTests
    {
        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Plain_Text()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "KhoorZruog";
            int shift = 3;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Special_Chars()
        {
            //Arrange
            string message = "Hello,World!";
            string encryptedMessage = "Khoor,Zruog!";
            int shift = 3;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Spaces()
        {
            //Arrange
            string message = "Hello Wor ld ";
            string encryptedMessage = "Khoor Zru og ";
            int shift = 3;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Numbers()
        {
            //Arrange
            string message = "HelloWorld123";
            string encryptedMessage = "KhoorZruog123";
            int shift = 3;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Shift_More_Than_26()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "KhoorZruog";
            int shift = 29;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Null()
        {
            //Arrange
            string encryptedMessage = "";
            int shift = 3;

            //Act
            string result = Cipher.Encrypt(null, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Negative_Shift()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "EbiilTloia";
            int shift = -3;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Shift_Zero()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int shift = 0;

            //Act
            string result = Cipher.Encrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Plain_Text()
        {
            //Arrange
            string encryptedMessage = "KhoorZruog";
            string decryptedMessage = "HelloWorld";
            int shift = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Special_Chars()
        {
            //Arrange
            string encryptedMessage = "Khoor,Zruog!";
            string decryptedMessage = "Hello,World!";
            int shift = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Spaces()
        {
            //Arrange
            string encryptedMessage = "Khoor Zru og";
            string decryptedMessage = "Hello Wor ld";
            int shift = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers()
        {
            //Arrange
            string encryptedMessage = "KhoorZruog123";
            string decryptedMessage = "HelloWorld123";
            int shift = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers_Shift_More_Than_26()
        {
            //Arrange
            string encryptedMessage = "KhoorZruog";
            string decryptedMessage = "HelloWorld";
            int shift = 29;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Null()
        {
            //Arrange
            string decryptedMessage = "";
            int shift = 3;

            //Act
            string result = Cipher.Decrypt(null, shift);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Negative_Shift()
        {
            //Arrange
            string message = "EbiilTloia";
            string encryptedMessage = "HelloWorld";
            int shift = -3;

            //Act
            string result = Cipher.Decrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Shift_Zero()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int shift = 0;

            //Act
            string result = Cipher.Decrypt(message, shift);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }
    }
}
