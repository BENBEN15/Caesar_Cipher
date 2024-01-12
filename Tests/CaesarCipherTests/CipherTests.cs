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
            int offset = 3;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Special_Chars()
        {
            //Arrange
            string message = "Hello,World!";
            string encryptedMessage = "Khoor,Zruog!";
            int offset = 3;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Spaces()
        {
            //Arrange
            string message = "Hello Wor ld ";
            string encryptedMessage = "Khoor Zru og ";
            int offset = 3;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Numbers()
        {
            //Arrange
            string message = "HelloWorld123";
            string encryptedMessage = "KhoorZruog123";
            int offset = 3;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_More_Than_26()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "LippsAsvph";
            int offset = 30;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Null()
        {
            //Arrange
            string encryptedMessage = "";
            int offset = 3;

            //Act
            string result = Cipher.Encrypt(null, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_Zero()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int offset = 0;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_High()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "CzggjRjmgy";
            int offset = 12345;

            //Act
            string result = Cipher.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Plain_Text()
        {
            //Arrange
            string encryptedMessage = "KhoorZruog";
            string decryptedMessage = "HelloWorld";
            int offset = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Special_Chars()
        {
            //Arrange
            string encryptedMessage = "Khoor,Zruog!";
            string decryptedMessage = "Hello,World!";
            int offset = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Spaces()
        {
            //Arrange
            string encryptedMessage = "Khoor Zru og";
            string decryptedMessage = "Hello Wor ld";
            int offset = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers()
        {
            //Arrange
            string encryptedMessage = "KhoorZruog123";
            string decryptedMessage = "HelloWorld123";
            int offset = 3;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers_offset_More_Than_26()
        {
            //Arrange
            string encryptedMessage = "LippsAsvph";
            string decryptedMessage = "HelloWorld";
            int offset = 30;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Null()
        {
            //Arrange
            string decryptedMessage = "";
            int offset = 3;

            //Act
            string result = Cipher.Decrypt(null, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_offset_Zero()
        {
            //Arrange
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int offset = 0;

            //Act
            string result = Cipher.Decrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_offset_High()
        {
            //Arrange
            string decryptedMessage = "HelloWorld";
            string encryptedMessage = "CzggjRjmgy";
            int offset = 12345;

            //Act
            string result = Cipher.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }
    }
}
