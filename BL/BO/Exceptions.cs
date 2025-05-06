namespace BO;

// חריגה: ישות עם מזהה שלא קיים
[Serializable]
public class BLNotFoundException : Exception
{
    public BLNotFoundException(string? message) : base(message) { }
    public BLNotFoundException(string message, Exception exception) : base(message, exception) { }
}

// חריגה: ישות עם מזהה שכבר קיים
[Serializable]
public class BLAlreadyExistsException : Exception
{
    public BLAlreadyExistsException(string? message) : base(message) { }
    public BLAlreadyExistsException(string message, Exception exception) : base(message, exception) { }
}

// חריגה: חריגה כללית עבור בעיות עם נתונים
[Serializable]
public class BLAccessException : Exception
{
    public BLAccessException(string? message) : base(message) { }
    public BLAccessException(string message, Exception exception) : base(message, exception) { }
}

