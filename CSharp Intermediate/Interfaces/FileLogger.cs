namespace CSharpIntermediate.Interfaces
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public enum messageType
        {
            ERROR,
            INFO
        }

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, messageType.ERROR);
        }

        public void LogInfo(string message)
        {
            Log(message, messageType.INFO);

        }

        public void Log(string message, messageType messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
                streamWriter.WriteLine(messageType+ ": " + message);
        }
    }
}
