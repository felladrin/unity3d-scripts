static T GetRandomEnum<T>()
{
    System.Array arr = System.Enum.GetValues(typeof(T));
    T randomEnum = (T)arr.GetValue(UnityEngine.Random.Range(0, arr.Length));
    return randomEnum;
}
