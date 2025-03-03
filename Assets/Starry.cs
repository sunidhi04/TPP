using UnityEngine;

public class Spin : MonoBehaviour
{ 
    void Update()
    {
        transform.Rotate(0f, 0f, 50f * Time.deltaTime, Space.Self);
    }
}
