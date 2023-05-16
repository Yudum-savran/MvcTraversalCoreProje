using BusinessLayer.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.UowConcrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAcountDal _acountDal;
        private readonly IUowDal _uowDal;

        public AccountManager(IAcountDal acountDal, IUowDal uowDal)
        {
            _acountDal = acountDal;
            _uowDal = uowDal;
        }

        public Account TGetById(int id)
        {
           return _acountDal.GetById(id);

        }

        public void TInsert(Account t)
        {
            _acountDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _acountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _acountDal.Update(t);
            _uowDal.Save();

        }
    }
}
