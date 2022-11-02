using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PCStore.Models;
using System.Diagnostics.Metrics;

namespace PCStore.Repositories
{
    public class StoreRepository
    {
        private readonly StoreContext _context;
        public StoreRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<brandsModel> Create(brandsModel brandmodel)
        {
            _context.brands.Add(brandmodel);
            await _context.SaveChangesAsync();
            return brandmodel;
        }

        public async Task Delete(int id)
        {
            var BrandToDelete = await _context.brands.FindAsync(id);
            _context.brands.Remove(BrandToDelete);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<brandsModel>> Get()
        {
            return await _context.brands.ToListAsync();
        }

        public async Task<brandsModel> Get(int id)
        {
            return await _context.brands.FindAsync(id);
        }

        //Почему таск используется где-то а где-то нет
        public async Task Update(brandsModel brandmodel)
        {
            _context.Entry(brandmodel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<brandsModel[]> AddBrandAsync(String brandName)
        {
            brandsModel[] brandsmodel;
            var brandsName = brandName;
            SqlParameter param1 = new SqlParameter("@brand_name", brandName);
          

            brandsmodel = _context.brands.FromSqlRaw
                        ("ALTER TABLE brands ADD @brand_name varchar(50); @brand_name", param1)
                .ToArray();
            
            return brandsmodel;
        }
    }
}
