using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public GameObject target; //L'objet a modifier sa taille
    public GameObject fusee;
    private float initialDistance; //La distance initiale
    private Vector3 initialScale; //La grosseur initial de l'objet
    // Update is called once per frame
    void Update()
    {
        //Permet de vérifier si les deux doigts sont sur l'écran
        if (Input.touchCount == 2)
        {
            var touchZero = Input.GetTouch(0);
            var touchOne = Input.GetTouch(1);
            //Permet d'arrêter l'exécution du code si il manque un doigt sur l'écran
            if (touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled ||
                touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
            {
                return;
            }
            //Vérifie la postion initial des doigts
            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                //Calcul la distance entre la position du doigt 0 et du doigt 1
                initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                //Permet de connaître la grosseur de l'objet initialement
                initialScale = target.transform.localScale;
            }
            else
            {
                //Vérifie en continue la position des doigts (Pour savoir dans quelles directions
                //bouge pour faire la scale)
                var currentDistance = Vector2.Distance(touchZero.position, touchOne.position);
                //Si la distance initiale est proche ou à 0, il ne fait pas de scale.
                if (Mathf.Approximately(initialDistance, 0))
                {
                    return;
                }
                //Permet de calculer le ratio entre la distance courrent et la distance
                //initiale de l'objet
                var factor = currentDistance / initialDistance;
                //Pemet d'appliquer la scale à l'objet en multiplier le scale inital par le ratio.
                target.transform.localScale = initialScale * factor;
            }
        }
    }
}
