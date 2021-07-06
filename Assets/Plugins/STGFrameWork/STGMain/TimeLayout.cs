﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("东方STG框架/弹幕设计/重要组件/时间图层")]
public class TimeLayout : MonoBehaviour {
	public float maxFrame = 200;

	public float totalFrame = 0;
	
	// Update is called once per frame
	void Update () {
		if (Global.GamePause || Global.WrttienSystem)
			totalFrame += Global.GlobalSpeed;
	}
}
