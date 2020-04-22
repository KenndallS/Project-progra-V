using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Detalle : ICRUD<data.Detalle>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Detalle(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Detalle t)
        {
            new Proyecto.DAL.Detalle(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Detalle> GetAll()
        {
            return new Proyecto.DAL.Detalle(_solutionDBContext).GetAll();
        }

        public data.Detalle GetOneById(int id)
        {
            return new Proyecto.DAL.Detalle(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Detalle t)
        {
            t.idDetalle = null;
            new Proyecto.DAL.Detalle(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Detalle t)
        {
            new Proyecto.DAL.Detalle(_solutionDBContext).Updated(t);
        }
    }
}
