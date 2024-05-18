using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FirstVirsionOfControlPanalApp.Common
{
    internal class FormatId
    {
        private const string IdFilePath = @"F:\Work_Space\C#Package\FirstVirsionofstaticwebapp\ProjectFiles\Id.txt";
        private static string[] Lines;
        private List<string> IdList = new List<string>();
        /// Initializes a new instance of the FormatId class.
        /// Attempts to read existing ID data from the specified file path.
        public FormatId()
        {
            try
            {
                Lines = File.ReadAllLines(IdFilePath);

                // Converts the array of lines read from the file into a List<string> for potentially easier manipulation.
                IdList = new List<string>(Lines);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Error: File '{IdFilePath}' not found. {ex.Message}");
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error: Access denied to file '{IdFilePath}'. {ex.Message}");
            }
           
        }

        public string Generate()
        {
            Random random = new Random();
            string NewId = "";

            while (IdList.Contains(NewId)||NewId.Length <3 || NewId.Length >7 )
            {
                NewId = random.Next(0, 1000).ToString();
            }
            
            return NewId;
        }
    }
}
