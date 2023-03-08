using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletion : MonoBehaviour
{
    public GameObject celebrationText;
    void Awake()
    {
        celebrationText.SetActive(false);
        gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D context)
    {
        celebrationText.SetActive(true);
    }
}
