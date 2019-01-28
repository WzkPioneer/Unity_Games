using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {
    //绑定一个点光源
    public Light PointLight;
    public float speed=0.01f;
  //  选择控制模式
    public bool RangeControl = true;
    public bool IntensityControl = true;
 
    //设置随机范围
    public float RangeMax = 2;
    public float RangeMin = 0;
    public float RangePause = 0.1f;//执行的间隔
    public float RangeDelayed = 1;//延时的时间
 
    public float IntensityMax = 5;
    public float IntensityMin = 0;
    private float Intensity=0;
    public float IntensityPause = 0.1f;
    public float IntensityDelayed = 1;

	// Use this for initialization
	void Start () {
		PointLight =transform.GetComponent<Light>();

       // 延时执行 并且每个RangeFrame在执行一次
      //  根据控制模式进行变化
        if (RangeControl)
        {
            InvokeRepeating("GetRange", RangeDelayed, RangePause);
        }

        //for (Intensity = IntensityMin; Intensity <= IntensityMax; )
        //{
        //    Intensity = Intensity + 0.5f;
        //    PointLight.intensity = Intensity;
        //}
          //  InvokeRepeating("GetIntensity", IntensityDelayed*Time.deltaTime*speed, IntensityPause*Time.deltaTime*speed);
        

       PointLight.intensity = Random.Range(0,1f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
      //设置Range的值
    void GetRange()
    {
        PointLight.range = Random.Range(RangeMin, RangeMax);
    }
 
    //设置Intensity的值
    void GetIntensity()
    {      
          
          

      //  PointLight.intensity = Random.Range(IntensityMin, IntensityMax);
    }
}
