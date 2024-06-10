namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\yatip\source\repos\2024P4ProgCs2\FileIOOpdracht\leesdezefile.txt";

            string[] content = File.ReadAllLines(filePath);

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }

            string outputDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output");
            if (!Directory.Exists(outputDirectoryPath))
            {
                Directory.CreateDirectory(outputDirectoryPath);
            }

            string newFilePath = Path.Combine(outputDirectoryPath, "mijnnieuwefile.txt");
            string[] newContent = {
                "Dit is de eerste regel.",
                "Dit is de tweede regel."
            };
            File.WriteAllLines(newFilePath, newContent);

            string extraLine = "Dit is een extra regel.";
            File.AppendAllText(newFilePath, extraLine + Environment.NewLine);

        }
    }
}
