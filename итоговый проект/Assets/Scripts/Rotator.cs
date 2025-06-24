using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] public Vector3 speedRotate;   
    [SerializeField] public float amplitude; 
    [SerializeField] public float frequency; 

    private Vector3 startPosition;
    private float newY;

    private void Start()
    {
        
        startPosition = transform.position;
    }

    private void Update()
    {
        
        transform.Rotate(speedRotate * Time.deltaTime);

        
        newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}