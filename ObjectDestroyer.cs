using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
        // Add points to the score
        GameManager.instance.AddScore(1);
    }

    private void Update()
    {
        if (transform.position.y < -5)
        {
            GameManager.instance.GameOver();
            Destroy(gameObject);
        }
    }
}
