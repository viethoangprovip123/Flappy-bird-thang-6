using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public float Jump = 10f;
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive == true)    
        {
            myRigidbody.velocity = Vector2.up * 10;
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Pipe")
        {
            logic.GameOver();
            birdAlive = false;
        }
    }
}
