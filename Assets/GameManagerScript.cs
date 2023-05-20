using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Collider2D circleCollider2d;
    public Collider2D paddleCollider2D;
    public GameObject Circle;
    public GameObject LockBase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Check();
        CircleSpawner();
    }
    public void Check()
    {
        if (circleCollider2d.IsTouching(paddleCollider2D) && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("+1");

        }
        if (!(circleCollider2d.IsTouching(paddleCollider2D)) && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Game Over.");
        }
    }
    public void CircleSpawner()
    {
        Vector2 centerPosition = new Vector2(0,0);
        float radius = 1.42f;

        Vector2 spawnPosition;
        int i = Random.Range(1,360);
        float angle = i * Mathf.Deg2Rad;

        spawnPosition.x = (radius * Mathf.Cos(angle)) + centerPosition.x;
        spawnPosition.y = (radius * Mathf.Sin(angle)) + centerPosition.y;

    }
}
