namespace AutoService.Core.Exceptions;

public class NotFoundException:Exception
{
    public NotFoundException(string name) : base($"Record not found, or doesn't exist in table {name}")
    {
    }
}