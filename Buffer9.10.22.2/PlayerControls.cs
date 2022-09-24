using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour{
//Game manager object
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header("Default Victory")]
public float velocity = 5;
//Physics for the bird
private Rigidbody2D rb;
private float objectHeight;
    void Start(){
    gameController = GetComponent<GameController>();
    Time.timeScale = 1;
    rb = GetComponent<Rigidbody2D>();
    objectHeight =
    transform.GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void Update(){
    if(Input.GetMouseButtonDown(0)){
      rb.velocity = Vector2.up*velocity;
    }
    }
    private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.tag == "HighSpike" || collision.gameObject.tag == "LowSpike" || collision.gameObject.tag == "Ground"){
        Time.timeScale = 0;
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
      }
    }
}
