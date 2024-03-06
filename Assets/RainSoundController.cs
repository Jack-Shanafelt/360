using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSoundController : MonoBehaviour
{
    private AudioLowPassFilter lowPassFilter;
    public AnimationCurve distanceGraph;

    // Start is called before the first frame update
    void Start()
    {
        lowPassFilter = GetComponent<AudioLowPassFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        lowPassFilter.cutoffFrequency = distanceGraph.Evaluate(distance);
    }
}

