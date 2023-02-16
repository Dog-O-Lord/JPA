using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountApp.DBModel;

namespace DiscountApp.DBModel
{
    public partial class Product
    {
        public bool IsDiscounted
        {
            get
            {
                if (Discount >= 15)
                    return true;
                else
                    return false;
            }
        }
    }
}
