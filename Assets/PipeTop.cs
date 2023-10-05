using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTop : MonoBehaviour
{
    public LogicScript logic1;

    // Start is called before the first frame update
    void Start()
    {
        logic1 = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic1.SubtractScore();
    }



}
