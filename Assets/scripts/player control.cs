using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float SpeedX;
    public float Horizontal;
    private Rigidbody2D _componentRigiBody2D;
    public GameObject prefabBullet;
    public AudioSource sfxAudio;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigiBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefabBullet, transform.position, transform.rotation);
            sfxAudio.Play();
        }
    }
    void FixedUpdate()
    {
        _componentRigiBody2D.velocity = new Vector2(Horizontal*SpeedX,_componentRigiBody2D.velocity.y);
    }
}
