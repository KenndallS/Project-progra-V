using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class Carrito : ICRUD<data.Carrito>
    {
        private SolutionDBContext _solutionDBContext = null;

        public Carrito(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Carrito t)
        {
            new Proyecto.DAL.Carrito(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Carrito> GetAll()
        {
            return new Proyecto.DAL.Carrito(_solutionDBContext).GetAll();
        }

        public data.Carrito GetOneById(int id)
        {
            return new Proyecto.DAL.Carrito(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Carrito t)
        {
            t.idCarrito = null;
            new Proyecto.DAL.Carrito(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Carrito t)
        {
            new Proyecto.DAL.Carrito(_solutionDBContext).Updated(t);
        }
    }
}
