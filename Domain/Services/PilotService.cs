using ADO.NET_Task6.DataAccess.SqlServer;
using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.Domain.Services
{
    public class PilotService
    {
        private readonly IRepository<Pilot> pilotRepository;
        private readonly IRepository<City> cityRepository;
        private readonly IRepository<Airplane> airplaneRepository;
        private readonly IRepository<Schedule> scheduleRepository;

        public PilotService()
        {
            pilotRepository = new PilotRepository();
            cityRepository = new CityRepository();
            airplaneRepository = new AirplaneRepository();
            scheduleRepository = new ScheduleRepository();
        }
            
        public Pilot GetPilot(City city, Airplane airplane, Schedule schedule)
        {
            var pilot = from p in pilotRepository.GetAll()
                        where p.Airplanes.Any(a => a.Id == airplane.Id)
                        where city.AirplaneId == airplane.Id
                        where city.ScheduleId == schedule.Id
                        select p;
            return pilot.First();
        }
    }
}
