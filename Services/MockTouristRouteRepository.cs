using Travel.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.API.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _routes;

        public MockTouristRouteRepository()
        {
            if (_routes == null)
            {
                InitializeTouristRoutes();
            }
        }

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "Mount1",
                    Description="Mount1 Description",
                    OriginalPrice = 1299,
                    Features = "<p>Food, Lodging, Travel, Shopping and Entertainment</p>",
                    Fees = "<p>Transportation at your own expense</p>",
                    Notes="<p>Watch out for danger.</p>"
                },
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "Mount2",
                    Description="Mount2 Description",
                    OriginalPrice = 1299,
                    Features = "<p>Food, Lodging, Travel, Shopping and Entertainment</p>",
                    Fees = "<p>Transportation at your own expense</p>",
                    Notes="<p>Watch out for danger.</p>"
                }
            };
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            // linq
            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
        }
    }
}
