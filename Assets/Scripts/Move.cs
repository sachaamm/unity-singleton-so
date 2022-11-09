using System;
using DefaultNamespace;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed = 1f;
    
    void Update()
    {
        transform.Translate(MasterManager.TranslateManager.TranslateDirection * (Time.deltaTime * MoveSpeed));
    }
}
