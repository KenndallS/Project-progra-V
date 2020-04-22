using Proyecto.DAL.EF;
using Proyecto.DAL.Repository;
using Proyecto.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Proyecto.DO.Objects;

namespace Proyecto.BS
{
    public class AspNetUsers : ICRUD<data.AspNetUsers>
    {
        private SolutionDBContext _solutionDBContext = null;

        public AspNetUsers(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.AspNetUsers t)
        {
            new Proyecto.DAL.AspNetUsers(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.AspNetUsers> GetAll()
        {
            return new Proyecto.DAL.AspNetUsers(_solutionDBContext).GetAll();
        }

        public data.AspNetUsers GetOneById(int id)
        {
            return new Proyecto.DAL.AspNetUsers(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.AspNetUsers t)
        {
            new Proyecto.DAL.AspNetUsers(_solutionDBContext).Insert(t);
        }

        public void Updated(data.AspNetUsers t)
        {
            new Proyecto.DAL.AspNetUsers(_solutionDBContext).Updated(t);
        }
    }
}
