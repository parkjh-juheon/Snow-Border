using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLIne : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�����߽��ϴ�!");
            SceneManager.LoadScene(0);
        }
    }
}
