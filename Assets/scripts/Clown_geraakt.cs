using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clown_geraakt : MonoBehaviour
{
    public AudioSource splatter_source;
    void OnCollisionEnter(Collision CollisionInfo) {

        if (CollisionInfo.collider.name == "CakePrefab(Clone)") {
            splatter_source.Play();
        }

    }

}
