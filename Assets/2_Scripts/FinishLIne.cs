using UnityEngine;

public class FinishLIne : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�����߽��ϴ�!");
        }
    }
}
