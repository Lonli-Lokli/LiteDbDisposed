using LiteDB;

namespace LiteDbDisposedException
{
    public class Document
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }
    }
}