namespace PetBookstore.Application.Common.Exceptions;

public class CommonException : Exception
{
    private readonly List<string> _errors = new List<string>();

    public IReadOnlyCollection<string> Errors => this._errors.AsReadOnly();

    public CommonException(string message) : base(message)
    {
        this._errors.Add(message);
    }

    public CommonException(List<string> messages) : base(string.Join(';', messages))
    {
        this._errors.AddRange(messages);
    }
}
