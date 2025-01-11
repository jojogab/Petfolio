using Petfolio.Communication.Responses;
using System.Runtime.InteropServices;

namespace Petfolio.Application.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Rex",
                        Type = Communication.Enums.PetType.Dog
                    },
                    new ResponseShortPetJson
                    {
                        Id = 2,
                        Name = "Mia",
                        Type = Communication.Enums.PetType.Cat
                    }
                }
            };
        }
    }
}

