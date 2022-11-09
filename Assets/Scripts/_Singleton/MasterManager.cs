using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "SO/MasterManager", order = 0)]
    public class MasterManager : SingletonScriptableObject<MasterManager>
    {
        [SerializeField] private TranslateManager translateManager;
        
        public static TranslateManager TranslateManager => Instance.translateManager;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void FirstInitialize()
        {
            Debug.LogFormat("This message will output before Awake.");
        }
    }
}