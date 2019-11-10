using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;


public class EnemyControllerScript : MonoBehaviour
{
    public NavMeshAgent enemyAgent;
    public GameObject player;
    public static int timesKilled = 0;
    public Text killText;
    //Start is called before the first frame update
    void Start()
    {
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            timesKilled += 1;
            killText.text = "Caught: " + timesKilled;
        }
    }
}
