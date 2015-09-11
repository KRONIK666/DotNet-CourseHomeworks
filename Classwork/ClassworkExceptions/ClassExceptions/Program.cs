using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User penkov = new User();
                penkov.Email = "el_pablo.abv.bg";
                penkov.Password = "Penkov86";
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
                tsvetkov.Email = "kronik@abv.bg";
                tsvetkov.Password = "slipknot";
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
                ivaylo.Email = "kronik@abv.bg";
                ivaylo.Password = "slipknot1725";
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