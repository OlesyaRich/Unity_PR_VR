using UnityEngine;

public class ShelfOff : MonoBehaviour
{
    public GameObject shelf;
    private bool isActive = false;

    public void OnButtonPressed()
    {
        if (!isActive)
        {
            shelf.SetActive(false);
            isActive = true;
        }
    }
}
