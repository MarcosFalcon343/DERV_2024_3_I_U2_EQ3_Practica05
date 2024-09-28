using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedro_Movimiento : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private Animator animator;

    [SerializeField] private float velocidad = 3f;
    [SerializeField] private float sensibilidadMouse = 100f;
    [SerializeField] private float velocidadRotacion = 100f;  // Velocidad de rotación

    public bool IsJumping = false;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -velocidadRotacion * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
            rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
            IsJumping = true;

        }
        animator.SetBool("IsJumping", IsJumping);



        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 velocity = Vector3.zero;
        if (hor != 0 || ver != 0)
        {
            Vector3 movimiento = (transform.right * hor + transform.forward * ver).normalized;
            velocity = movimiento * velocidad;
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Tocando el suelo");
            IsJumping = false;
        }
    }

}
