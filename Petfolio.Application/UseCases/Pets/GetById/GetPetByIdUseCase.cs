using Petfolio.Communication;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Tapioca",
            Type = PetType.Cat,
            Birthday = new DateTime(year: 2021, month: 03, day: 12)
        };
    }
}