using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveup : MonoBehaviour
{
        public float speed;
        public float upperBound = 15.0f; // Set an upper bound for balloons to pass and for penalties to be applied
        public ScoreManager scoreManager; // Referencing the Score Manager
         public Balloon balloon;// Reference the balloon script to get the score

        
        // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }


    void Update()
    {
        // Move the balloon up on the y axis at a set rate of speed
        transform.Translate(Vector3.up * speed );

        if(transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); // Reduce score for allowing the balloon to leave the screen
            Destroy(gameObject); //pop the ballon after it leaves the screen
        }
    }
}