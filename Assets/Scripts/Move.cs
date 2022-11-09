using DefaultNamespace;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        transform.Translate(MasterManager.TranslateManager.TranslateDirection * Time.deltaTime);
    }
}
