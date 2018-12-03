using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChar : MonoBehaviour {

    public GameObject player;
    public GameObject effect;
    private int flag = 1;
    private float timer;

    private void Start()
    {
        timer = 0;
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5 && flag==1)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(player);
            flag = 0;
        }
        
    }
        
}
