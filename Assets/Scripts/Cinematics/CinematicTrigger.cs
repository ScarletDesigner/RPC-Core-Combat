using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        [SerializeField] bool oneShot;
        bool alreadyTriggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (oneShot && alreadyTriggered) return;

            if (other.tag == "Player")
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
        }
    }

}