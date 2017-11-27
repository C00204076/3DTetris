using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBlock : MonoBehaviour {

    public GameObject[] objs;
    bool isClear = false;
    Vector3 p = new Vector3(-3, 14, 4.8f);
    int index = 0;

	/// <summary>
    /// Is called immediately when script is run
    /// </summary>
	void Start ()
    {
        isClear = true;
	}
	
	/// <summary>
    /// Called 60 times per second
    /// </summary>
	void Update ()
    {
        if (isClear)
        {
            Debug.Log("isClear <bool> == true");
            index = Random.Range(0, 7);
            Instantiate(objs[index], p, Quaternion.identity);
            objs[index].transform.Translate(new Vector3(0, -0.1f, 0));
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A key pressed");
                objs[index].transform.Translate(new Vector3(1, 0, 0));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D key pressed");
                objs[index].transform.Translate(new Vector3(-1, 0, 0));
            }
            isClear = false;
        }
	}

    /// <summary>
    /// Detects collision between two GameObjects and 
    /// sets isClear back to true
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter() Called");
        if (other.gameObject.CompareTag("Boundary"))
        {
            Debug.Log(other.gameObject.tag);
            isClear = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="g"></param>
    void moveDown(GameObject g)
    {
        g.transform.Translate(new Vector3(0, -1, 0));
    }
}