using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PCStore.Models;

namespace PCStore.Repositories
{
    public class StoreRepository
    {
<<<<<<< HEAD
        private readonly StoreContext _context; 
=======
        private readonly StoreContext _context;
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
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

<<<<<<< HEAD
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
=======
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
>>>>>>> 08e829bc27e7c8f48bfe9df118c6c2ff3dafa3d5
            await _context.SaveChangesAsync();
        }
    }
}
