using System.Reflection;

namespace ReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeName = "";
            Console.WriteLine("----------------Nice Metadata Explorer -------------------");
            do
            {
                Console.WriteLine("\nEnter assembly name (fully qualified assemebly name)");
                Console.WriteLine("or exit(E) to exit: ");
                typeName = Console.ReadLine();
                if (typeName.Equals("E", StringComparison.OrdinalIgnoreCase))
                    break;

                try
                {
                    Type type = Type.GetType(typeName);
                    Console.WriteLine();
                    //ListTypes(type);
                    //ListOfMethods(type);
                    ListOfFields(type);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry Cant find what u are looking for");
                }
            }
            while (true);
        }
        
        private static void ListOfFields(Type? type)
        {
            Console.WriteLine("---------------- Fields --------------");
            var fieldName = type.GetFields().OrderBy(n => n.Name).Select(n => n.Name);
            foreach (var field in fieldName) 
            {
                Console.WriteLine($"=> {field}");
            }
            Console.WriteLine();
        }

        private static void ListOfMethods(Type? type)
        {
            Console.WriteLine("---------- Methods -----------");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"=> {method.Name}");
            }
        }

        private static void ListTypes(Type t)
        {
            Console.WriteLine($"Its base class is - {t.BaseType}");
            Console.WriteLine($"Abstract? - {t.IsAbstract}");
            Console.WriteLine($"Class? - {t.IsClass}");
            Console.WriteLine($"Sealed? - {t.IsSealed}");
        }
    }
}
