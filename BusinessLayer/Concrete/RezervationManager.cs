using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RezervationManager : IRezervationService
    {
        private readonly IRezervationDal _rezervationDal;

        public RezervationManager(IRezervationDal rezervationDal)
        {
            _rezervationDal = rezervationDal;
        }

        public Rezervation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> GetListByFilter(Expression<Func<Rezervation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> GetListWithRezervationByAccepted(int id)
        {
            return _rezervationDal.GetListWithRezervationByAccepted(id);
        }

        public List<Rezervation> GetListWithRezervationByPrevious(int id)
        {
            return _rezervationDal.GetListWithRezervationByPrevious(id);
        }

        public List<Rezervation> GetListWithRezervationByWaitApproval(int id)
        {
          return  _rezervationDal.GetListWithRezervationByWaitApproval(id);
        }

        public void TAdd(Rezervation t)
        {
            _rezervationDal.Insert(t);
        }

        public void TDelete(Rezervation t)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rezervation t)
        {
            throw new NotImplementedException();
        }

    }
}
