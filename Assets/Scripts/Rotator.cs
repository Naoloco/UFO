using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    [Header("每秒旋轉幅度")]
    public int rotate = 45;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, rotate) * Time.deltaTime);
        //該物件.旋轉屬性(新的三維(沿著z軸選轉45度)*每一秒)
        //等於=>該物件每一秒沿著z軸選轉45度
	}
}
