using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mochila : Complement
{
    // Start is called before the first frame update
    public override void addOn(Transform persona, bool male)
    {
        Transform spine = persona.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2");
        GameObject objectInstance = (GameObject)Instantiate(transform.gameObject,spine.transform.position + transform.position,transform.rotation);
        objectInstance.transform.SetParent(spine);
    }

    public override void changeAnimation(bool visible){}
}
