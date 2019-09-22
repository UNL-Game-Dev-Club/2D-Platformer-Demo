using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	private Renderer renderer;

	private void Start () 
	{
		List<Color> colors = new List<Color> () 
		{
			new Color32(211, 23, 24, 255),
			new Color32(217, 76, 33, 255),
			new Color32(246, 174, 35, 255),
			new Color32(19, 61, 49, 255),
			new Color32(40, 98, 120, 255),
			new Color32(115, 81, 95, 255)
		};
		renderer = GetComponent<Renderer> ();
		renderer.material.color = colors[Random.Range(1, colors.Count)];
	}
}
