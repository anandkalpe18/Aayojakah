using Aayojakah.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aayojakah.Interface
{
    public interface IBookFood
    {
        IEnumerable<Food> FoodList(Food Food);
        int BookFood(BookingFood Food);
    }
}
