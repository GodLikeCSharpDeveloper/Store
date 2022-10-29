using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PCStore.Models;

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
    }
}
