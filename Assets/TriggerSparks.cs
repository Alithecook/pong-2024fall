using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSparks : MonoBehaviour
{
    public AudioClip BounceSound;
    public GameObject SparksPrefab;
    private void OnTriggerEnter(Collider c)
    {
        Vector3 point = c.gameObject.transform.position;
        GameObject sparks = Instantiate(SparksPrefab, point, Quaternion.identity);
        //might have to get rid of ", true"ß
        CameraEffects.Shake(.4f, true);
        AudioSource.PlayClipAtPoint(BounceSound, point);
        Destroy (sparks, 1.0f);

    }
  

}
