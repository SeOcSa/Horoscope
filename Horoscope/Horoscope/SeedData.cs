using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horoscope
{
    public class SeedData
    {
        private readonly HoroscopeDbContext _context;

        public SeedData(HoroscopeDbContext context)
        {
            _context = context;
        }
        public async Task EnsureSeedData()
        {
            await SeedStundetsInfo();
        }

        private async Task SeedStundetsInfo()
        {
            if (!_context.StudentInfos.Any())
            {
                var student = new Student
                {
                    Id=Guid.NewGuid(),
                    Nume="Dadutu",
                    Matricol="ETC0001",
                    media=(float)8.99
                };
                var student1 = new Student
                {
                    Id = Guid.NewGuid(),
                    Nume = "Vamesu",
                    Matricol = "ETC0007",
                    media = (float)10
                };
                var student2 = new Student
                {
                    Id = Guid.NewGuid(),
                    Nume = "Sebastian",
                    Matricol = "AC0001",
                    media = (float)9.21
                };

                await _context.StudentInfos.AddRangeAsync(student, student1, student2);
                _context.SaveChanges();
            }
        }
    }
}
