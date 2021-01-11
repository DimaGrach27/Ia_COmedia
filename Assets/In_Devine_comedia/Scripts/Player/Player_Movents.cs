using UnityEngine;

public class Player_Movents : MonoBehaviour
{
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] float rayCast = 1.3f;

    private Rigidbody2D rb;
    [SerializeField] Animator anim;

    [SerializeField] float Speed;
    private float RunPos;
    [SerializeField] float JumpForce;

    public static bool isControl;

    void Start()
    {
        isControl = true;
        rb = GetComponent<Rigidbody2D>();
    }

    //private void Update()
    //{
    //    if(isControl)
    //        Jump();
    //}

    private void FixedUpdate()
    {
        if(isControl && isGrounded())
            Move();
    }
#if UNITY_EDITOR
    private void Update()
    {
        RunPos = Input.GetAxis("Horizontal");
    }
#endif
    private void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        anim.SetBool("IsWalk", false);

        if (RunPos < 0)
        {
            moveVelocity = Vector3.left;

            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            anim.SetBool("IsWalk", true);
        }
        if (RunPos > 0)
        {
            moveVelocity = Vector3.right;

            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            anim.SetBool("IsWalk", true);
        }
        //transform.position += moveVelocity * Speed * Time.deltaTime;
        rb.velocity = new Vector2(moveVelocity.x * Speed * Time.deltaTime, rb.velocity.y);
    }

    public void Run_Rigth()
    {
        RunPos = 1f;
    }
    public void Run_Left()
    {
        RunPos = -1f;
    }

    public void Stop()
    {
        RunPos = 0f;
    }

    private bool isGrounded()
    {
        RaycastHit2D ground = Physics2D.Raycast(transform.position, Vector2.down, rayCast, whatIsGround);
        if (ground.collider != null)
        {
            return true;
        }

        return false;
    }
    public void Jump()
    {
        if (isGrounded() && isControl)
        {
            rb.velocity = Vector2.zero;

            Vector2 jumpVelocity = new Vector2(rb.velocity.x, JumpForce);
            rb.AddForce(jumpVelocity, ForceMode2D.Impulse);
        }
    }
}
