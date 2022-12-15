using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class AirplaneRepository : IAirplaneRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public AirplaneRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }

        public void AddData(Airplane data)
        {
            _dataContext.Airplanes.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(Airplane data)
        {
            _dataContext.Airplanes.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<Airplane> GetAll()
        {
            var airplanes = from a in _dataContext.Airplanes
                            select a;
            return new ObservableCollection<Airplane>(airplanes);
        }

        public Airplane GetData(int id)
        {
            return _dataContext.Airplanes.SingleOrDefault(a => a.Id == id);
        }

        public void UpdateData(Airplane data)
        {
            var item = GetData(data.Id);

            item.Id = data.Id;
            item.Name = data.Name;
            item.PassengerCount = data.PassengerCount;
            item.PilotId = data.PilotId;
            item.Cities = data.Cities;
            item.Tickets = data.Tickets;
            item.Pilot = data.Pilot;

            _dataContext.SubmitChanges();
        }
    }
}
