using System;

namespace SampleRestfulAPI.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }
}