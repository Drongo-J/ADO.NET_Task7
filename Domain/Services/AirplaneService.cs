using ADO.NET_Task6.DataAccess.SqlServer;
using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.Domain.Services
{
    public class AirplaneService
    {
        private readonly IRepository<Airplane> airplaneRepository;

        public AirplaneService()
        {
            airplaneRepository = new AirplaneRepository();
        }

        public ObservableCollection<Airplane> GetAllAirplanesContaining(City city)
        {
            if (city == null)
                return null;

            var airplanes = from a in airplaneRepository.GetAll()
                            where a.Cities.Any(c => c.Name == city.Name)
                            select a;

            return new ObservableCollection<Airplane>(airplanes);
        }
    }
}
