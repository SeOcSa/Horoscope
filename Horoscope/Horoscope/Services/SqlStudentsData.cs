using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horoscope.Services
{
    public class SqlStudentsData : IHoroscopeData
    {
        private readonly HoroscopeDbContext _context;

        public SqlStudentsData(HoroscopeDbContext context)
        {
            _context = context;
        }
        public Student Get(Guid id)
        {
            return _context.StudentInfos.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<Student> GetAboveEight()
        {
            return _context.StudentInfos.Where(x => x.media >= 8).ToList();
        }

        public List<Student> GetAll()
        {
            return _context.StudentInfos.ToList();
        }
    }
}
