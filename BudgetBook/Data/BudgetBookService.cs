namespace BudgetBook.Data
{
    public class BudgetBookService
    {

        private static List<Entry> mockDb = new List<Entry>();


        public async Task<bool> AddEntry(Entry newEntry)
        {
            mockDb.Add(newEntry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return mockDb;
        }



    }
}
