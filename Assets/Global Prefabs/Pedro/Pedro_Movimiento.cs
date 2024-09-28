using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedro_Movimiento : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private Animator animator;

    [SerializeField] private float velocidad = 3f;
    [SerializeField] private float sensibilidadMouse = 100f;
    [SerializeField] private float velocidadRotacion = 100f;
    [SerializeField] private float fuerzaSalto = 5f;

    private bool IsGrounded = true;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Rotación con el mouse (si el botón derecho está presionado)
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }

        // Rotación con las teclas Q y E
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -velocidadRotacion * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
        }

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rigidbody.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            IsGrounded = false;
            animator.SetBool("IsJumping", true);
        }

        // Movimiento del jugador
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
        animator.SetBool("IsJumping", !IsGrounded);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            IsGrounded = true;
            animator.SetBool("IsJumping", false);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            IsGrounded = false;
        }
    }
}
