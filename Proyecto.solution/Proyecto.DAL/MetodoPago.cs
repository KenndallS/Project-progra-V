using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
    public class MetodoPago : ICRUD<data.MetodoPago>
    {
        private Repository<data.MetodoPago> _repository = null;

        public MetodoPago(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.MetodoPago>(solutionDBContext);
        }

        public void Delete(data.MetodoPago t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.MetodoPago> GetAll()
        {
            return _repository.GetAll();
        }

        public data.MetodoPago GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.MetodoPago t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.MetodoPago t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}

