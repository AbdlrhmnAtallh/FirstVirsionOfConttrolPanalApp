using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVirsionOfControlPanalApp.Common
{
    internal class AddDetailsPage
    {
        public static void MakePage(string filePath)
        {

            try
            {
                // Create a new text file at the specified path
                using (FileStream fs = File.Create(filePath))
                {
                    // fs.Write(Encoding.UTF8.GetBytes("This is some content for the new file."));
                    fs.Write(Encoding.UTF8.GetBytes(@$"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Details</title>
</head>
<body>
    <div>
        <h1>Product name</h1>
        <h4>Id</h4>
        <h4>price</h4>
        <h4>in stock</h4>
        <h4>colors</h4>
    </div>
</body>
</html>"));
                                    
                }
                Console.WriteLine("File created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating file: " + ex.Message);
            }

        }
    }
}
