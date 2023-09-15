using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController PlayerControllerScript;
    private float speed = 20f;
    private float leftBound = -15f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //move attached gameObjects left until game over.
        if (PlayerControllerScript.gameOver == false)
        {
            transform.Translate( Vector3.left * Time.deltaTime * speed );
        }

        //Destroy obstacles that leave the screen
        if (transform.position.x < leftBound && transform.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
