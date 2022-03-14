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

    private Dictionary<int, string> birdsList = new Dictionary<int, string>();
    private int l = 0;

    void Start()
    {
        List<string> myBirds = new List<string>();
        myBirds.Add("Pigeon");
        myBirds.Add("Peacock");
        myBirds.Add("Parrot");
        myBirds.Add("Sparrow");
        myBirds.Add("Quail");
        myBirds.Add("Owl");
        myBirds.Add("Swallow");
        myBirds.Add("Crow");
        myBirds.Add("Kite");
        myBirds.Add("Eagle");
        myBirds.Add("Swan");
        myBirds.Add("Bat");
        myBirds.Add("Ostrich");
        myBirds.Add("Dove");
        myBirds.Add("Crane");
        myBirds.Add("Duck");
        myBirds.Add("Robin");
        myBirds.Add("Flamingo");
        myBirds.Add("Cuckoo");

        for(int k = 0; k < myBirds.Count; k++)
        {
            birdsList.Add(k, myBirds[k]);
        }

        gridCubes = new GameObject[columns, rows];
        columnOffset = columns - 1;
        rowOffset = rows - 1;

        for (int i = 0; i < gridCubes.GetLength(0); i++)
        {
            for (int j = 0; j < gridCubes.GetLength(1); j++)
            {
                gridCubes[i, j] = (GameObject)Instantiate(cube, new Vector3((i * gapOffset) - columnOffset, 0, (j * gapOffset) - rowOffset), cube.transform.rotation);
                gridCubes[i, j].GetComponentInChildren<TextMesh>().text = birdsList[l];
                l++;
            }
        }

        if (columns != 0 && rows != 0)
        {
            player.SetActive(true);
        }
    }
}
