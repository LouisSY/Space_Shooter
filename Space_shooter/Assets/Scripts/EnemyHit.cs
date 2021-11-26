using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public EnemyActions enemyActions;
    public GameObject exposion;
    void Start()
    {

    }

    void OnTriggerEnter(Collider c) {
        //if(c.gameObject.name == "Bullet(Clone)") {
            Instantiate(exposion, transform.position, Quaternion.identity);
            Destroy(c.gameObject);
            enemyActions.reset();
        //}

    }
}
