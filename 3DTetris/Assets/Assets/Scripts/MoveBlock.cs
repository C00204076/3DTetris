using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {

    bool isAlive = false;

	// Use this for initialization
	void Start () {
        isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (isAlive)
        {
            this.transform.Translate(new Vector3(0, -0.1f, 0));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            this.transform.Translate(new Vector3(-1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(new Vector3(1, 0, 0));
        }
    }
}
