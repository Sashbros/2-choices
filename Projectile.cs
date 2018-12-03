using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public float distance;
    public LayerMask whatIsSolid;

    public int damage;

    public GameObject destroyEffect;

	// Use this for initialization
	void Start ()
    {
        Invoke("DestroyProjectile", lifeTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy")) //|| hitInfo.collider.CompareTag("Environment"))
            {
                Debug.Log("Hello");
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                DestroyProjectile();
                SceneManager.LoadScene("Sacrifice");
            }
            else if (hitInfo.collider.CompareTag("Environment"))
            {
                Debug.Log("Hello");
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                DestroyProjectile();
                SceneManager.LoadScene("Kill");
            }
                //DestroyProjectile();
        }

        transform.Translate(Vector2.one * speed * Time.deltaTime);
	}

    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
