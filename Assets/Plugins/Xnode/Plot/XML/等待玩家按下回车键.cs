﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
namespace 基础事件.新剧情系统.XML生成
{
	public class 等待玩家按下回车键 : Node
	{
		[Input] public FunctionProgress 进入节点;
		[Output] public FunctionProgress 退出节点;
		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}
		public override void FunctionDo(string PortName, List<object> param = null)
		{
			DialogSystemInit.createdXMLFileContent += "\r\n";
			string Content = "<WaitInput />";
			DialogSystemInit.createdXMLFileContent += Content;
			ConnectDo("退出节点");
		}
		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null; // Replace this
		}
	}
}