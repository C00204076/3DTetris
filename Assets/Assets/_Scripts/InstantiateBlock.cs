using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBlock : MonoBehaviour {
    public GameObject[] objs;

	/// <summary>
    /// Is called immediately when script is run
    /// </summary>
	void Start ()
    {
        SpawnBlock();
    }

    /// <summary>
    /// 
    /// </summary>
    public void SpawnBlock()
    {
        int index = Random.Range(0, objs.Length);
        Instantiate(objs[index], transform.position, Quaternion.identity);
    }
}