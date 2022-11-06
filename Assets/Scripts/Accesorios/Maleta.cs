using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maleta : Complement
{
    // Start is called before the first frame update
    public override void addOn(Transform persona, bool male)
    {
        persona.GetComponent<Animator>().SetBool("Handbag",true);
        GameObject mochilaInstance = (GameObject)Instantiate(transform.gameObject,persona.transform.position + transform.position,transform.rotation);
        mochilaInstance.transform.SetParent(persona);
    }
}
