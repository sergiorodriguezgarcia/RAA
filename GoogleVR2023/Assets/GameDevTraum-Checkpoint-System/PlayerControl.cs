using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed=10f;
    Rigidbody rigidbody;
    CheckpointSystem checkpointSystem;
    public Vector3 playerInitialPosition;

    void Start()
    {
        playerInitialPosition = transform.position;

        checkpointSystem = FindObjectOfType<CheckpointSystem>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rigidbody.velocity = Vector3.up * rigidbody.velocity.y + Vector3.right * speed * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.velocity = rigidbody.velocity + Vector3.up;
        }
    }

    public void SetPosition(Vector3 p)
    {
        transform.position = p;
    }

    public void ResetPlayer()
    {
        if (checkpointSystem.CheckpointAvailable())
        {
            transform.position = checkpointSystem.GetCurrentCheckpointPosition();
        }
        else
        {
            transform.position = playerInitialPosition;
        }
        
    }

}
