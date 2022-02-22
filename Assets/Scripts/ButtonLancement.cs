using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonLancement : MonoBehaviour
{
    public GameObject compteur;

    public Animator animator;

    public TextMeshProUGUI chronoUI;

    public GameObject boutonLancement;

    public float chronoInitiale = 3;
    public float chrono = 0;

    //Function qui est appellé lorsque qu'on click sur le bontou
    //de lancement
    public void Lancement()
    {
        //Démarrage d'une corroutine
        StartCoroutine(StartCountdown());
    }
    //Minuteur de 3 secondes avant qui lance la fusée
    private IEnumerator StartCountdown()
    {
        chrono = chronoInitiale;
        while (chrono >= 0)
        {
            //Permet de modifier le UI lorsque le compteur déscend
            chronoUI.text = chrono.ToString();
            //Permet d'attendre 1 seconde
            yield return new WaitForSeconds(1.0f);
            chrono--;
            //Vérifie que le minuteur à atteind 0 pour lancé la fusée
            if (chrono == 0)
            {
                //Animation de la fuée démarre
                animator.Play("Lancement");
                //Faire disparaître le bouton de lancement
                this.boutonLancement.gameObject.SetActive(false);
            }
        }
    }
}
