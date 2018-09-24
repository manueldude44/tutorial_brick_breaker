using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

  [SerializeField] float screenWidthInUnits = 16f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    var paddleX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
    paddleX = Mathf.Clamp(paddleX, 1f, 15f);
    transform.position = new Vector2(paddleX, transform.position.y);
	}
}
