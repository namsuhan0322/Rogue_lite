using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ActionSystem/NewAction")]      //ActionSystem/NewAction �޴����� ��ũ���ͺ� ������Ʈ�� ����� �� �ְ� ��
public class ActionData : ScriptableObject
{
    [SerializeField] public string animName;
    [SerializeField] private string mecanimName;
    [SerializeField] private string nextMecanimName;

    [SerializeField] public float fxTime;                   //����Ʈ�� ��Ÿ���� �ð� 
    [SerializeField] public string layerName;               //��ī�� ���̾� ����
    [SerializeField] public float waitTime;                 //��ٸ��� �ð� 
    [SerializeField] public float nextWaitTime;
    [SerializeField] public GameObject fxObject;

    private AnimationClip eventClip;

    //�ִϸ��̼� Ŭ���� ���Ϳ� ���� 
    public AnimationClip EventClip
    {
        get { return this.eventClip; }
        set
        {
            this.eventClip = value;
            if(eventClip != null)
            {
                waitTime = eventClip.length;        //Ŭ���� ���̸� waitTime�� ����
                mecanimName = eventClip.name;       //Ŭ���� �̸��� mecanimName�� ����
            }
        }
    }
    //mecanimName�� �ܺο��� ������ �� �ְ� �߰�
    public string MecanimName
    {
        get { return mecanimName; }
    }
}
