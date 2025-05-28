using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;
    [SerializeField] private ParticleSystem crashEffect; // �ν����Ϳ��� �Ҵ�

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            crashEffect.Play(); // ����Ʈ ���
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
