using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal interface IStoreItem
    {
        double Price { get; set; }
        void DiscountPrice (int percent)
        {
            Price = Price * (1 - percent / 100);
        }
    }
}
