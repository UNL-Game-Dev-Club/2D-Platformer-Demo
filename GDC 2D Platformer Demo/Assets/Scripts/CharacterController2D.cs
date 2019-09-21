using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour
{
	[SerializeField]
	float speed = 9;

	[SerializeField]
	float walkAcceleration = 75;

	[SerializeField]
	float groundDeacceleration = 70;

	[SerializeField]
	float jumpHeight = 4;

	private BoxCollider2D boxCollider;

	private Vector2 velocity;

	private bool grounded;

	private void Awake()
	{      
		boxCollider = GetComponent<BoxCollider2D>();
	}

	private void Update()
	{
		if (grounded)
		{
			velocity.y = 0;

			if (Input.GetButtonDown("Jump"))
			{
				velocity.y = Mathf.Sqrt(2 * jumpHeight * Mathf.Abs(Physics2D.gravity.y));
			}
		}

		velocity.y += Physics2D.gravity.y * Time.deltaTime;

		float moveInput = Input.GetAxisRaw("Horizontal");

		if (moveInput != 0)
			velocity.x = Mathf.MoveTowards(velocity.x, speed * moveInput, walkAcceleration * Time.deltaTime);
		else
			velocity.x = Mathf.MoveTowards(velocity.x, 0, groundDeacceleration * Time.deltaTime);

		transform.Translate(velocity * Time.deltaTime);

		Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxCollider.size, 0);

		grounded = false;
		foreach (Collider2D hit in hits)
		{
			if (hit == boxCollider)
				continue;

			ColliderDistance2D colliderDistance = hit.Distance(boxCollider);

			if (colliderDistance.isOverlapped)
			{
				transform.Translate(colliderDistance.pointA - colliderDistance.pointB);
				if (Vector2.Angle(colliderDistance.normal, Vector2.up) < 90 && velocity.y < 0)
					grounded = true;
			}
		}
	}
}
