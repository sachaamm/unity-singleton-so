using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed = 1f;

    public List<Vector3> v;

    private void Awake()
    {
        int b = 10;
    }

    void Start()
    {
        int b = 0; // 
        v.Add(new Vector3());
        
    }

    private void OnEnable()
    {
        int b = 0;
    }

    private void OnDisable()
    {
        int b = 0;
    }

    void Update()
    {
        transform.Translate(MasterManager.TranslateManager.TranslateDirection * (Time.deltaTime * MoveSpeed));
    }
}
