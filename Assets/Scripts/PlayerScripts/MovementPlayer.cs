using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    private Vector2 directionVector;
    private Rigidbody2D _rigidbody2D;
    private float MinSpeed = 0.1f;
    private bool isRunning = false;
    private Transform _transform;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        GetDirection();
    }
    private void FixedUpdate()
    {
        Movement();
        Rotate();
    }

    public bool IsRunning()
    {
        return isRunning;
    }
    private void Movement()
    {
        directionVector = directionVector.normalized;
        _rigidbody2D.MovePosition(_rigidbody2D.position + directionVector * (playerSpeed * Time.fixedDeltaTime));
        if (Mathf.Abs(directionVector.x) > MinSpeed || Mathf.Abs(directionVector.y) > MinSpeed)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }

    private void GetDirection()
    {
        directionVector.x = Input.GetAxisRaw("Horizontal");
        directionVector.y = Input.GetAxisRaw("Vertical");
    }

    private void Rotate()
    {
        if (directionVector.x < 0)
        {
            _transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (directionVector.x > 0)
        {
            _transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
