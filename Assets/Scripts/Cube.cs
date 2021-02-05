using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    private float maxRandomScale = 5f;
    private float _waitTime = 1.5f;
    private Material material;
    private float _currentTime;
    private float _xRotate;
    private float _yRotate;
    private float _zRotate;

    private void Awake()
    {
        material = Renderer.material;
        _currentTime = Time.time;

    }

    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        transform.localScale = Vector3.one * Random.Range(0.1f, maxRandomScale);

        material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    void Update()
    {
        transform.Rotate(_xRotate * Time.deltaTime, _yRotate * Time.deltaTime, _zRotate * Time.deltaTime);
        if (Time.time > _currentTime + _waitTime)
        {
            _xRotate = Random.Range(10f, 15f);
            _yRotate = Random.Range(5f, 50f);
            _zRotate = Random.Range(0f, 15f);
            material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            transform.localScale = Vector3.one * Random.Range(0.1f, maxRandomScale);
            
            _currentTime = Time.time;
        }
        
    }
}