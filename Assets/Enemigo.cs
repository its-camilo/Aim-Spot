using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject efect;
    public Controlador controlador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(efect, transform.position, Quaternion.identity);
        controlador.restarene();
        Destroy(gameObject);
    }
}
