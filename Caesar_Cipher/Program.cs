// See https://aka.ms/new-console-template for more information
using Caesar_Cipher;

while (true)
{
    Console.WriteLine("Welcome to the Caesar Cipher program!\r\n");
    Console.WriteLine("1. Encrypt a message\r\n");
    Console.WriteLine("2. Decrypt a message\r\n");
    Console.WriteLine("3. Exit\n");

    Console.WriteLine("Enter your choice:");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        //Encrypt message

        Console.WriteLine("Enter the message:");
        string? message = Console.ReadLine();
        Console.WriteLine("Enter the offset value:");

        int offset;
        bool offsetCorrect = int.TryParse(Console.ReadLine(), out offset);

        if (offsetCorrect)
        {
            if(offset >= 0)
            {
                Console.WriteLine($"\nEncrypted message: {Cipher.Encrypt(message, offset)}\n");
            }
            else
            {
                Console.WriteLine($"\nThe Offset needs to be positive \n");
            } 
        }
        else
        {
            Console.WriteLine("\nIncorrect input, offset must be a number ...\n");
        }
    }
    else if (choice == "2")
    {
        //Decrypt message

        Console.WriteLine("Enter the message:");
        string? message = Console.ReadLine();
        Console.WriteLine("Enter the offset value:");

        int offset;
        bool offsetCorrect = int.TryParse(Console.ReadLine(), out offset);

        if (offsetCorrect)
        {
            if (offset >= 0)
            {
                Console.WriteLine($"\nDecrypted message: {Cipher.Decrypt(message, offset)}\n");
            }
            else 
            {
                Console.WriteLine($"\nThe Offset needs to be positive \n");
            }
        }
        else
        {
            Console.WriteLine("\nIncorrect input, offset must be a number ...\n");
        }
    }
    else if (choice == "3")
    {
        //Exit message

        Console.WriteLine("\nExiting program. Goodbye!\n");
        break;
    } 
    else
    {
        //Invalid selection
        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.\n");
    }
}
