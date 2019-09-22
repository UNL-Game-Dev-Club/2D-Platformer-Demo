using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour
{
	[SerializeField]
	float speed = 9;

	[SerializeField]
	float walkAcceleration = 75;

	[SerializeField]
	float jumpHeight = 4;

	private BoxCollider2D boxCollider;

	private Vector2 velocity;

	private bool grounded;

	private void Awake()
	{      
        // TODO: Implement BoxCollider2D
	}

	private void Update()
	{
		if (grounded)
		{
		    // TODO: Implement jump code	
		}

        // TODO: Implement gravity

		float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0)
            velocity.x = 0; // TODO: Implement acceleration
        else
            velocity.x = 0; // TODO: Implement negative acceleration

        // TODO: Implement translation

		Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxCollider.size, 0);

		grounded = false;
		foreach (Collider2D hit in hits)
		{
			// TODO: skip collisions on player

			// TODO: implement collisions and grounded detection
		}
	}
}
