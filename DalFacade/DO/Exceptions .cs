namespace DO;

// חריגה: ישות עם מזהה שלא קיים
[Serializable]
public class DalEntityNotFoundException : Exception
{
    public DalEntityNotFoundException(string message) : base(message) { }
}

// חריגה: ישות עם מזהה שכבר קיים
[Serializable]
public class DalEntityAlreadyExistsException : Exception
{
    public DalEntityAlreadyExistsException(string message) : base(message) { }
}

// חריגה: חריגה כללית עבור בעיות עם נתונים
[Serializable]
public class DalDataAccessException : Exception
{
    public DalDataAccessException(string message) : base(message) { }
}
