namespace DO;

[Serializable]
public class DalEntityNotFoundException : Exception
{
    public DalEntityNotFoundException(string message) : base(message) { }
}

[Serializable]
public class DalEntityAlreadyExistsException : Exception
{
    public DalEntityAlreadyExistsException(string message) : base(message) { }
}

[Serializable]
public class DalDataAccessException : Exception
{
    public DalDataAccessException(string message) : base(message) { }
}
