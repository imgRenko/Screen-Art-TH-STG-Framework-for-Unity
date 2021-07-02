﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
namespace 基础事件.输入
{
	public class 是否放开某键 : Node
	{
		[Input] public string 键位名称;
		[Output] public bool 结果;
		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			

			键位名称 = GetInputValue("键位名称", 键位名称);
			if (键位名称 == "")
				return null;
			return Input.GetButtonUp(键位名称); // Replace this
		}
	}
}