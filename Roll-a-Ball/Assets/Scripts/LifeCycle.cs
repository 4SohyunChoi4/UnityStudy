using UnityEngine;

public class LifeCycle : MonoBehaviour
    {
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //������Ʈ�� ���� transform�� �׻� ������ �ִ�.
        //transform.Translate(vec); // ���� ���� ���� ��ġ�� ���ϴ� �Լ�

        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        /*
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); //�� ������ �������� ������ �̵�
    */

        //3. lerp
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f); // �� �� ���� �������� ������ �̵�

        //4. SLerp //���� ����, ȣ �׸��� �̵�
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
    /*
void Update()
{
if (Input.GetButtonDown("Fire1"))
    Debug.Log("����!");
if (Input.GetButton("Horizontal"))
{
    Debug.Log("Ⱦ �̵���..." + Input.GetAxisRaw("Horizontal"));// ����, ���� �� -> float�� ��ȯ, ���� Ÿ�ӿ� ���� ����ġ�� ����
//Raw�� �߰��ϸ� 1 Ȥ�� -1�� (����������) ���´�
}
if (Input.GetButton("Vertical"))
    Debug.Log("�� �̵���..." + Input.GetAxisRaw("Vertical"));
}


if (Input.anyKeyDown)
Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

if (Input.anyKey)
Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

if (Input.GetKeyDown(KeyCode.Return)) //enter Ű ������ ��
Debug.Log("�������� �����Ͽ����ϴ�.");

if (Input.GetKey(KeyCode.LeftArrow))
Debug.Log("�������� �̵� ��");

if (Input.GetKeyUp(KeyCode.RightArrow))
Debug.Log("���������� �̵��� ���߾����ϴ�");

if (Input.GetMouseButtonDown(0))
Debug.Log("�̻��� �߻�!");

if (Input.GetMouseButton(0))
Debug.Log("�̻��� ������ ��");

if (Input.GetMouseButtonUp(0))
Debug.Log("���� �̻��� �߻�!");
}
void Awake()
{
Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
}

void OnEnable()
{
Debug.Log("�÷��̾ �α����߽��ϴ�.");
}

void Start()
{
Debug.Log("��� ��� ì����ϴ�.");
}
void FixedUpdate() // ���� ���� ������Ʈ - ������ ���� �ֱ�� cpu�� ���� ���
{// 1�ʿ� �� 50ȸ����..
Debug.Log("�̵�");
}
void Update()//��ǻ�� ȯ�濡 ���� ���� �ֱ� �ٲ�
{
Debug.Log("���� ���");
}
void LateUpdate() //��� ������Ʈ�� ���� �� ( ī�޶�, ���� ��ó��)
{
Debug.Log("����ġ ȹ��");  
}
void OnDisable() //���� ������Ʈ�� ��Ȱ��ȭ
{
Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
}
void OnDestroy() //���� ������Ʈ�� ������ ��
{
Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�.");
}
*/
}