namespace Tools;

public class LogManager
{
    const string LogPath = @"Log";
    private static string getCurrentPathFolder()
    {
        string path = $@"{LogPath}\{DateTime.Now.Year}-{DateTime.Now.Month}";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path;
    }
    private static string getCurrendPathFile()
    {
        string path = $@"{getCurrentPathFolder()}\{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}.txt";
        if (!File.Exists(path))
            File.Create(path).Close();
        return path;
    }
    public static void WriteToLog(string message, string project, string func)
    {
        using (StreamWriter sw = new StreamWriter(getCurrendPathFile(), true))
        {
            sw.WriteLine($"{DateTime.Now}\t{project}.{func}\t{message}");
        }
    }
    public static void ClearLogs()
    {
        if (!Directory.Exists(LogPath))
        {
            Console.WriteLine("Log directory does not exist.");
            return;
        }
        DateTime twoMonthsAgo = DateTime.Now.AddMonths(-2);
        foreach (var directory in Directory.GetDirectories(LogPath))
        {
            string folderName = Path.GetFileName(directory);
            try
            {
                DateTime folderDate = DateTime.Parse(folderName);
                if (folderDate < twoMonthsAgo)
                {
                    Directory.Delete(directory, true);
                    Console.WriteLine($"Deleted directory: {directory}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleted directory {directory}: {ex.Message}");
            }
        }
    }
}
