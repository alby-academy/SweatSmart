namespace SweatSmart.Abstract;

public interface IExercise<out T>
{
    IEnumerable<T> Run();
}

public interface IExercise<TKey, TValue>
{
    Dictionary<TKey, TValue> Run();
}