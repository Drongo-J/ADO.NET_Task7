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
    public class ScheduleService
    {
        private readonly IRepository<Schedule> scheduleRepository;
        private readonly IRepository<City> cityRepository;

        public ScheduleService()
        {
            scheduleRepository = new ScheduleRepository();
            cityRepository = new CityRepository();
        }

        public ObservableCollection<Schedule> GetAllSchedulesContaining(Airplane airplane)
        {
            if (airplane == null)
                return null;

            var schedules = from s in scheduleRepository.GetAll()
                            from c in cityRepository.GetAll()
                            where c.AirplaneId == airplane.Id
                            where c.ScheduleId == s.Id
                            select s;

            return new ObservableCollection<Schedule>(schedules.Distinct());
        }

        public ObservableCollection<Schedule> GetAllSchedulesContaining(City city)
        {
            if (city == null)
                return null;

            var schedules = from s in scheduleRepository.GetAll()
                            where s.Cities.Any(c => c.Name == city.Name)
                            select s;
            return new ObservableCollection<Schedule>(schedules);
        }
    }
}
