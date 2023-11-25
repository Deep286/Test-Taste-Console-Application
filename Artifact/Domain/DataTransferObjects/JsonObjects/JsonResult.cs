using System.Collections.ObjectModel;

namespace Test_Taste_Console_Application.Domain.DataTransferObjects.JsonObjects
{
    public class JsonResult<T>
    {
        public Collection<T> Bodies { get; set; }
    }
}
