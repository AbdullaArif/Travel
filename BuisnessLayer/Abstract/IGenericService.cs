﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T item);
        void TDelete(T item);
        void TUpdate(T item);
        List<T> TGetList();
        T TGetById(int id);
        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
