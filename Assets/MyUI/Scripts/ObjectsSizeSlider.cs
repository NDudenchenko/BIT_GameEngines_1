using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsSizeSlider : MonoBehaviour
{

    public GameObject objectOfChanging;
    public Slider SizeSlider;
    public float SizeCoefficient = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectSizeUpdate(float SizeSliderValue)
    {
        float sizeResult = SizeSliderValue * SizeCoefficient;
        objectOfChanging.transform.localScale = new Vector3(
            objectOfChanging.transform.localScale.x * sizeResult,
            objectOfChanging.transform.localScale.y * sizeResult,
            objectOfChanging.transform.localScale.z * sizeResult);
    }
}
