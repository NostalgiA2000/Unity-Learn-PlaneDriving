using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject player; //用于存绑定玩家的信息
    private Vector3 offset; //定义一个Vector3类型的变量offset，用于存储摄像机与玩家之间的距离
    private float smoothing = 3; //定义一个浮点型变量smoothing，用于控制摄像机跟随的平滑度

    void Start()
    {
        offset = transform.position - player.transform.position; //计算摄像机与玩家之间的距离
    }

    void LateUpdate()
    {
        //计算摄像机应该移动到的目标位置
        Vector3 targetgetPosition = player.transform.position + player.transform.TransformDirection(offset);
        //使用Lerp函数实现摄像机的平滑跟随
        transform.position = Vector3.Lerp(transform.position, targetgetPosition, Time.deltaTime * smoothing);
        //使摄像机始终朝向玩家
        transform.LookAt(player.transform.position);
    }
}

