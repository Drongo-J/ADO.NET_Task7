using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class TicketRepository : ITicketRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public TicketRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }

        public void AddData(Ticket data)
        {
            _dataContext.Tickets.InsertOnSubmit(data);
             _dataContext.SubmitChanges();
        }

        public void DeleteData(Ticket data)
        {
            _dataContext.Tickets.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<Ticket> GetAll()
        {
            var tickets = from t in _dataContext.Tickets
                          select t;
            return new ObservableCollection<Ticket>(tickets);
        }

        public Ticket GetData(int id)
        {
            return _dataContext.Tickets.SingleOrDefault(t => t.Id == id);
        }

        public void UpdateData(Ticket data)
        {
            var item = GetData(data.Id);

            item.Id = data.Id;
            item.Name = data.Name;
            item.Airplane = data.Airplane;
            item.AirplaneId = data.AirplaneId;
            item.City = data.City;
            item.CityId = data.CityId;
            item.Schedule = data.Schedule;
            item.ScheduleId = data.ScheduleId;
            item.FlightType= data.FlightType;
            item.FlightTypeId = data.FlightTypeId;

            _dataContext.SubmitChanges();
        }
    }
}
