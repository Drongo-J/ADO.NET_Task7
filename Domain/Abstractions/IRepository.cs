﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task6.Domain.Abstractions
{
    public interface IRepository<T>
    {
        T GetData(int id);
        ObservableCollection<T> GetAll();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
