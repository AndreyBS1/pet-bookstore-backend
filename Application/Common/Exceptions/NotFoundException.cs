namespace PetBookstore.Experiment.Application.Common.Exceptions;

public class NotFoundException : CommonException
{
    public NotFoundException(string message) : base(message) { }
    public NotFoundException(List<string> messages) : base(messages) { }
}
