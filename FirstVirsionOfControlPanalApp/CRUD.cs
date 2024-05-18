using FirstVirsionOfControlPanalApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVirsionOfControlPanalApp
{
    internal class CRUD
    {
        public void Add()
        {
            // Generate Id 
            FormatId formatId = new FormatId();
            string Id = formatId.Generate();

            #region Create path, New html text, Comment to insert top or last and Lists to copy the file content
            string FilePath = @"F:\Work_Space\C#Package\FirstVirsionofstaticwebapp\ProjectFiles\index.html";
            string NewText = @$"<a href=""Details/1.html{Id}.html""><img src=""F:\Markting\المطبخ\photo_5902181966000802172_y.jpg""></a>";
            
            //Make Comment  in the end of html file to insert After this comment
            string InsertButtom = @"<!--Buttom-->";
            
            //Make Comment  in the top of html file to insert After this comment
            string InsertTop = "<!--Top-->";

            string[] Lines = File.ReadAllLines(FilePath);
            List<string> ModifiedLines = new List<string>(Lines);
            int InsertionIndex = ModifiedLines.IndexOf(InsertButtom);
            #endregion

            #region Add code to the exists html file
            if (InsertionIndex != -1)
            {
                try
                {
                    ModifiedLines.Insert(InsertionIndex - 1,@$"<!--id = {Id}-->");
                    ModifiedLines.Insert(InsertionIndex - 1, NewText);
                    File.WriteAllLines(FilePath, ModifiedLines.ToArray());
                    Console.WriteLine("File Found And Added New Text");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Somthing went Wrong. "+ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File Not Found. Please enter the correct file path");
            }
            #endregion

            #region Make a new html page to add the product details
            try
            {
                string path = @$"F:\Work_Space\C#Package\FirstVirsionofstaticwebapp\ProjectFiles\Details\{Id}.html";
                AddDetailsPage.MakePage(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing went wrong wile adding the deatails page."+ex.Message);
            }
            #endregion
        }

        public void Edit()
        {
            Console.WriteLine("Pleas enter id ");
            string Id = Console.ReadLine();
            string path = @$"F:\Work_Space\C#Package\FirstVirsionofstaticwebapp\ProjectFiles\Details\{Id}.html";

            

        }
    }
}
