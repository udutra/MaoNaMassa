using MaoNaMassa.ContentContext;
using MaoNaMassa.ContentContext.Enums;

namespace MaoNaMassa;

public static class Program
{
    public static void Main(string[] args)
    {
        var course = new Course
        {
            Level = EContentLevel.Fundamental
        };
    }
}