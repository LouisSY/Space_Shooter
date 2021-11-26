using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public EnemyActions enemyActions;
    public GameObject exposion_enemy;
    public GameObject exposion_player;
    void Start()
    {

    }

    void OnTriggerEnter(Collider c) {
        Debug.Log(c.gameObject.name);
        if(c.tag == "Bullets") {
            Instantiate(exposion_enemy, transform.position, Quaternion.identity);
            Destroy(c.gameObject);
            enemyActions.reset();
        }
        if(c.tag == "Player") {
            Instantiate(exposion_player, transform.position, Quaternion.identity);
        }

    }
}
