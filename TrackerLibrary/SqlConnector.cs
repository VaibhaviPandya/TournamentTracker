using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        PrizeModel IDataConnection.CreatePrize(PrizeModel model)
        {
            //Todo- create price method actually save data to daatabase(save new price to database)
            model.Id = 1;
            return model;
        }
    }
}
