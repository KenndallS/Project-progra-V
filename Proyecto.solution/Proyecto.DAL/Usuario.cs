using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;


namespace Proyecto.DAL
{
    public class Usuario : ICRUD<data.Usuario>
    {
        private Repository<data.Usuario> _repository = null;

        public Usuario(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Usuario>(solutionDBContext);
        }

        public void Delete(data.Usuario t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Usuario> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Usuario GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Usuario t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Usuario t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
