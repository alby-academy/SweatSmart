namespace SweatSmart.Abstract;

public interface IExercise<out T>
{
    IEnumerable<T> Run();
}

public interface IExercise<TKey, TValue> where TKey : notnull
{
    Dictionary<TKey, TValue> Run();
}