using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Orden : ICRUD<data.Orden>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Orden(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Orden t)
        {
            new Proyecto.DAL.Orden(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Orden> GetAll()
        {
            return new Proyecto.DAL.Orden(_solutionDBContext).GetAll();
        }

        public data.Orden GetOneById(int id)
        {
            return new Proyecto.DAL.Orden(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Orden t)
        {
            t.idOrden = null;
            new Proyecto.DAL.Orden(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Orden t)
        {
            new Proyecto.DAL.Orden(_solutionDBContext).Updated(t);
        }
    }
}
