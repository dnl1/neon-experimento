using SampleRestfulAPI.Interfaces;

namespace SampleRestfulAPI.Models
{
    public abstract class BaseModel : IModel
    {
        public int Id { get; set; }
    }
}