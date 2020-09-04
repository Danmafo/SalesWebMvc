using sales_web_mvc.Data;
using System.Linq;
using System.Collections.Generic;
using sales_web_mvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sales_web_mvc.Services {
    public class DepartmentService {

        private readonly sales_web_mvcContext _context;

        public DepartmentService(sales_web_mvcContext context) {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
