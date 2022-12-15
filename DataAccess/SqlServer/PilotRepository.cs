using ADO.NET_Task6.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.DataAccess.SqlServer
{
    public class PilotRepository : IPilotRepository
    {
        private AirportDataClassesDataContextDataContext _dataContext;

        public PilotRepository()
        {
            _dataContext = new AirportDataClassesDataContextDataContext();
        }
        public void AddData(Pilot data)
        {
            _dataContext.Pilots.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(Pilot data)
        {
            _dataContext.Pilots.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<Pilot> GetAll()
        {
            var pilots = from p in _dataContext.Pilots
                         select p;
            return new ObservableCollection<Pilot>(pilots);
        }

        public Pilot GetData(int id)
        {
            return _dataContext.Pilots.SingleOrDefault(p => p.Id == id);
        }

        public void UpdateData(Pilot data)
        {
            var item = GetData(data.Id);    

            item.Id = data.Id;  
            item.Name = data.Name;
            item.Surname = data.Surname;
            item.Airplanes = data.Airplanes;

            _dataContext.SubmitChanges();
        }
    }
}
