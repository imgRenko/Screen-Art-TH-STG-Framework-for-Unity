﻿using System.Collections; 
 using System.Collections.Generic;
 using UnityEngine; 
 using XNode; 
namespace 基础事件.敌人 
{public class 设置敌人浮点数信息:Node 
 {[Input] public FunctionProgress 进入节点;[Input] public float 目的值;[Input] public Enemy 敌人; 
[Output] public FunctionProgress 退出节点;
public enum EnemyData { 
敌人目前生命值=0,
敌人最大生命值=1,
Speed=2,
初始移动=3
}
public EnemyData 敌人属性;
 public override void FunctionDo(string PortName,List<object> param = null) {
 敌人 = GetInputValue<Enemy>("敌人", null);if (敌人 == null) return;目的值 = GetInputValue<float>("目的值", 0); switch(敌人属性) 
 {case EnemyData.敌人目前生命值:
敌人.HP=目的值;
break;
case EnemyData.敌人最大生命值:
敌人.MaxHP=目的值;
break;
case EnemyData.Speed:
敌人.Speed=目的值;
break;
case EnemyData.初始移动:
敌人.RunTime=目的值;
break;
} ConnectDo("退出节点");}}}