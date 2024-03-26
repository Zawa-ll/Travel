using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Dtos contains only data that should be exposed to the client.
namespace Travel.API.Dtos
{
    public class TouristRoutePictureDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Guid TouristRouteId { get; set; }
    }
}
