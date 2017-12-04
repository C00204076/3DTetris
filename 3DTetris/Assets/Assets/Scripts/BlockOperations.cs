﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockOperations : MonoBehaviour {

    public static int gridWidth = 10;
    public static int gridHeight = 22;
    float fallSpeed = 0;
    float timer = 2f;

    public static Transform[,] grid = new Transform[gridWidth, gridHeight];
    GameObject obj;
    InstantiateBlock IB;
    
	// Use this for initialization
	void Start () {
        Debug.Log("BlockOperations.Start()");

        obj = GameObject.Find("GameController");
        IB = obj.GetComponent<InstantiateBlock>();
		if (!IsValid())
        {
            Debug.Log("Is Valid");
           //SceneManager.LoadScene(0);
           //Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("BlockOperations.Update()");
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
            transform.position += new Vector3(-1, 0, 0);
            if (IsValid())
            {
                UpdateGrid();
            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D pressed");
            transform.position += new Vector3(1, 0, 0);
            if (IsValid())
            {
                UpdateGrid();
            }
            else
            {
                transform.position += new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R pressed");
            transform.Rotate(0, 0, -90);
            if (IsValid())
            {
                UpdateGrid();
            }
            else
            {
                transform.Rotate(0, 0, 90);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || timer < 1)
        {
            Debug.Log("Timer < 1");
            transform.position += new Vector3(0, -1, 0);
            if (IsValid())
            {
                Debug.Log("Moving Down");
                UpdateGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                DeleteRow();
                IB.SpawnBlock();
                enabled = false;
            }
            timer = 5f;
        }
      //  fallSpeed += Time.time;
        timer -= Time.time;
        Debug.Log("Timer :" + timer);
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    Vector3 Round(Vector3 v)
    {
        return new Vector3(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pos"></param>
    /// <returns></returns>
    bool InsideGrid(Vector3 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridWidth && (int)pos.y >= 0);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="y"></param>
    void DeleteBlock(int y)
    {
        for (int x = 0; x < gridWidth; x++)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="y"></param>
    /// <returns></returns>
    bool IsFull(int y)
    {
        for (int x = 0; x < gridWidth; y++)
        {
            if (grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    void DeleteRow()
    {
        for (int y = 0; y < gridHeight; y++)
        {
            if (IsFull(y))
            {
                DeleteBlock(y);
                FullRowDown(y+1);
                --y;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="y"></param>
    void RowDown(int y)
    {
        for (int x = 0; x < gridWidth; x++)
        {
            if (grid[x, y] != null)
            {
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;
                grid[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="y"></param>
    void FullRowDown(int y)
    {
        for (int i = y; i < gridHeight; i++)
        {
            RowDown(i);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    bool IsValid()
    {
        foreach (Transform child in transform)
        {
            Vector3 v = Round(child.position);
            if (!InsideGrid(v))
            {
                return false;
            }
            if (grid[(int)v.x, (int)v.y] != null && grid[(int)v.x, (int)v.y].parent != transform)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    void UpdateGrid()
    {
        for (int y = 0; y < gridHeight; ++y)
        {
            for (int x = 0; x < gridWidth; ++x)
            {
                if (grid[x,y] != null)
                {
                    if (grid[x,y].parent == transform)
                    {
                        grid[x, y] = null;
                    }
                }
            }
        }
        foreach(Transform child in transform)
        {
            Vector3 v = Round(child.position);
            grid[(int)v.x, (int)v.y] = child;
        }
    }
}