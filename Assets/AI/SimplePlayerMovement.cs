using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public bool canMove = true;

    void Update()
    {
        if (!canMove) return;
        Vector3 pos = this.transform.position;
        float x = pos.x += (Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        float z = pos.z += (Input.GetAxis("Vertical") * speed * Time.deltaTime);
        this.transform.position = new Vector3(x, pos.y, z);
    }

    public void SetCanMoveFalse()
    {
        canMove = false; 
    }

    public void SetCanMoveTrue()
    {
        canMove = true;
    }
}
