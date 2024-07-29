using CleanArchitecture.LSP;
using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.DomainServices;
using CleanArchitecture.LSP.Domain.DTOs;
using CleanArchitecture.LSP.Domain.Entities;
using CleanArchitecture.LSP.Domain.OperationResult;
using UriBuilder = CleanArchitecture.LSP.Domain.DomainServices.UriBuilder;

RequestTravel useCase = new(new RequestMaker(), new UriBuilder());

Driver chosenDriver = new("Bob", "purplecab.com/driver/Bob");
RequestTravelRequest request = new(chosenDriver, "24 Mapple St.", DateTime.UtcNow, "ORD");

Result<RequestTravel> result = await useCase.ExecuteAsync(request);

Console.WriteLine(Serializer.Serialize(result));

chosenDriver = new("Charlie", "acme.com/driver/Charlie");
request = new(chosenDriver, "13 Oak Ave.", DateTime.UtcNow.AddHours(1), "RET");

result = await useCase.ExecuteAsync(request);

Console.WriteLine(Serializer.Serialize(result));
