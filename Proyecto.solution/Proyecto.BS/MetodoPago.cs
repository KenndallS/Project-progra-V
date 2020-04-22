using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class MetodoPago : ICRUD<data.MetodoPago>
    {
        private SolutionDBContext _solutionDBContext = null;

        public MetodoPago(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.MetodoPago t)
        {
            new Proyecto.DAL.MetodoPago(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.MetodoPago> GetAll()
        {
            return new Proyecto.DAL.MetodoPago(_solutionDBContext).GetAll();
        }

        public data.MetodoPago GetOneById(int id)
        {
            return new Proyecto.DAL.MetodoPago(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.MetodoPago t)
        {
            t.idMetodoPago = null;
            new Proyecto.DAL.MetodoPago(_solutionDBContext).Insert(t);
        }

        public void Updated(data.MetodoPago t)
        {
            new Proyecto.DAL.MetodoPago(_solutionDBContext).Updated(t);
        }
    }
}
