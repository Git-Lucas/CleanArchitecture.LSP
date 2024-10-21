namespace CleanArchitecture.LSP.Application;
public record Result<T>(bool Success) where T : class
{
}
