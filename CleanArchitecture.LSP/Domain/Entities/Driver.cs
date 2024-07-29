namespace CleanArchitecture.LSP.Domain.Entities;
public class Driver(string name, string dispatchUri)
{
    public string Name => name;
    public string DispatchUri => dispatchUri;
}
