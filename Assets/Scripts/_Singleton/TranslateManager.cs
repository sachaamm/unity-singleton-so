using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "SO/TranslateManager", order = 0)]
    public class TranslateManager : ScriptableObject
    {
        public Vector3 TranslateDirection;
    }
}