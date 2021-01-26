using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wick : MonoBehaviour 
{
    [SerializeField]
 //creating a container(variable) to contain our player speed
    private float _speed = 3.5f;
    private float _force = 1000f;
    // Start is called before the first frame update

    void /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
        Start()
        {
        transform.position = new Vector3(0,0,0);
        }
    void Update() 
    // Update is called once per frame
        {
        //if we press the right arrow move the player to the right
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move the player to the right
            transform.position += Vector3.right;
            //informs software what player is doing
            Debug.Log("Right arrow key was pressed");
        } 
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move the player to the left
            transform.position += Vector3.left;
            Debug.Log("Left arrow key was pressed");
        }
        //move the player upwards
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
            Debug.Log("Up arrow key was pressed");
        }
        //move the player downwards
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
            Debug.Log("Down arrow key was pressed");
        }
        //if the position of the player on the y axis is smaller than -4 reset the scene
        //if the position of the player on the y axis is larger than 6 reset the scene
        //if the position of the player on the y axis is < than -4f OR > than 6f
        if(transform.position.y < -4f)
        {
            //restarts scene from beginning
            SceneManager.LoadScene(0);
        }
        //if the position of the player on the y axis is larger than 9 reset the scene
        //if the position of the player  on the y axis is < than -9f OR > than 9f        
        if(transform.position.x < -9f || transform.position.x > 9f)
        {
            SceneManager.LoadScene(0);
        }
    }
    void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Frog")
		{
			Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
