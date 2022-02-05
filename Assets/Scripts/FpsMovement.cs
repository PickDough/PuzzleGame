using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsMovement : MonoBehaviour {
    
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float jumpAcceleration;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float sprintAcceleration;

    public bool isSprinting { get; set; }

    void Move(Vector3 direction) {
        var acceleration = isSprinting ? sprintAcceleration : 1;
        rb.MovePosition(transform.position + direction.normalized * moveSpeed * acceleration * Time.deltaTime);
    }

    void Jump() {
        rb.AddForce(Vector3.up * jumpAcceleration, ForceMode.Impulse);
    }

}
