using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
    public class Orden : ICRUD<data.Orden>
    {
        private Repository<data.Orden> _repository = null;

        public Orden(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Orden>(solutionDBContext);
        }

        public void Delete(data.Orden t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Orden> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Orden GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Orden t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Orden t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
