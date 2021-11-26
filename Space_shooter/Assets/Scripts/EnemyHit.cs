using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public EnemyActions enemyActions;
    void Start()
    {

    }

    void OnTriggerEnter(Collider c) {
        //if(c.gameObject.name == "Bullet(Clone)") {
            Destroy(c.gameObject);
            enemyActions.reset();
        //}

    }
}
