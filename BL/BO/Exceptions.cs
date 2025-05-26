namespace BO;

[Serializable]
public class BLNotFoundException : Exception
{
    public BLNotFoundException(string? message) : base(message) { }
    public BLNotFoundException(string message, Exception exception) : base(message, exception) { }
}

[Serializable]
public class BLAlreadyExistsException : Exception
{
    public BLAlreadyExistsException(string? message) : base(message) { }
    public BLAlreadyExistsException(string message, Exception exception) : base(message, exception) { }
}

[Serializable]
public class BLAccessException : Exception
{
    public BLAccessException(string? message) : base(message) { }
    public BLAccessException(string message, Exception exception) : base(message, exception) { }
}

