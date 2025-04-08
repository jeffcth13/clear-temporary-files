using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTempFiles.ExecutionMethod
{
    internal class ClearMethod
    {
        public static void ClearAll()
        {
            string tempPath = Path.GetTempPath();
            ClearFiles(tempPath);
            ClearSubDirectories(tempPath);
            Console.WriteLine($"---暫存檔清除作業已完成。");
            Console.Read();
        }

        private static void ClearFiles(string tempPath)
        {
            Console.WriteLine($"當前暫存檔路徑位置：{tempPath}");
            string[] files = Directory.GetFiles(tempPath);
            if (files.Length != 0)
            {
                Console.WriteLine($"當前路徑共有 {files.Length} 個暫存檔待刪除。");
                Console.WriteLine($"刪除作業進行中......");
                int filesCount = 0;
                foreach (string file in files)
                {
                    try
                    {
                        File.Delete(file);
                        if (!File.Exists(file))
                        {
                            Console.WriteLine($"已刪除 {file}");
                            filesCount++;
                        }
                    }
                    catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is System.Security.SecurityException)
                    {
                        Console.WriteLine($"刪除暫存檔 {file} 時發生錯誤：{ex.Message}");
                        //Console.WriteLine($"刪除暫存檔時發生錯誤 -> {ex.Message}");
                    }
                }
                Console.WriteLine($"刪除作業完成，共刪除 {filesCount} 個暫存檔案。");
            }
            else
            {
                Console.WriteLine($"當前路徑暫無暫存檔產生可供刪除。");
            }
            //Console.WriteLine();
        }

        private static void ClearSubDirectories(string tempPath)
        {
            string[] subDirectories = Directory.GetDirectories(tempPath);
            if (subDirectories.Length != 0)
            {
                foreach (string subDiretory in subDirectories)
                {
                    try
                    {
                        ClearSubDirectories(subDiretory);
                        ClearFiles(subDiretory);
                        if (Directory.Exists(subDiretory))
                        {
                            Directory.Delete(subDiretory, true);
                            Console.WriteLine($"已刪除空目錄 {subDiretory}\n");
                        }
                    }
                    catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is System.Security.SecurityException)
                    {
                        Console.WriteLine($"刪除子目錄 {subDiretory} 時發生錯誤：{ex.Message}");
                        //Console.WriteLine($"刪除子目錄時發生錯誤 -> {ex.Message}");
                    }
                }
            }
        }
    } 
}

//            else
//{
//    Console.WriteLine($"當前路徑無其他子目錄產生可供刪除。\n");
//}
