using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rigidbody;
    private Animator animator;

    private Vector2 delta;
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        delta = Vector2.zero;
        delta.x = Input.GetAxisRaw("Horizontal");
        delta.y = Input.GetAxisRaw("Vertical");
        velocity = delta * speed;
    }

    void FixedUpdate() {
        Animate();
    }

    void Move() {
        if (velocity == Vector2.zero) return;

        rigidbody.MovePosition(
            rigidbody.position + velocity * Time.fixedDeltaTime
        );
    }

    void Animate() {
        bool isMoving = delta != Vector2.zero;

        if (isMoving) {
            Move();
            animator.SetFloat("deltaX", delta.x);
            animator.SetFloat("deltaY", delta.y);
        }
        animator.SetBool("isMoving", isMoving);
    }
}
