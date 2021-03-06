using UnityEngine;
using UnityEngine.SceneManagement;

namespace RustedGames
{
	public sealed class Bootstrap : MonoBehaviour
	{
		[SerializeField] private string firstSceneName;
		public GameSettingsData gameSettings;

		private Contexts _contexts;
		private SettingsContext _settingsContext;
		private GameSystems _gameSystems;

		public static bool IsQuitting { get; private set; }

		private void Awake()
		{
			Application.quitting += delegate { IsQuitting = true; };
			DoAwake();
		}

		private void DoAwake()
		{
			DontDestroyOnLoad(this);
			_contexts = Contexts.sharedInstance;
			_settingsContext = _contexts.settings;

			//https://docs.unity3d.com/ScriptReference/Random.InitState.html
			//This prevents the same run of values from occurring each time a 
			//game is played and thus avoids predictable gameplay
			UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);

			LoadSettings();

			_gameSystems = new GameSystems(_contexts);
		}

		private void Start()
		{		
			_gameSystems.Initialize();
			SceneManager.LoadSceneAsync(firstSceneName, LoadSceneMode.Additive);			
		}

		private void Update()
		{
			_gameSystems.Execute();
		}

		private void LoadSettings()
		{
			_settingsContext.SetGameSettings(gameSettings);
		}

		private void OnApplicationQuit()
		{
			_gameSystems.TearDown();
		}
	}
}