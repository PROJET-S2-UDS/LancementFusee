using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparaitBoutonLancement : MonoBehaviour
{
    private bool boutonApparut = false;

    //Le bouton apparaît lorsque l'objet apparaît dans le monde AR
    public void ActiveButton()
    {
        //Vérifie si l'objet est déjà apparu une fois
        if(boutonApparut == false)
        {
            //Permet d'apparaît le bouton pour le lancement
            this.gameObject.SetActive(true);
            boutonApparut = true;
        }
    }
}
