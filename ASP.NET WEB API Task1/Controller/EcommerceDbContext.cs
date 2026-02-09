using ASP.NET_WEB_API_Task1.DAL;

namespace ASP.NET_WEB_API_Task1.Controller
{
    internal class EcommerceDbContext
    {
        public object Categories { get; internal set; }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public static implicit operator EcommerceDbContext(APIDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}