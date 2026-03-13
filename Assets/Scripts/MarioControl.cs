using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MarioControl : MonoBehaviour
{

    GameObject mario;
    public Transform marioTransform;
    public Animator animator;
    float movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("horizontal");
        if (movement > 0)
        {
            animator.SetBool("Caminando", true);
        }
        else if (movement < 0)
        {
            animator.SetBool("Caminando", true);
        }

        else
        {
            animator.SetBool("Caminando", false);
        }
            
    }
}
