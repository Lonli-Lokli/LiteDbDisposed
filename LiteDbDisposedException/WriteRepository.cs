using System;

namespace LiteDbDisposedException
{
    public class WriteRepository : BaseRepository
    {
        public void Add(string title)
        {
            using var db = GetDatabase();
            db.GetCollection<Document>().Insert(new Document[]
            {
                new Document() {Id = Guid.NewGuid().ToString(), Title = title}
            });
        }
    }
}