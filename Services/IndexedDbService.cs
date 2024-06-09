using System.Collections.Generic;
using System.Threading.Tasks;
using AltifaPos.Models;
using Microsoft.JSInterop;

namespace AltifaPos.Services
{
    public class IndexedDbService
    {
        private readonly IJSRuntime js;

        public IndexedDbService(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task OpenDb()
        {
            await js.InvokeVoidAsync("indexedDb.openDb");
        }

        // Category CRUD
        public async Task<List<Categories>> GetCategories()
        {
            return await js.InvokeAsync<List<Categories>>("window.indexedDb.getCategories");
        }

        public async Task AddCategory(Categories category)
        {
            await js.InvokeVoidAsync("window.indexedDb.addCategory", category);
        }

        public async Task EditCategory(Categories category)
        {
            await js.InvokeVoidAsync("window.indexedDb.editCategory", category);
        }

        public async Task DeleteCategory(int id)
        {
            await js.InvokeVoidAsync("window.indexedDb.deleteCategory", id);
        }

        // Product CRUD
        public async Task<List<Product>> GetProducts()
        {
            return await js.InvokeAsync<List<Product>>("indexedDb.getProducts");
        }

        public async Task AddProduct(Product product)
        {
            await js.InvokeVoidAsync("indexedDb.addProduct", product);
        }

        public async Task EditProduct(Product product)
        {
            await js.InvokeVoidAsync("indexedDb.editProduct", product);
        }

        public async Task DeleteProduct(int id)
        {
            await js.InvokeVoidAsync("indexedDb.deleteProduct", id);
        }
    }
}
