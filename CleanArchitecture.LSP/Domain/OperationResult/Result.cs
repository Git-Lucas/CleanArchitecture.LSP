namespace CleanArchitecture.LSP.Domain.OperationResult;
public record Result<T>(bool Success) where T : class
{
}
