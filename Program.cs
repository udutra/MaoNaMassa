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

        var courses = new List<Course>();
        
        var courseOop = new Course("Fundamentos OPP", "fundamentos-oop");
        var CourseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var CourseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspdotnet");
        
        courses.Add(courseOop);
        courses.Add(CourseCsharp);
        courses.Add(CourseAspNet);


        var careers = new List<Career>();
        var career = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem = new CareerItem(1, "Comece por aqui", "Descrição", courseOop);
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "Descrição2", CourseCsharp);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "Descrição2", CourseAspNet);
        career.Items.Add(careerItem2);
        career.Items.Add(careerItem3);
        career.Items.Add(careerItem);
        careers.Add(career);

        foreach (var c in careers)
        {
            Console.WriteLine(c.Title);
            foreach (var item in c.Items.OrderBy(x=>x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course.Title);
                Console.WriteLine(item.Course.Level);
            }
        }
        

    }
}