using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSparks : MonoBehaviour
{
    public AudioClip BounceSound;
    public GameObject SparksPrefab;
    private void OnCollisionEnter(Collision coll)
    {
        Vector3 point = coll.GetContact(0).point;
        GameObject sparks = Instantiate(SparksPrefab, point, Quaternion.identity);
        //might have to get rid of ", true"
        CameraEffects.Shake(.4f);
        AudioSource.PlayClipAtPoint(BounceSound, point);
        Destroy (sparks, 1.0f);

    }
  

}
