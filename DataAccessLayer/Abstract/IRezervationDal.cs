using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRezervationDal : IGenaricDal<Rezervation>
    {
        List<Rezervation> GetListWithRezervationByWaitApproval(int id); //onay bekleyen rezervasyonlar
        List<Rezervation> GetListWithRezervationByAccepted(int id);  // onaylanmış rezervasyonlar
        List<Rezervation> GetListWithRezervationByPrevious(int id); //önceki rezervasyonlar
    }
}
