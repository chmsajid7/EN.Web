using EN.Web.Models;
using EN.Web.Services;
using System.Threading.Tasks;

namespace EN.Web.Helpers
{
    public class PageNumberHelper
    {
        private ILocalStorageService localStorageService;
        private string entriesPageNoStorageKey = "entriesPageNumber";
        private string referencesPageNoStorageKey = "referencesPageNumber";
        public PageNumber pageNumber { get; private set; }

        public PageNumberHelper(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }
        public async Task SaveEntriesPageNo(int pageNumber)
        {
            this.pageNumber = new PageNumber()
            {
                pageNumber = pageNumber
            };
            await localStorageService.SetItem(entriesPageNoStorageKey, this.pageNumber);
        }

        public async Task<int> GetEntriesPageNo()
        {
            this.pageNumber = await localStorageService.GetItem<PageNumber>(entriesPageNoStorageKey);
            if (this.pageNumber == null)
            {
                return 1;
            }
            await localStorageService.RemoveItem(entriesPageNoStorageKey);
            return this.pageNumber.pageNumber;
        }
        
        public async Task SaveReferencesPageNo(int pageNumber)
        {
            this.pageNumber = new PageNumber()
            {
                pageNumber = pageNumber
            };
            await localStorageService.SetItem(referencesPageNoStorageKey, this.pageNumber);
        }

        public async Task<int> GetReferencesPageNo()
        {
            this.pageNumber = await localStorageService.GetItem<PageNumber>(referencesPageNoStorageKey);
            if (this.pageNumber == null)
            {
                return 1;
            }
            await localStorageService.RemoveItem(referencesPageNoStorageKey);
            return this.pageNumber.pageNumber;
        }
    }
}
