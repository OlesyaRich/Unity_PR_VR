using UnityEngine;
public class LevelComplete : MonoBehaviour
{
    public GameObject completionIndicator; // Например, текст "Level Complete"
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalItem"))
        {
            completionIndicator.SetActive(true);
        }
    }
}
