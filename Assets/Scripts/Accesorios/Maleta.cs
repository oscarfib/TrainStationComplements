using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maleta : Complement
{
    // Start is called before the first frame update
    public GameObject avatar;
    public override void addOn(Transform persona, bool male)
    {
        avatar = persona.gameObject;
        persona.GetComponent<Animator>().SetBool("Handbag",true);
        GameObject objectInstance = (GameObject)Instantiate(transform.gameObject,persona.transform.position + transform.position,transform.rotation);
        objectInstance.transform.SetParent(persona);
    }
    public override void changeAnimation(bool visible)
    {
        avatar.GetComponent<Animator>().SetBool("Handbag",visible);
    }
}
