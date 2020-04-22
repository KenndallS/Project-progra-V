using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
    public class Direccion : ICRUD<data.Direccion>
    {
        private Repository<data.Direccion> _repository = null;

        public Direccion(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Direccion>(solutionDBContext);
        }

        public void Delete(data.Direccion t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Direccion> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Direccion GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Direccion t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Direccion t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}

