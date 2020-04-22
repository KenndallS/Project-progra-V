using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
    public class AspNetUsers : ICRUD<data.AspNetUsers>
    {
        private Repository<data.AspNetUsers> _repository = null;

        public AspNetUsers(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.AspNetUsers>(solutionDBContext);
        }

        public void Delete(data.AspNetUsers t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.AspNetUsers> GetAll()
        {
            return _repository.GetAll();
        }

        public data.AspNetUsers GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.AspNetUsers t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.AspNetUsers t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
