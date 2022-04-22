﻿using AR.Data.Interfaces;
using AR.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace AR.Data.Imp
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPricipal _db;

        public ClienteRepository(ContextoPricipal db)
        {
            _db = db;
        }

        public async Task Add(Cliente entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Cliente;
        }
    }
}
