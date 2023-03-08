using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlastController : MonoBehaviour
{
    public float speed = .5f;
    public float height = 1f;
    Vector3 initialPosition = new Vector3();
    Vector3 newPosition = new Vector3();

    void Awake() {
        initialPosition = transform.position;
    }
    
    void FixedUpdate () {
        newPosition = initialPosition;
        newPosition.x += Mathf.Sin(Time.fixedTime * Mathf.PI * speed) * height;
        transform.position = newPosition;
    }
}
