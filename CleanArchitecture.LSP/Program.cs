﻿using CleanArchitecture.LSP;
using CleanArchitecture.LSP.Application.UseCases;
using CleanArchitecture.LSP.Domain.Drivers.Entities;
using CleanArchitecture.LSP.Domain.RideHailings.Actions.RequestsTravel.DTOs;
using CleanArchitecture.LSP.Domain.Util;


//Request 1
Driver chosenDriver = new("Bob", "purplecab.com/driver/Bob");
RequestTravelRequest request = new("Lucas", 
                                   new(chosenDriver, "24 Mapple St.", DateTime.UtcNow, "ORD"));

await ExecuteAsync(request);

//-------------------------------------------------------------------------------------------

//Request 2
chosenDriver = new("Charlie", "acme.com/driver/Charlie");
request = new("Lucas", 
              new(chosenDriver, "13 Oak Ave.", DateTime.UtcNow.AddHours(1), "RET"));

await ExecuteAsync(request);

//-------------------------------------------------------------------------------------------

//Execution
async static Task ExecuteAsync(RequestTravelRequest request)
{
    Result<RequestTravel> result = await Controller.RequestTravelAsync(request);

    Console.WriteLine(Serializer.Serialize(result));
}