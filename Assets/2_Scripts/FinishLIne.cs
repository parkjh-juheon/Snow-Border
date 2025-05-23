using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLIne : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;
    [SerializeField] private ParticleSystem finishEffect; // Finish Effect ��ƼŬ �ý��� ����

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�����߽��ϴ�!");
            if (finishEffect != null)
            {
                finishEffect.Play(); // ��ƼŬ ���
            }
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
