using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Producto : ICRUD<data.Producto>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Producto(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Producto t)
        {
            new Proyecto.DAL.Producto(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Producto> GetAll()
        {
            return new Proyecto.DAL.Producto(_solutionDBContext).GetAll();
        }

        public data.Producto GetOneById(int id)
        {
            return new Proyecto.DAL.Producto(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Producto t)
        {
            t.idProducto = null;
            new Proyecto.DAL.Producto(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Producto t)
        {
            new Proyecto.DAL.Producto(_solutionDBContext).Updated(t);
        }
    }
}
