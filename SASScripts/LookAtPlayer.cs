using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;
    private int amount;
    private Rigidbody playerRig;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerRig = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
       // playerRig.AddForce(transform.forward * amount);
    }
}
