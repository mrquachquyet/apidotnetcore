using System.Linq;

namespace VNCDCL.Core.Extensions
{
    public static class PageExtensions
    {
        public static IQueryable<T> ToPage<T>(this IQueryable<T> source, int page, int pagesize)
        {
            var skip = (page - 1) * pagesize;
            return source.Skip(skip).Take(pagesize);
        }
    }
}