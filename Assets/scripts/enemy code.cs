using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycode : MonoBehaviour
{
    public float movimientox;
    public float movimientoy;
    public float velocidadXY;
    public GameObject Explosion;
    private Transform _componentTransform;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _componentTransform.position = new Vector2(_componentTransform.position.x + velocidadXY * movimientox * Time.deltaTime,
            _componentTransform.position.y + velocidadXY * movimientoy * Time.deltaTime);
        if (_componentTransform.position.x >= 8.25)
        {
            movimientox = -1;
        }
        else if (_componentTransform.position.x <= -8.25)
        {
            movimientox = +1;
        }
        else if (_componentTransform.position.y >= 4.67)
        {
            movimientoy = -1;
        }
        else if (_componentTransform.position.y <= -1.74)
        {
            movimientoy = +1;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            GameObject explosiondestroy = Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(explosiondestroy, 2);
        }
    }
}
