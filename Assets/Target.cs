using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public GameObject player;
    public static int targetsDestroyed = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            targetsDestroyed += 1;
            scoreText.text = "Score: " + targetsDestroyed;
            this.gameObject.SetActive(false);
        }
    }
}
