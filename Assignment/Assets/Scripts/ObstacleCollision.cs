﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("The player has entered into the obstacle");
        //reload the scene when the player hits the obstacle
        SceneManager.LoadScene(0);
    }
}
