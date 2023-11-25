using System.Collections.Generic;
using Test_Taste_Console_Application.Domain.DataTransferObjects;
using Test_Taste_Console_Application.Domain.Objects;

namespace Test_Taste_Console_Application.Domain.Services.Interfaces
{
    ///<summary>
    /// A service that can be used to get data from the Solar System OpenData API<see href="https://api.le-systeme-solaire.net/"/>. 
    ///</summary>
    public interface IMoonService
    {
        IEnumerable<Moon> GetAllMoons();
    }
}
