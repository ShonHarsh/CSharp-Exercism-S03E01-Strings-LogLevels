using System;

static class LogLine
{
    /*
     * Implement the (static) LogLine.Message() method to return a log line's message:
     * LogLine.Message("[ERROR]: Invalid operation")
     * // => "Invalid operation"
     * 
     * Any leading or trailing white space should be removed:
     * LogLine.Message("[WARNING]:  Disk almost full\r\n")
     * // => "Disk almost full"
     */
    public static string Message(string logLine)
    {
        //Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".
        string[] logLevelAndMessage = logLine.Split(':', StringSplitOptions.TrimEntries);

        //get the message
        string message = logLevelAndMessage[1];

        //trim
        message = message.Trim();

        //return
        return message;

        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    /*
     * Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:
     * LogLine.LogLevel("[ERROR]: Invalid operation")
     * // => "error"
     */
    public static string LogLevel(string logLine)
    {
        //Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".
        string[] logLevelAndMessage = logLine.Split(':', StringSplitOptions.TrimEntries);

        //get the log level
        string logLevel = logLevelAndMessage[0];

        //remove the log level brackets
        logLevel = logLevel.Replace("[", string.Empty).Replace("]", string.Empty);

        //manipulate string
        logLevel = logLevel.ToLower().Trim();

        //return
        return logLevel;

        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    /*
     * Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:
     * LogLine.Reformat("[INFO]: Operation completed")
     * // => "Operation completed (info)"
    */
    public static string Reformat(string logLine)
    {
        //call previous methods
        string message = LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ")";

        //return
        return message;

        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
