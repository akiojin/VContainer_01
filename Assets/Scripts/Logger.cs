using System;
using UnityEngine;

public class Logger : ILogger, IDisposable
{
    public Logger()
        => Debug.Log($"{nameof(Logger)} Constructor");

    void ILogger.Log(string message)
        => Debug.Log(message);

    void IDisposable.Dispose()
        => Debug.Log($"{nameof(Logger)} Dispose");
}
