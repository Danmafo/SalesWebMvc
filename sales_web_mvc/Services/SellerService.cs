using sales_web_mvc.Data;
using sales_web_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales_web_mvc.Services {
    public class SellerService {

        private readonly sales_web_mvcContext _context;

        public SellerService(sales_web_mvcContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }
    }
}
