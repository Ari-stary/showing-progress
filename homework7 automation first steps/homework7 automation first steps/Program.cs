using System;
using System.Diagnostics;


namespace StartUpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] programstostart =
            {
                @"""C:\Users\aripa\AppData\Local\Discord\app-1.0.9162\Discord.exe"""

            };
            foreach (var programs in programstostart)
            {
                try
                {
                    Process.Start(programs);
                    Console.WriteLine($"Started: {programs}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Program: {programs}: {ex.Message}");
                }
            }
            string[] urlstostart =
            {
                @"""https://chatgpt.com""",
                @"""https://chatgpt.com""",
                @"""https://www.youtube.com/""",
              @"""https://www.google.com/search?q=translate&rlz=1C1CHBF_deDE893DE893&oq=tra&gs_lcrp=EgZjaHJvbWUqDggAEEUYJxg7GIAEGIoFMg4IABBFGCcYOxiABBiKBTIOCAEQRRg5GEMYgAQYigUyEggCEAAYQxiDARixAxiABBiKBTIYCAMQLhhDGIMBGMcBGLEDGNEDGIAEGIoFMgwIBBAAGEMYgAQYigUyDAgFEAAYQxiABBiKBTINCAYQABiDARixAxiABDIMCAcQABhDGIAEGIoFMgwICBAAGEMYgAQYigUyBwgJEAAYjwLSAQkxMjc4ajBqMTWoAgiwAgE&sourceid=chrome&ie=UTF-8""",
               @"""https://tryhackme.com/dashboard"""
            };
            string chrome = @"""C:\Program Files (x86)\Google\Chrome\Application\chrome.exe""";
            foreach (var urls in urlstostart)
            {
                try
                {
                    Process.Start(chrome, urls);
                    Console.WriteLine($"Started: {urls}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {urls} {ex.Message}");
                }
            }
        }
        
    }
}