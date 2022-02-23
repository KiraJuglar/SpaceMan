using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Para verificar si lo que entro a la zona de muerte es el personaje y no un enemigo u objeto
        if(collision.tag == "Player")
        {
            PlayerController controller = collision.GetComponent<PlayerController>();
            controller.Die();
        }
    }
}
