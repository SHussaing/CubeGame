using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public Vector3 spawn;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        if (player.position.y < -1f)
        {
            player.position = spawn;
        }
    }
}
