using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
  public Rigidbody2D myRigidbody;
  public float flapStrenghth;
  public LogicScripte logic;
  public bool BirdIsAlive = true;

  // Start is called before the first frame update
  void Start()
  {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripte>();
    logic.gameOverScreen.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
    {
      myRigidbody.velocity = Vector2.up * flapStrenghth;
    }
    if (BirdIsAlive &&
 (transform.position.y < -28 || transform.position.y > 28))
    {
      logic.gameOver();
      BirdIsAlive = false;
    }
  }
  private void OnCollisionEnter2D(Collision2D collision)
  {
    logic.gameOver();
    BirdIsAlive = false; 
    Debug.Log("Hit : " + collision.gameObject.name);
  }
}
