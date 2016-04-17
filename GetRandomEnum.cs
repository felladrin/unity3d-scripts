static T GetRandomEnum<T> ()
{
	Array array = Enum.GetValues (typeof(T));
	return (T)array.GetValue (new Random ().Next (0, array.Length));
}
