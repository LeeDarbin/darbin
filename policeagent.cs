using UnityEngine;
using Unity.MLAgents;

public class police : police
{
    private Trnasform tr;
    private Rigidbody rb;
    public Transform targetTr;
    
    //�ʱ�ȭ �۾��� ���� �ѹ� ȣ��Ǵ� �޼ҵ�
    public override void Initialize()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    //���Ǽҵ�(�н�����)�� �����Ҷ����� ȣ��
    public override void OnEpisodeBegin()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        tr.localPosition = new Vector3(Random.Range(-4.0f, 4.0f), 0.05f, Random.Range(-4.0f, 4.0f));
        targetTr.localPosition = new Vecotr3(Random.Range(-4.0f, 4.0f), 0.55f, Random.Range(-4.0f, 4.0f));
    }

    //ȯ�� ������ ���� �� ������ ��å ������ ���� �극�ο� �����ϴ� �޼ҵ�
    public override void CollectObservations(Unity.MLAgents.Sensors.VectorSensor sensor)
    {

    }

    //�극��(��å)���� ���� ���� ���� �ൿ�� �����ϴ� �޼ҵ�
    public override void OnActionReceived(float[] vectorAction)
    {

    }

    //������(�����)�� ���� ����� ������ ȣ���ϴ� �޼ҵ�(�ַ� �׽�Ʈ�뵵 �Ǵ� ����н��� ���)
    public override void Heuristic(float[] actionsOut)
    {

    }
}