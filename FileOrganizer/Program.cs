using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("############################################### FILE ORGANIZER #########################################################");
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("####################################### [Created by: Leonardo Dias Leal] ###############################################");
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("########################################################################################################################");
            await Task.Delay(3000);
            MvFiles();
            Console.ReadKey();
        }
        private static async void MvFiles()
        {
            int imgFile = 0;
            int textFile = 0;
            int musicFile = 0;
            int vidFile = 0;
            FileInfo[] files;
            Console.WriteLine("Movendo...");
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            DirectoryInfo dir = new DirectoryInfo($"C:\\Users\\{userName}\\Downloads");
            files = dir.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach(var item in files)
            {
                if (item.Name.Contains(".jpg")
                    || item.Name.Contains(".jpeg")
                    || item.Name.Contains(".png")
                    || item.Name.Contains(".bmp")
                    || item.Name.Contains(".tiff")
                    || item.Name.Contains(".jpg")
                    || item.Name.Contains(".raw")
                    || item.Name.Contains(".psd")
                    || item.Name.Contains(".svg")
                    || item.Name.Contains(".ico")
                    || item.Name.Contains(".gif"))
                {
                    File.Move(item.FullName, $"C:\\{userName}\\Pictures");
                    imgFile++;
                }
                else if (item.Name.Contains(".doc")
                     || item.Name.Contains(".csv")
                     || item.Name.Contains(".xls")
                     || item.Name.Contains(".ppt")
                     || item.Name.Contains(".txt")
                     || item.Name.Contains(".pdf"))
                {
                    File.Move(item.FullName, $"C:\\{userName}\\Documents");
                    textFile++;
                }
                else if (item.Name.Contains(".avi")
                     || item.Name.Contains(".mkv")
                     || item.Name.Contains(".mp4")
                     || item.Name.Contains(".mpeg"))
                {
                    File.Move(item.FullName, $"C:\\{userName}\\Videos");
                    vidFile++;
                }
                else if (item.Name.Contains(".aac")
                     || item.Name.Contains(".wav")
                     || item.Name.Contains(".mp3")
                     || item.Name.Contains(".ogg"))
                {
                    File.Move(item.FullName, $"C:\\{userName}\\Music");
                    musicFile++;
                }
            }
            Console.WriteLine("Processo finalizado!");
            Console.WriteLine("Movidos: ");
            Console.WriteLine($"Imagens: {imgFile}");
            Console.WriteLine($"Arquivos:{textFile}");
            Console.WriteLine($"Músicas: {musicFile}");
            Console.WriteLine($"Vídeos:  {vidFile}");
        }
    }
}
