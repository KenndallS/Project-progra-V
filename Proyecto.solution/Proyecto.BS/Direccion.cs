using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Direccion : ICRUD<data.Direccion>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Direccion(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Direccion t)
        {
            new Proyecto.DAL.Direccion(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Direccion> GetAll()
        {
            return new Proyecto.DAL.Direccion(_solutionDBContext).GetAll();
        }

        public data.Direccion GetOneById(int id)
        {
            return new Proyecto.DAL.Direccion(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Direccion t)
        {
            t.idDireccion = null;
            new Proyecto.DAL.Direccion(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Direccion t)
        {
            new Proyecto.DAL.Direccion(_solutionDBContext).Updated(t);
        }
    }
}
