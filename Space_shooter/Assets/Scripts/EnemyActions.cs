using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);
        moveEnemy();
    }

    void moveEnemy() {        
        if(transform.position.y < -4.5f) {
            float xPosRan = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector3(xPosRan, 6.5f, 0);
            enemySpeed = Random.Range(2.0f, 7.0f);
        }
    }
}
