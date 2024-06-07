namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repositoryPath = @"C:\Users\yatip\source\repos\2024P4ProgCs2";

            DirectoryInfo dir = new DirectoryInfo(repositoryPath);

            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i].Name);
            }

            DirectoryInfo[] directories = dir.GetDirectories();

            // Laat alle directories zien met een WriteLine en een for loop
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i].Name);
            }
        }
    }
}
