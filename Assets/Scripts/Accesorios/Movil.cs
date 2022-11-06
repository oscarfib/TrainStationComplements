using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movil : Complement
{
    // Start is called before the first frame update
    public override void addOn(Transform persona, bool male)
    {
        persona.GetComponent<Animator>().SetBool("Phone",true);
        Transform hand = persona.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2/Bip01 Neck/Bip01 R Clavicle/Bip01 R UpperArm/Bip01 R Forearm/Bip01 R Hand");
        GameObject mochilaInstance = (GameObject)Instantiate(transform.gameObject,hand.transform.position + transform.position,transform.rotation);
        mochilaInstance.transform.SetParent(hand);
    }

    
}
