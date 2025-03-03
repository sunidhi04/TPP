using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float score = 0;

    [SerializeField] private TextMeshProUGUI scoreText;

    private FallTrigger[] fallTriggers;
    private GameObject pinObjects;
  
    private void Start()
    {
        fallTriggers = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include,
                                                        FindObjectsSortMode.None);
        foreach (FallTrigger pin in fallTriggers)
        {
            pin.OnStarGot.AddListener(IncrementScore);
        }
    }
    private void IncrementScore()
        {
            score++;
            scoreText.text = $"Score: {score}";
        }
}

