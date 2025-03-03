using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float score = 0;

    [SerializeField] private BallController ball;

    [SerializeField] private GameObject pinCollection;

    [SerializeField] private Transform pinAnchor;

    [SerializeField] private InputManager inputManager;

    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] fallTriggers;
    private GameObject pinObjects;
  
    private void Start()
    {
        fallTriggers = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include,
                                                        FindObjectsSortMode.None);
        foreach (FallTrigger pin in fallTriggers)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }
    private void IncrementScore()
        {
            score++;
            scoreText.text = $"Score: {score}";
        }
}

