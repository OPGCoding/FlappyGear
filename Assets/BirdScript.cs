using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logicScript; // Reference til LogicScript

    public float rotationSpeed = 2.0f; // Hastighed af rotationen

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * 6;
        }

        RotateBird(); // Kald funktionen for at rotere fuglen
    }

    // Kaldes, når der er en kollision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Pipe")) // Tilpas dette til dine rørlag
        {
            logicScript.SubtractScore(); // Kald SubtractScore fra LogicScript
        }
    }

    // Funktion for at rotere fuglen langsomt
    void RotateBird()
    {
        // Beregn en lille rotationsvinkel for hver frame
        float rotationAngle = myRigidbody.velocity.y * rotationSpeed;

        // Opret en kvaternionrotation baseret på rotationsvinklen
        Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);

        // Anvend rotationen på fuglen
        transform.rotation = rotation;
    }
}
