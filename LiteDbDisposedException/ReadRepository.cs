using System.Collections.Generic;
using System.Linq;

namespace LiteDbDisposedException
{
    public class ReadRepository : BaseRepository
    {
        public IEnumerable<DocumentDto> GetAll()
        {
            using var db = GetDatabase();
            return db.GetCollection<Document>().FindAll().Select(e => new DocumentDto()
            {
                Title = e.Title
            });
        } 
    }
}