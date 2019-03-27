using Data.Database;
using Data.Repositories.interfaces;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        //base class is "GenericRepository"
        public StudentRepository(LMSEntities context) : base(context)        {        }    }
}
