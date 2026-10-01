using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    [SerializeField] private int points = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(points);

            Destroy(gameObject);
        }
    }
}
