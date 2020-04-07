using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Usuario : ICRUD<data.Usuario>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Usuario(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Usuario t)
        {
            new Proyecto.DAL.Usuario(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Usuario> GetAll()
        {
            return new Proyecto.DAL.Usuario(_solutionDBContext).GetAll();
        }

        public data.Usuario GetOneById(int id)
        {
            return new Proyecto.DAL.Usuario(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Usuario t)
        {
            t.idUsuario = null;
            new Proyecto.DAL.Usuario(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Usuario t)
        {
            new Proyecto.DAL.Usuario(_solutionDBContext).Updated(t);
        }
    }
}
