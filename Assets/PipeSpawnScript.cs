using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float pipeSpacing = 5.0f; // Afstand mellem rør
    private float minY;
    private float maxY;

    // Start is called before the first frame update
    void Start()
    {
        minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        // Start timer
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        // Hvis timeren er større end spawnRate, spawn en ny Pipe
        if (timer >= spawnRate)
        {
            spawnPipe();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void spawnPipe()
    {
        float spawnY = Random.Range(minY + pipeSpacing / 2, maxY - pipeSpacing / 2);

        Instantiate(Pipe, new Vector3(transform.position.x, spawnY, 0), Quaternion.identity);
    }
}
