using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScripte : MonoBehaviour
{
    public LogicScripte logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripte>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (logic.gameIsOver)
        return;

        if (collision.gameObject.layer == 3)
        {
            logic.addScore();
        }
    }
}
