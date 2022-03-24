using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }= new List<IDataConnection>();
        public static void InitializeConnections(bool database,bool textFiles)
        {
            //Connections= new List<IDatacConnection>();

            if (database)
            {
                //Todo -set up the sql connector properly
                SqlConnector sqlConnector = new SqlConnector(); 
                Connections.Add(sqlConnector);
            }
            if (textFiles)
            {
                TextConnection textConnection = new TextConnection();   
                Connections.Add(textConnection);
            }
        }
    }
}
