using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComplements : MonoBehaviour
{

    public GameObject Personajes;
    public List<GameObject> ManosM;
    public List<GameObject> ManosF;
    public List<GameObject> EspaldaM;
    public List<GameObject> EspaldaF;
    // Start is called before the first frame update
    private bool visible;
    void Start()
    {
        Personajes = GameObject.Find("Personatges");
        //Mujeres
        foreach (Transform persona in Personajes.transform.GetChild(0)){
            int r =  Random.Range(0,ManosF.Count + 1);
            if(r<ManosF.Count) ManosF[r].GetComponent<Complement>().addOn(persona,false);
            r =  Random.Range(0,EspaldaF.Count + 1);
            if(r<EspaldaF.Count) EspaldaF[r].GetComponent<Complement>().addOn(persona,false);
        }
        //Hombres
        foreach (Transform persona in Personajes.transform.GetChild(1)){
            int r =  Random.Range(0,ManosM.Count + 1);
            if(r<ManosM.Count) ManosM[r].GetComponent<Complement>().addOn(persona,false);
            r =  Random.Range(0,EspaldaM.Count + 1);
            if(r<EspaldaM.Count) EspaldaM[r].GetComponent<Complement>().addOn(persona,false);
        }

        visible = true;
    }

    private void Update() {
        if(Input.GetKeyDown("space")){
            foreach (Complement complement in this.GetComponentsInChildren<Complement>(true))
            {
                complement.changeAnimation(!visible);
                complement.gameObject.SetActive(!visible);
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