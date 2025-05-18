using UnityEngine;
public class PedestalChecker : MonoBehaviour
{
    public GameObject correctObject; // ������, ������� ������ ���� ��������
    public GameObject door; // ����� ��� ��������
    private static int correctPlacements = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == correctObject)
        {
            correctPlacements++;
            if (correctPlacements >= 3)
            {
                door.SetActive(false); // ������� �����
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == correctObject)
        {
            correctPlacements--;
        }
    }
}
