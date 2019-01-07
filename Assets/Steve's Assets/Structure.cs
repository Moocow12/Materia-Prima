﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {

    public int initialHeight = 6;
    public GameObject wallBlockPrefab;
    
    private int health = 2;
    private Vector2 currentTop;
    private Stack<GameObject> wall = new Stack<GameObject>();

	// Use this for initialization
	void Start () {

        currentTop = this.transform.position;
		for (int i = 0; i < initialHeight; i ++)
        {
            wall.Push(wallBlockPrefab);
            Instantiate(wall.Peek(), currentTop, RandomRotation(), this.gameObject.transform);
            currentTop.y += .56f;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private Quaternion RandomRotation()
    {
        float rotation = 0;
        int value = Random.Range(0, 4);

        if (value == 0)
            rotation = 0;
        else if (value == 1)
            rotation = 90;
        else if (value == 2)
            rotation = 180;
        else if (value == 3)
            rotation = 270;

        return new Quaternion(0, 0, rotation, 0);
    }

    public void TakeDamage()
    {
        health -= 1;
        if (health <= 0 && wall.Count > 0)
        {
            health = 2;
            Destroy(wall.Peek());
            wall.Pop();
        }
    }
}
