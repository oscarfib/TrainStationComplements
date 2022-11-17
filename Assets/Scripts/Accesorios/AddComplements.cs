using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AddComplements : MonoBehaviour
{
    [Range(0,100)]
    public int manos;
    [Range(0,100)]
    public int espalda;
    [Range(0,100)]
    public int cara;
    [Range(0,100)]
    public int cabeza;
    public GameObject Personajes;
    public List<GameObject> ManosM;
    public List<GameObject> ManosF;
    public List<GameObject> EspaldaM;
    public List<GameObject> EspaldaF;
    public List<GameObject> Cara;
    public List<GameObject> CabezaM;
    public List<GameObject> CabezaF;
    private bool visible;
    void Start()
    {
        Personajes = GameObject.Find("Personatges");
        //Mujeres
        foreach (Transform persona in Personajes.transform.GetChild(0)){
            //Manos
            int p = Random.Range(0,100);
            int r = Random.Range(0,ManosF.Count);
            if(p<manos) {
                ManosF[r].GetComponent<Complement>().addOn(persona,false);
                persona.GetComponent<NavMeshAgent>().radius = 0.6f;
            }
            //Espalda
            p = Random.Range(0,100);
            r = Random.Range(0,EspaldaF.Count);
            if(p<espalda) EspaldaF[r].GetComponent<Complement>().addOn(persona,false);
            //Cara
            p = Random.Range(0,100);
            r = Random.Range(0,Cara.Count);
            if(p<cara) Cara[r].GetComponent<Complement>().addOn(persona,false);
            //Cabeza
            p = Random.Range(0,100);
            r = Random.Range(0,CabezaF.Count);
            if(p<cabeza) CabezaF[r].GetComponent<Complement>().addOn(persona,false);
        }
        //Hombres
        foreach (Transform persona in Personajes.transform.GetChild(1)){
            //Manos
            int p = Random.Range(0,100);
            int r = Random.Range(0,ManosM.Count);
            if(p<manos) {
                ManosM[r].GetComponent<Complement>().addOn(persona,true);
                persona.GetComponent<NavMeshAgent>().radius = 0.6f;
            }
            //Espalda
            p = Random.Range(0,100);
            r = Random.Range(0,EspaldaM.Count);
            if(p<espalda) EspaldaM[r].GetComponent<Complement>().addOn(persona,true);
            //Cara
            p = Random.Range(0,100);
            r = Random.Range(0,Cara.Count);
            if(p<cara) Cara[r].GetComponent<Complement>().addOn(persona,true);
            //Cabeza
            p = Random.Range(0,100);
            r = Random.Range(0,CabezaM.Count);
            if(p<cabeza) CabezaM[r].GetComponent<Complement>().addOn(persona,false);
        }

        visible = true;
    }

    private void Update() {
        if(Input.GetKeyDown("space")){
            foreach (Complement complement in this.GetComponentsInChildren<Complement>(true))
            {
                complement.changeAnimation(!visible);
                complement.gameObject.SetActive(!visible);
                complement.changeAnimation(!visible);
            }
            visible = !visible;
        }
    }

    // Update is called once per frame
    
}

public abstract class Complement : MonoBehaviour{
    public abstract void addOn(Transform persona, bool male);

    public abstract void changeAnimation(bool visible);
}