using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    //total speed
    private float _speed = 3f;
    private bool _randomizeHeight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.left = Vector3(-1,0,0)
        //Vector3.left (-1) * 1 * _speed(3) = -3
        transform.Translate(Vector3.left * Time.deltaTime * _speed);

        //if the position is smaller than -15
        if(transform.position.x < -15)
        {
            if(_randomizeHeight)
            {
                //specific spawn points so the obstacles can be in range with the game
                float randomYPosition = Random.Range(1f,5f);
                //comment to advize what is happening and gives out the specific spawn point
                Debug.Log("The random position is: " + randomYPosition);
                //the x position is randomized along with the y position
                float randomXPosition = Random.Range(-8f, 8f);
                Debug.Log("The random position is: " + randomXPosition);
                //only z is not randomized since everything is surface level
                transform.position = new Vector3(randomXPosition,randomYPosition,0);
            }
        }
    }
}