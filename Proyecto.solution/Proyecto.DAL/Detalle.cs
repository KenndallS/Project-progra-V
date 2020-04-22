using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
    public class Detalle : ICRUD<data.Detalle>
    {
        private Repository<data.Detalle> _repository = null;

        public Detalle(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Detalle>(solutionDBContext);
        }

        public void Delete(data.Detalle t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Detalle> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Detalle GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Detalle t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Detalle t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
