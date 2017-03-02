using System;

namespace ClassExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User penkov = new User();
                penkov.Email = "pavel.abv.bg";
                penkov.Password = "Pavel86";
            }
            catch (InvalidEmailException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Use a longer e-mail, containing at least 6 valid characters!");
                Console.WriteLine();
            }
            catch (InvalidPasswordException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Your password must be at least 6 characters long and must contain a digit!");
            }

            try
            {
                User tsvetkov = new User();
                tsvetkov.Email = "tsvetkov@abv.bg";
                tsvetkov.Password = "tsvetkov";
            }
            catch (InvalidEmailException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Use a longer e-mail, containing at least 6 valid characters!");
                Console.WriteLine();
            }
            catch (InvalidPasswordException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Your password must be at least 6 characters long and must contain a digit!");
                Console.WriteLine();
            }

            try
            {
                User ivaylo = new User();
                ivaylo.Email = "ivaylo@abv.bg";
                ivaylo.Password = "ivaylo12345";
            }
            catch (InvalidEmailException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Use a longer e-mail, containing at least 6 valid characters!");
                Console.WriteLine();
            }
            catch (InvalidPasswordException message)
            {
                Console.WriteLine(message.Message);
                Console.WriteLine("Your password must be at least 6 characters long and must contain a digit!");
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Accepted!");
                Console.WriteLine();
            }
        }
    }
}