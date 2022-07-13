using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any()|| _context.SalesRecord.Any() || _context.Seller.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21),1000.0,d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 3),3100.0,d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(2001, 9, 5),2000.0,d3);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(2004, 2, 21),1300.0,d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 1100, SaleStatus.BILLED, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 9, 25), 2200, SaleStatus.PENDING, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 9, 25), 3300, SaleStatus.BILLED, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 9, 25), 4400, SaleStatus.CANCELED, s4);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3,s4);
            _context.SalesRecord.AddRange(r1,r2,r3,r4);

            _context.SaveChanges();
        }
    }
}
