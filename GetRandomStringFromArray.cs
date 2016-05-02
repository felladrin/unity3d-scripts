static string GetRandomStringFromArray (string[] array)
{
	return array[new Random().Next (0, array.Length)];
}
