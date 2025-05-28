using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 3f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float baesSpeed = 10f;
    Rigidbody2D rb2d;
    private SurfaceEffector2D surfaceEffector2D;
    private bool isBusting = false;

    private enum InputKey
    {
        None,
        Left,
        Right
    }

    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = Object.FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;

        isBusting = Input.GetKey(KeyCode.UpArrow);
    }

    private void FixedUpdate()
    {
        switch (currentKey)
        {
            case InputKey.Left:
                rb2d.AddTorque(torqueAmount);
                break;
            case InputKey.Right:
                rb2d.AddTorque(-torqueAmount);
                break;
            case InputKey.None:
                break;
        }

        surfaceEffector2D.speed = isBusting ? boostSpeed : baesSpeed;
    }
}
