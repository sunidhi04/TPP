using System;
using UnityEngine.Events;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{

    public UnityEvent OnStarGot = new();
    public bool isStarGot = false;
    private void OnTriggerEnter(Collider triggeredObject)
    {
        if (triggeredObject.CompareTag("Player") && !isStarGot)
        {
            isStarGot = true;
            OnStarGot?.Invoke();
            Debug.Log($"{gameObject.name} is got!");
        }
    }
}
