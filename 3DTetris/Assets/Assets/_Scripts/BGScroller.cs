using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// C00204076
// Brandon Seah-Demspey
// Started at 10:00 27 November 2017
// Finished at
// Time taken:
// Known bugs:

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX;

    public Vector3 startPos;

	// Use this for initialization
	void Start ()
    {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
        transform.position = startPos + Vector3.left * newPos;
	}
}
