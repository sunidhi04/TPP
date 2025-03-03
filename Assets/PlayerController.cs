using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;
    [SerializeField] private float jumpforce;

    private Rigidbody rb;
   

    [SerializeField] private float Hopped = 0;
    private void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        inputManager.OnSpacePressed.AddListener(Hop);
        //inputManager.OnShiftPressed.AddListener(Launch);

        rb = GetComponent<Rigidbody>();
        Hopped = 0;
    }
    private void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        //rb.AddForce(speed * moveDirection);

        rb.AddForce(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider triggeredObject)
    {
        Debug.Log($"We hit something");
        if (triggeredObject.CompareTag("Ground"))
        {
            Hopped = 0;
            Debug.Log($"We hit ground");
        }
    }
    private void Hop()       
    {
        Debug.Log($"We tried to jump");

        if (Hopped > 1) return;

        Debug.Log($"We jumped");
        Hopped++;
        rb.AddForce(Vector3.up *jumpforce);

        
    }
    /*
    private void Launch()
    {
        transform.parent = null;

        rb.AddForce(launchIndicator.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);

    }
    */
}
