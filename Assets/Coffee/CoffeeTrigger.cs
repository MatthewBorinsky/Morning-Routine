using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTrigger : MonoBehaviour
{
    public float speed = .8f;
    public float height = 0.1f;
    Vector3 initialPosition = new Vector3();
    Vector3 newPosition = new Vector3();
    public GameObject completionArea;

    public void OnTriggerEnter2D(Collider2D coffee)
    {
        if (coffee.CompareTag("Player"))
        {
            completionArea.SetActive(true);
            gameObject.SetActive(false);

        }
    }
    void Awake() {
        initialPosition = transform.position;
    }
    
    void FixedUpdate () {
        newPosition = initialPosition;
        newPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * speed) * height;
        transform.position = newPosition;
    }
}
