using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horoscope.Services
{
    public interface IHoroscopeData
    {
        List<Student> GetAll();

        Student Get(Guid id);

        List<Student> GetAboveEight();

    }

}
