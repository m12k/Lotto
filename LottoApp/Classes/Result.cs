using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lotto.Classes
{
    class Result
    {
        Lotto.Context.LottoContext ctx;

        #region "Properties"
        
        private long _Id;
        public long Id { get { return _Id; } set { _Id = value; } }

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

        private decimal _Jackpot;
        public decimal Jackpot { get { return _Jackpot;}set{_Jackpot =value;} }
         
        private DateTime _DrawDate;
        public DateTime DrawDate { get { return _DrawDate; } set { _DrawDate = value; } }

        private ClassGlobal.Game _Game;
        public ClassGlobal.Game Game { get { return _Game; } set { _Game = value; } }

        private ClassGlobal.Operation _Operation;
        public ClassGlobal.Operation Operation { get { return _Operation; } set { _Operation = value; } }

        #endregion

        public Result()
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
         
        public void SaveResult()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ctx.SaveResult(_Id, _One, _Two, _Three, _Four, _Five, _Six, _DrawDate,_Jackpot, Convert.ToInt32( _Game), _Operation.ToString());
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
