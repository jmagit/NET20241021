using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades {
    public interface IRepsitory<E, K> {
        List<E> GetAll();
        List<E> GetBy(Func<E, bool> predicate);
        E GetById(K id);
        E add(E item);
        E modify(E item);
        void delete(E item);
        void deleteById(K id);

    }

    public interface IPersonasRepository : IRepsitory<Persona, int> { }

    public interface IDomainService<E, K> {
        List<E> GetAll();
        List<E> GetBy(Func<E, bool> predicate);
        E GetById(K id);
        E add(E item);
        E modify(E item);
        void delete(E item);
        void deleteById(K id);

    }

    public interface IPersonasService : IDomainService<Persona, int> { }

    public class PersonasService : IPersonasService {
        private readonly IPersonasRepository dao;
        public PersonasService(IPersonasRepository dao) {
            this.dao = dao;
        }

        public Persona add(Persona item) {
            if(item == null) throw new ArgumentNullException("item");
            if(!item.IsValid())  throw new ArgumentException("Datos inválidos");
            if(GetById(item.Id) != null) throw new ArgumentException("Ya existe");
            try {
            return dao.add(item);
            } catch(Exception ex) {
                if(ex.Message.StartsWith("UNIQUE CONTRAINS"))
                    throw new ArgumentException("Datos inválidos", ex);
                throw;
            }
        }

        public void delete(Persona item) {
            throw new NotImplementedException();
        }

        public void deleteById(int id) {
            throw new NotImplementedException();
        }

        public List<Persona> GetAll() {
            throw new NotImplementedException();
        }

        public List<Persona> GetBy(Func<Persona, bool> predicate) {
            throw new NotImplementedException();
        }

        public Persona GetById(int id) {
            return dao.GetById(id);
        }

        public Persona modify(Persona item) {
            throw new NotImplementedException();
        }
    }
    public class PersonasServiceFake : IPersonasService {
        private readonly IPersonasRepository dao;
        public PersonasServiceFake(IPersonasRepository dao) {
            this.dao = dao;
        }

        public Persona add(Persona item) {
            if(item == null) throw new ArgumentNullException("item");
            if(!item.IsValid()) throw new ArgumentException("Datos inválidos");
            if(GetById(item.Id) != null) throw new ArgumentException("Ya existe");
            try {
                return dao.add(item);
            } catch(Exception ex) {
                if(ex.Message.StartsWith("UNIQUE CONTRAINS"))
                    throw new ArgumentException("Datos inválidos", ex);
                throw ex;
            }
        }

        public void delete(Persona item) {
            throw new NotImplementedException();
        }

        public void deleteById(int id) {
            throw new NotImplementedException();
        }

        public List<Persona> GetAll() {
            throw new NotImplementedException();
        }

        public List<Persona> GetBy(Func<Persona, bool> predicate) {
            throw new NotImplementedException();
        }

        public Persona GetById(int id) {
            return dao.GetById(id);
        }

        public Persona modify(Persona item) {
            throw new NotImplementedException();
        }
    }
}
