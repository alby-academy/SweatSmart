namespace SweatSmart;

using System.Collections;
using System.Reflection;
using System.Text.RegularExpressions;
using Abstract;

public abstract class Bootstrapper
{
    public static IEnumerable<(Func<IEnumerable>, string name)> GetExercises() =>
        from type in Assembly.GetExecutingAssembly().GetTypes()
        where type.IsClass && !type.IsAbstract && (type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IExercise<>)) || type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IExercise<,>)))
        let interfaceType = type.GetInterfaces().First(t => t.IsGenericType && (t.GetGenericTypeDefinition() == typeof(IExercise<>) || t.GetGenericTypeDefinition() == typeof(IExercise<,>)))
        let map = type.GetInterfaceMap(interfaceType)
        let method = map.InterfaceMethods.Single(m => m.Name == "Run")
        let instance = Activator.CreateInstance(type)
        let name = type.Name
        orderby int.Parse(Regex.Match(name, @"\d+").Value)
        select ((Func<IEnumerable>)(() => method.Invoke(instance, default) as IEnumerable), name);
}