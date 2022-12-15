using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class CityRepository : ICityRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public CityRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }

        public void AddData(City data)
        {
            _dataContext.Cities.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(City data)
        {
            _dataContext.Cities.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<City> GetAll()
        {
            var cities = from c in _dataContext.Cities
                         select c;
            return new ObservableCollection<City>(cities);
        }

        public City GetData(int id)
        {
            return _dataContext.Cities.SingleOrDefault(c => c.Id == id);
        }

        public void UpdateData(City data)
        {
            var item = GetData(data.Id);

            item.Id = data.Id;
            item.Name = data.Name;
            item.Airplane = data.Airplane;
            item.AirplaneId = data.AirplaneId;
            item.ScheduleId = data.ScheduleId;
            item.Schedule = data.Schedule;
            item.Tickets = data.Tickets;

            _dataContext.SubmitChanges();
        }
    }
}
