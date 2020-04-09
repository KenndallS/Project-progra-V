using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.DAL
{
        public class Producto : ICRUD<data.Producto>
        {
            private Repository<data.Producto> _repository = null;

            public Producto(SolutionDBContext solutionDBContext)
            {
                _repository = new Repository<data.Producto>(solutionDBContext);
            }

            public void Delete(data.Producto t)
            {
                _repository.Delete(t);
                _repository.Commit();
            }

            public IEnumerable<data.Producto> GetAll()
            {
                return _repository.GetAll();
            }

            public data.Producto GetOneById(int id)
            {
                return _repository.GetOnebyId(id);
            }

            public void Insert(data.Producto t)
            {
                _repository.Insert(t);
                _repository.Commit();
            }

            public void Updated(data.Producto t)
            {
                _repository.Update(t);
                _repository.Commit();
            }
        }
    }
