using LiteDB;

namespace LiteDbDisposedException
{
    public class BaseRepository
    {
        protected ILiteDatabase GetDatabase()
        {
            return new LiteDatabase("Filename=file.db");
        }
    }
}