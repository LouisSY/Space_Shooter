using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public GameObject bullet;
    public Transform GunPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObject();
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, GunPos.position, Quaternion.identity);
        }
    }

    void moveObject() {
        float inputHor = Input.GetAxis("Horizontal");
        float inputVer = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * 7 * inputHor);
        transform.Translate(Vector3.up * Time.deltaTime * 7 * inputVer);

        if(transform.position.x > 9.5f) {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
        if(transform.position.x < -9.5f) {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }

        if(transform.position.y > 5.2f) {
            transform.position = new Vector3(transform.position.x, 5.2f, 0);
        }
        if(transform.position.y < -3.2f) {
            transform.position = new Vector3(transform.position.x, -3.2f, 0);
        }

        
    }
}
