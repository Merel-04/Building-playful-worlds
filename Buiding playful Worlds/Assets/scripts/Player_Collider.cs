
using UnityEngine;

public class Player_Collider : MonoBehaviour
{
    public MeshRenderer Mr;
     void OnCollisionEnter( Collision CollisionInfo)
    {
        Debug.Log(CollisionInfo.collider.name);

        if (CollisionInfo.collider.name == "Switch")

            {
            Debug.Log("change color of pillair");
            Mr.material.color = Color.red;
            }

        if (CollisionInfo.collider.name == "Switch_1")

        {
            Debug.Log("change color of pillair");
            Mr.material.color = Color.white;
        }


        if (CollisionInfo.collider.name == "Switch_2")

        {
            Debug.Log("change color of pillair");
            Mr.material.color = Color.black;
        }
    }
}
