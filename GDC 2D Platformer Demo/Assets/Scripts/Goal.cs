using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
	
	void Start () 
	{
		
	}
	
	private void Update ()
	{
		Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, Vector2.Scale(GetComponent<BoxCollider2D>().size, new Vector2(transform.localScale.x, transform.localScale.y)), 0);

		if (hits.Any (hit => hit.gameObject.layer == 8)) 
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
