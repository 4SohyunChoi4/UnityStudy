using UnityEngine;

public class LifeCycle : MonoBehaviour
    {
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //오브젝트는 변수 transform을 항상 가지고 있다.
        //transform.Translate(vec); // 벡터 값을 현재 위치에 더하는 함수

        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        /*
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); //맨 끝값이 작을수록 빠르게 이동
    */

        //3. lerp
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f); // 맨 끝 값이 작을수록 느리게 이동

        //4. SLerp //구면 선형, 호 그리며 이동
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
    /*
void Update()
{
if (Input.GetButtonDown("Fire1"))
    Debug.Log("점프!");
if (Input.GetButton("Horizontal"))
{
    Debug.Log("횡 이동중..." + Input.GetAxisRaw("Horizontal"));// 수평, 수직 값 -> float값 반환, 누른 타임에 따라 가중치가 있음
//Raw를 추가하면 1 혹은 -1만 (딱떨어져서) 나온다
}
if (Input.GetButton("Vertical"))
    Debug.Log("종 이동중..." + Input.GetAxisRaw("Vertical"));
}


if (Input.anyKeyDown)
Debug.Log("플레이어가 아무 키를 눌렀습니다.");

if (Input.anyKey)
Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

if (Input.GetKeyDown(KeyCode.Return)) //enter 키 눌렀을 때
Debug.Log("아이템을 구입하였습니다.");

if (Input.GetKey(KeyCode.LeftArrow))
Debug.Log("왼쪽으로 이동 중");

if (Input.GetKeyUp(KeyCode.RightArrow))
Debug.Log("오른쪽으로 이동을 멈추었습니다");

if (Input.GetMouseButtonDown(0))
Debug.Log("미사일 발사!");

if (Input.GetMouseButton(0))
Debug.Log("미사일 모으는 중");

if (Input.GetMouseButtonUp(0))
Debug.Log("슈퍼 미사일 발사!");
}
void Awake()
{
Debug.Log("플레이어 데이터가 준비되었습니다.");
}

void OnEnable()
{
Debug.Log("플레이어가 로그인했습니다.");
}

void Start()
{
Debug.Log("사냥 장비를 챙겼습니다.");
}
void FixedUpdate() // 물리 연산 업데이트 - 고정된 실행 주기로 cpu를 많이 사용
{// 1초에 약 50회정도..
Debug.Log("이동");
}
void Update()//컴퓨터 환경에 따라 실행 주기 바뀜
{
Debug.Log("몬스터 사냥");
}
void LateUpdate() //모든 업데이트가 끝난 후 ( 카메라, 로직 후처리)
{
Debug.Log("경험치 획득");  
}
void OnDisable() //게임 오브젝트가 비활성화
{
Debug.Log("플레이어가 로그아웃했습니다.");
}
void OnDestroy() //게임 오브젝트가 삭제될 때
{
Debug.Log("플레이어 데이터를 해체하였습니다.");
}
*/
}