﻿using BackEnd.Models;
using BackEnd.Repository;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Service
{
    public class CollectionService : ICollectionService
    {
        private readonly ICollectionRepository _repository;
        public CollectionService(ICollectionRepository repository)
        {
            _repository = repository;
        }

        public Task DeleteCollectionAsync(long id)
        {
            return _repository.DeleteCollectionAsync(id);
        }

        public Task<IEnumerable<Collection>> GetAllCollectionsAsync()
        {
            return _repository.GetAllCollectionsAsync();
        }

        public Task<Collection> GetCollectionByIdAsync(long id)
        {
            return _repository.GetCollectionByIdAsync(id);
        }

        public Task SaveCollectionAsync(Collection collection)
        {
            return _repository.SaveCollectionAsync(collection);
        }

        public Task UpdateCollectionAsync(Collection collection)
        {
            return _repository.UpdateCollectionAsync(collection);
        }
    }
}
