using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GridManager gridManager;

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
        if (transform.position.x <= -gridManager.columnOffset)
        {
            transform.position = new Vector3(-gridManager.columnOffset, 1f, transform.position.z);
        }
        else if (transform.position.x >= gridManager.columnOffset)
        {
            transform.position = new Vector3(gridManager.columnOffset, 1f, transform.position.z);
        }

        if (transform.position.z <= -gridManager.rowOffset)
        {
            transform.position = new Vector3(transform.position.x, 1f, -gridManager.rowOffset);
        }
        else if (transform.position.z >= gridManager.rowOffset)
        {
            transform.position = new Vector3(transform.position.x, 1f, gridManager.rowOffset);
        }
    }
}
