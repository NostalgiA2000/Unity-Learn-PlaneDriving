using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject player; //���ڴ����ҵ���Ϣ
    private Vector3 offset; //����һ��Vector3���͵ı���offset�����ڴ洢����������֮��ľ���
    private float smoothing = 3; //����һ�������ͱ���smoothing�����ڿ�������������ƽ����

    void Start()
    {
        offset = transform.position - player.transform.position; //��������������֮��ľ���
    }

    void LateUpdate()
    {
        //���������Ӧ���ƶ�����Ŀ��λ��
        Vector3 targetgetPosition = player.transform.position + player.transform.TransformDirection(offset);
        //ʹ��Lerp����ʵ���������ƽ������
        transform.position = Vector3.Lerp(transform.position, targetgetPosition, Time.deltaTime * smoothing);
        //ʹ�����ʼ�ճ������
        transform.LookAt(player.transform.position);
    }
}

