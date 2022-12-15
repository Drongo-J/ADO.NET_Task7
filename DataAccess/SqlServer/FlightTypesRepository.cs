using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class FlightTypesRepository : IFlightTypeRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public FlightTypesRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }

        public void AddData(FlightType data)
        {
            _dataContext.FlightTypes.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(FlightType data)
        {
            _dataContext.FlightTypes.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<FlightType> GetAll()
        {
            var flightTypes = from f in _dataContext.FlightTypes
                              select f;
            return new ObservableCollection<FlightType>(flightTypes);
        }

        public FlightType GetData(int id)
        {
            return _dataContext.FlightTypes.SingleOrDefault(f => f.Id == id);
        }

        public void UpdateData(FlightType data)
        {
            var item = GetData(data.Id);

            item.Id= data.Id;
            item.Tickets = data.Tickets;
            item.Type = data.Type;

            _dataContext.SubmitChanges();
        }
    }
}
