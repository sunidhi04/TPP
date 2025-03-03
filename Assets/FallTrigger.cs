using System;
using UnityEngine.Events;
using UnityEngine;
using Unity.VisualScripting;

public class FallTrigger : MonoBehaviour
{

    public UnityEvent OnStarGot = new();
    private void OnTriggerEnter(Collider triggeredObject)
    {
        Debug.Log($"{gameObject.name} is hit!");
        if (triggeredObject.CompareTag("Player"))
        {
            OnStarGot?.Invoke();
            Destroy(gameObject);
            Debug.Log($"{gameObject.name} is got!");
        }
    }
}
