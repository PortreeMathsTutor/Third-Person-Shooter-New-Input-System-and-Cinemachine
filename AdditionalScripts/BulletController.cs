using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
  

    [SerializeField]
    private float timeToDestroyGameObject =1;

    [SerializeField]
    private GameObject bulletDecal;

    [SerializeField]
    private GameObject blood;

    [SerializeField]
    private MeshRenderer bulletMesh;

  
    private float speed = 50;


    public static Vector3 target { get; set; }
    public static bool hit { get; set; }
    private void OnEnable()
    {
       Destroy(gameObject, timeToDestroyGameObject); 
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(!hit && Vector3.Distance(transform.position, target)< 0.01f)
        {
           Destroy(gameObject, 1); 
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            ContactPoint contact = collision.GetContact(0);
            GameObject.Instantiate(bulletDecal, contact.point + contact.normal * 0.0001f, Quaternion.LookRotation(contact.normal));
          Destroy(gameObject); 
        }
        if (collision.gameObject.tag == "Enemy")
        {
            bulletMesh.enabled = false;
            collision.gameObject.transform.tag = "DeadEnemy";
            blood.SetActive(true);
        
      Destroy(collision.gameObject,1);
        }

   
    }
}
