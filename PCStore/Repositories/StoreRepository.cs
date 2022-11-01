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

        public async Task Delete(categoryModel categorymodel)
        {
            _context.Remove(categorymodel);
            await _context.SaveChangesAsync();


        }

        public async Task<List<categoryModel>> GetAllAsync()
        {
            return await _context.categories.ToListAsync();
        }

        public async Task<categoryModel> Get(int id)
        {
            return await _context.categories.FindAsync(id);
        }

        //Почему таск используется где-то а где-то нет
        public async Task Update(categoryModel categorymodel)
        {
            _context.Entry(categorymodel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
