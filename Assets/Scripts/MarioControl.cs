using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MarioControl : MonoBehaviour
{
    private const string AxisName = "Horizontal";
    GameObject mario;
    public Animator animator;
    float movement;
    public float movimientoSpeed = 5f;
    Rigidbody2D rb;

    public LayerMask capaPiso;
    public float groundCheckRadius = 0.2f;
    public Transform detectarPiso;
    public bool estaPiso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis(AxisName);
        if (movement > 0f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        estaPiso = Physics2D.OverlapCircle(
            detectarPiso.position,
            groundCheckRadius,
            capaPiso);

        if (Input.GetKeyDown(KeyCode.Space) && estaPiso)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 6f);
        }

        animator.SetFloat("velocidadX", Mathf.Abs(movement));
        animator.SetBool("estaPiso", estaPiso);
        animator.SetFloat("velocidadY", rb.linearVelocity.y); 
        

       // Debug.Log(movement);

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement * movimientoSpeed, rb.linearVelocity.y);
    }
}
