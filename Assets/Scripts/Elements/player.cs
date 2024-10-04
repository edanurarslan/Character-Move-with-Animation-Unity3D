/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    public Animator animator;
    public void MovePlayer(Vector2 dragVector)
    {
        var moveVector = new Vector3(dragVector.x, 0, dragVector.y);
        transform.position = transform.position + moveVector * Time.deltaTime* playerSpeed;
        transform.LookAt(transform.position + moveVector);
        animator.SetFloat("RunRatio", moveVector.magnitude);
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    public Animator animator;

    public void MovePlayer(Vector2 inputVector)
    {
        var moveVector = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position = transform.position + moveVector * Time.deltaTime * playerSpeed;

        if (moveVector != Vector3.zero)
        {
            transform.LookAt(transform.position + moveVector);
        }

        animator.SetFloat("RunRatio", moveVector.magnitude);
    }
}
