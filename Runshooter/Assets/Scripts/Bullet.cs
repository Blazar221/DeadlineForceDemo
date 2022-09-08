using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Destroy(gameObject, 5f);
        Physics2D.IgnoreLayerCollision(6, 7, true);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.GetComponent<Enemy>() != null) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
