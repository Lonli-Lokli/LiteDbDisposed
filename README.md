# LiteDbDisposed

Run application
On the screen choose 1 to add a document, enter the title and press enter
On the screen choose 2 to display added documents

Exception occurs:

System.ObjectDisposedException: Cannot access a disposed object.
   at System.Threading.ReaderWriterLockSlim.TryEnterReadLockCore(TimeoutTracker timeout)
   at System.Threading.ReaderWriterLockSlim.TryEnterReadLock(TimeSpan timeout)
   at LiteDB.Engine.LockService.EnterTransaction()
   at LiteDB.Engine.TransactionMonitor.GetTransaction(Boolean create, Boolean queryOnly, Boolean& isNew)
   at LiteDB.Engine.QueryExecutor.ExecuteQuery(Boolean executionPlan)
   at LiteDB.Engine.QueryExecutor.ExecuteQuery()
   at LiteDB.Engine.LiteEngine.Query(String collection, Query query)
   at LiteDB.LiteQueryable`1.ToDocuments()+MoveNext()
   at System.Linq.Enumerable.SelectEnumerableIterator`2.MoveNext()
