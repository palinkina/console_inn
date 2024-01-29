using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;

namespace generatorINN
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new INNGenForm());


            int count = 1;
            List<InnData> numberinn = new List<InnData>();
            for (int i = 0; i < count; i++)
            {
                numberinn.Add(new InnData(InnHelper.GenerateRandomString(10))
                {
                });
            }
            string filename = "inn.json";
            StreamWriter writer = new StreamWriter(filename);
            if (filename == "inn.json")
                {
                writeInnToJsonFile(numberinn, writer);
                }
                


            static void writeInnToJsonFile(List<InnData> numberinn, StreamWriter writer)
            {
                writer.Write(JsonConvert.SerializeObject(numberinn, Newtonsoft.Json.Formatting.Indented));
            }
        }
    }
}