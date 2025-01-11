using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Benji",
                BirthDay = new DateTime(year: 2012, month: 10, day: 14),
                Type = Communication.Enums.PetType.Dog
            };
        }
    }
}
