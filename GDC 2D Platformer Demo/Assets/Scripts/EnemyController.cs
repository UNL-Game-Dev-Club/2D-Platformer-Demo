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
        Collider2D[] verticalHits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y - 1.5f), 0.01f);
        float horizontalCheckDistance = moveRight ? .5F : -.5F;
        Collider2D[] horizontalHits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x + horizontalCheckDistance, transform.position.y), 0.01f);
        if (verticalHits.Length == 0 || horizontalHits.Length != 0)
        {
            moveRight = !moveRight;
        }

        velocity.x = moveRight ? speed : -1 * Mathf.Abs(speed);
        transform.Translate(velocity * Time.deltaTime);
    }
}
