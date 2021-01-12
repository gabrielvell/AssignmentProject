using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wick : MonoBehaviour 
{
    [SerializeField]
    //creating variable to contain player speed
    private float _speed = 3.5f;
    private float _force = 1000f;


    void /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
        Start()
        {
        transform.position = new Vector3(0,0,0);
        }
    void Update() 
    {
            {
        //move the player to the right
        //realtime
        //x * realtime(Time.deltaTime) = 1m/s
        //1 * fps e.g 1 * 1500fps (this calculation is used when not multiplying by Time.deltaTime)
        
        //if we press the right arrow move the player to the right
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move the player to the right
            transform.position += Vector3.right;
        } 
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move the player to the left
            transform.position += Vector3.left;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
        }
            }
        }
    }

