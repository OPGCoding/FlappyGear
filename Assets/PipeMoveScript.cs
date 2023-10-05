using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = -45;
    private Renderer pipeRenderer;
    public LogicScript logicScript; // Reference til LogicScript
    private bool hasBeenCounted = false; // En variabel for at sikre, at r�ret kun t�lles �n gang

    // Start is called before the first frame update
    void Start()
    {
        pipeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

    // Bliver kaldt n�r objektet bliver usynligt af kameraet
    private void OnBecameInvisible()
    {
        // Fjern objektet, n�r det bliver usynligt
        Destroy(gameObject);

        // Tjek om r�ret allerede er blevet talt med i scoren
        if (!hasBeenCounted)
        {
            // Opdater scoren i LogicScript ved at kalde addScore metoden
            logicScript.addScore();

            // S�t hasBeenCounted til true for at undg� dobbeltt�lling
            hasBeenCounted = true;
        }
    }
}
