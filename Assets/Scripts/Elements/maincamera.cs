using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincamera : MonoBehaviour
{
    public player player;
    public Vector3 offset;

    private void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
