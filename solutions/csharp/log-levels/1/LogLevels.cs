static class LogLine
{
    public static string Message(string logLine){
        int colonIndex = logLine.IndexOf(":");
        string message = logLine.Substring(colonIndex + 1);
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int inicio = logLine.IndexOf("[") + 1;
        int ultimo = logLine.IndexOf("]");
        int length = ultimo - inicio;
        return logLine.Substring(inicio, length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
