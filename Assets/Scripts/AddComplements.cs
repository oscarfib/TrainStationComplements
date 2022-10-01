using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComplements : MonoBehaviour
{

    public GameObject Personatges;
    public GameObject mochila;
    // Start is called before the first frame update
    void Start()
    {
        Personatges = GameObject.Find("Personatges");
        foreach (Transform persona in Personatges.transform.GetChild(0).transform){
            Debug.Log(persona);
            Transform spine = persona.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2");
            GameObject mochilaInstance = (GameObject)Instantiate(mochila,spine.transform.position,mochila.transform.rotation);
            mochilaInstance.transform.SetParent(spine);
            mochilaInstance.transform.localPosition = new Vector3(1.73f,-0.32f,0);
        }
        foreach (Transform persona in Personatges.transform.GetChild(1).transform){
            Transform spine = persona.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2");
            GameObject mochilaInstance = (GameObject)Instantiate(mochila,spine.transform.position,mochila.transform.rotation);
            mochilaInstance.transform.SetParent(spine);
            mochilaInstance.transform.localPosition = new Vector3(1.716f,-0.055f,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
