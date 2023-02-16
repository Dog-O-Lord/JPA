using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegValApp.Model;

namespace RegValApp.Model
{
    public partial class User
    {
        public bool isWorker
        {
            get
            {
                if (this.RoleId == 3)
                    return true;
                else
                    return false;
            }
        }
        
    }
}
