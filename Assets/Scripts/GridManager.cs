using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject player;
    public GameObject cube;
    public GameObject[,] gridCubes;
    public int rows;
    public int columns;
    public int gapOffset = 2;
    public float columnOffset;
    public float rowOffset;

    private int l = 0;

    void Start()
    {
        Dictionary<int, string> myBirds = new Dictionary<int, string>();
        myBirds.Add(0, "Pigeon");
        myBirds.Add(1, "Peacock");
        myBirds.Add(2, "Parrot");
        myBirds.Add(3, "Sparrow");
        myBirds.Add(4, "Quail");
        myBirds.Add(5, "Owl");
        myBirds.Add(6, "Swallow");
        myBirds.Add(7, "Crow");
        myBirds.Add(8, "Kite");
        myBirds.Add(9, "Eagle");
        myBirds.Add(10, "Swan");
        myBirds.Add(11, "Bat");
        myBirds.Add(12, "Ostrich");
        myBirds.Add(13, "Dove");
        myBirds.Add(14, "Crane");
        myBirds.Add(15, "Duck");
        myBirds.Add(16, "Robin");
        myBirds.Add(17, "Flamingo");
        myBirds.Add(18, "Cuckoo");

        gridCubes = new GameObject[columns, rows];
        columnOffset = columns - 1;
        rowOffset = rows - 1;

        for (int i = 0; i < gridCubes.GetLength(0); i++)
        {
            for (int j = 0; j < gridCubes.GetLength(1); j++)
            {
                gridCubes[i, j] = (GameObject)Instantiate(cube, new Vector3((i * gapOffset) - columnOffset, 0, (j * gapOffset) - rowOffset), cube.transform.rotation);
                gridCubes[i, j].GetComponentInChildren<TextMesh>().text = myBirds[l];
                l++;
            }
        }

        if (columns != 0 && rows != 0)
        {
            player.SetActive(true);
        }
    }
}
