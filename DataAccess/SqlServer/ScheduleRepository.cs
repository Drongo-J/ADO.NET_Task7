using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class ScheduleRepository : IScheduleRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public ScheduleRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }

        public void AddData(Schedule data)
        {
            _dataContext.Schedules.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(Schedule data)
        {
            _dataContext.Schedules.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<Schedule> GetAll()
        {
            var schedules = from s in _dataContext.Schedules
                            select s;
            return new ObservableCollection<Schedule>(schedules);
        }

        public Schedule GetData(int id)
        {
            return _dataContext.Schedules.SingleOrDefault(s => s.Id == id);
        }

        public void UpdateData(Schedule data)
        {
            var item = GetData(data.Id);

            item.Id = data.Id;
            item.StartDateTime = data.StartDateTime;
            item.Tickets = data.Tickets;
            item.Cities = data.Cities;

            _dataContext.SubmitChanges();
        }
    }
}
