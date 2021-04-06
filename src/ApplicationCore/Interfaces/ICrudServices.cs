﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;
using Inventura.ApplicationCore.Entities;
using Inventura.ApplicationCore.Specifications.FoodProduct;

namespace Inventura.ApplicationCore.Interfaces
{
    public interface ICrudServices<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<ListEntity<T>> GetAsync(Specification<T> filterSpec, Specification<T> pagedSpec);
        Task<T> GetAsync(int id);
        Task<T> PostAsync(T t);
        Task<T> PutAsync(T t);
        Task<bool> DeleteAsync(int id);
    }
}