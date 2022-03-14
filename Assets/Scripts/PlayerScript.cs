using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GridManager gridManager;

    private Vector3 currentPos;
    private Vector3 previousPos;
    private float offset;

    void Start()
    {
        transform.position = new Vector3(-gridManager.columnOffset, 1f, gridManager.rowOffset);
        offset = gridManager.gapOffset;
    }

    void Update()
    {
        Movement();
        OutOfBounds();
    }

    void Movement()
    {
        previousPos = transform.position;
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * offset);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * offset);
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * offset);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * offset);
        }
    }

    void OutOfBounds()
    {
        RaycastHit hit;
        var down = transform.TransformDirection(Vector3.down);
        
        if (!Physics.Raycast(transform.position, down, out hit, 1.5f))
        {
            currentPos = previousPos;
            transform.position = currentPos;
        }
    }
}
