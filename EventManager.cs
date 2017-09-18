public static class EventManager
{
	public delegate void GameOverEventHandler ();
	public static event GameOverEventHandler OnGameOver;
	public static void InvokeGameOver ()
	{
		if (OnGameOver != null)
			OnGameOver ();
	}

	public delegate void GamePausedEventHandler (bool paused);
	public static event GamePausedEventHandler OnGamePaused;
	public static void InvokeOnGamePaused (bool paused)
	{
		if (OnGamePaused != null)
			OnGamePaused (paused);
	}
}
