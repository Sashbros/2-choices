using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour {

    public GameObject myWeapon;
    public GameObject weaponOnGround;

	// Use this for initialization
	void Start ()
    {
        myWeapon.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            myWeapon.SetActive(true);
            weaponOnGround.SetActive(false);
        }
    }
}
