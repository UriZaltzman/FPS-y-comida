using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionAreaScript : MonoBehaviour
{
    public int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void puntoss(int puntsiaems)
    {
        puntos += puntsiaems;
    }

    private void OnTriggerEnter(Collider other)
    {
        PickUpScript pickUp;
        pickUp = GetComponent<PickUpScript>();
        if (pickUp.esComida == true)
        {
            puntoss(pickUp.puntosItem);
            Destroy(other.gameObject);

        }
        else
        {
            puntoss(pickUp.puntosItem);
        }
    }
}
