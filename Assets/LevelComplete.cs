using UnityEngine;
public class LevelComplete : MonoBehaviour
{
    public GameObject completionIndicator; // ��������, ����� "Level Complete"
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalItem"))
        {
            completionIndicator.SetActive(true);
        }
    }
}
