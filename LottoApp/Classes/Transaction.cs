using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lotto.Classes
{
    class Combination
    {
        Lotto.Context.LottoContext ctx;
         

        #region "Properties"

        private int _One;
        public int One { get { return _One; } set { _One = value; } }

        private int _Two;
        public int Two { get { return _Two; } set { _Two = value; } }

        private int _Three;
        public int Three { get { return _Three; } set { _Three = value; } }

        private int _Four;
        public int Four { get { return _Four; } set { _Four = value; } }

        private int _Five;
        public int Five { get { return _Five; } set { _Five = value; } }

        private int _Six;
        public int Six { get { return _Six; } set { _Six = value; } }
        
        #endregion

        public Combination()
        {
            try
            {
                ctx = new Context.LottoContext(System.Configuration.ConfigurationManager.ConnectionStrings["lottoConnectionString"].ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveCombination() 
        {
            try
            {
                 using(TransactionScope scope = new TransactionScope())
                 {
                    ctx.SaveCombination(0, _One, _Two, _Three, _Four, _Five, _Six, false, "INSERT");
                    scope.Complete() ;
                 }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public System.Nullable<long> GetCombinationLastId()
        {
            try
            { 
                return ctx.GetCombinationLastId();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Context.GetGameResultResult> GetGameResult(DateTime startDate, DateTime endDate, ClassGlobal.Game game)
        {
            try
            { 
                return ctx.GetGameResult(startDate.Date, endDate.Date, (int)game); 
            }
            catch (Exception)
            { 
                throw;
            }
        } 

    }
}
