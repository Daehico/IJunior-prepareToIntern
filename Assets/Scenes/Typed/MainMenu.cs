using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IJunior.TypedScenes
{
    using UnityEngine.SceneManagement;

    public class MainMenu : TypedScene
    {
        private const string _sceneName = "MainMenu";

        public static void Load(LoadSceneMode loadSceneMode = LoadSceneMode.Single)
        {
            LoadScene(_sceneName, loadSceneMode);
        }
    }
}