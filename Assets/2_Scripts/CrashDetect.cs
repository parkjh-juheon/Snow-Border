using UnityEngine;

public class CrashDetect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("�� �� �Ӹ���");
        }
    }
}
