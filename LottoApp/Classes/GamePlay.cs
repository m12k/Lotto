using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Classes
{
    class GamePlay
    {
        Lotto.Context.LottoContext ctx;
         
        public GamePlay()
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

        public IEnumerable<Context.GetTopNumberResult> GetTopNumber(int top, DateTime draw_date, ClassGlobal.Game game)
        {
            try
            {
                return ctx.GetTopNumber(top, draw_date, (int)game);
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}
