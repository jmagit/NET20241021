using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades {
    public interface IRepsitory<E, K> {
        List<E> GetAll();
        List<E> GetBy(Func<E, bool> predicate);
        List<E> GetById(K id);
        E add(E item);
        E modify(E item);
        void delete(E item);
        void deleteById(K id);

    }

    public interface IPersonasRepository : IRepsitory<Persona, int> { }

    public interface IDomainService<E, K> {
        List<E> GetAll();
        List<E> GetBy(Func<E, bool> predicate);
        List<E> GetById(K id);
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
            throw new NotImplementedException();
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

        public List<Persona> GetById(int id) {
            throw new NotImplementedException();
        }

        public Persona modify(Persona item) {
            throw new NotImplementedException();
        }
    }
}
