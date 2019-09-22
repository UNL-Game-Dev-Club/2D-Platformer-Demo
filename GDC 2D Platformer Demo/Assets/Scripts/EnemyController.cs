using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    float speed = 2;

    private Vector2 velocity;

    private bool moveRight = true;

    // Update is called once per frame
    private void Update()
    {
        // TODO: detect vertical collision
        // TODO: detect horizontal collision
        
        // TODO: switch moveRight on detection

        // TODO: add to velocity based on moveRight
        
        // TODO: translate enemy
    }
}
