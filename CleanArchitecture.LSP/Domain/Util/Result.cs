namespace CleanArchitecture.LSP.Domain.Util;
public record Result<T>(bool Success) where T : class
{
}
