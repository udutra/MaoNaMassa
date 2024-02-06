using MaoNaMassa.ContentContext;

namespace MaoNaMassa;

public static class Program
{
    public static void Main(string[] args)
    {
        var articles = new List<Article>
        {
            new Article("Artigo sobre OPP", "orientacao-objetos"),
            new Article("Artigo sobre C#", "csharp"),
            new Article("Artigo sobre .NET", "dotnet")
        };

        foreach (var a in articles)
        {
            Console.WriteLine(a.Id);
            Console.WriteLine(a.Title);
            Console.WriteLine(a.Url);
        }
    }
}