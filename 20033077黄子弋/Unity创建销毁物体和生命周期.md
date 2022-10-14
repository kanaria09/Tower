# 2022.10.14 Unity创建销毁物体和生命周期
## 在游戏的过程中创建和销毁物体
创建物体

1、创建GameObject

public GameObject prefab;

然后将界面上将制作好的预制体拖放到变量Prefab上

2、进行坐标系转换

//本地化3D坐标系
Vector3 pos = new Vector3(r * Mathf.Cos(count * (2 * Mathf.PI)/10), 7, r * Mathf.Sin(count * (2 * Mathf.PI)/10) + 5);

3、加载预制体并实例化**

Instantiate(prefab1, pos, Quaternion.identity);

销毁物体

调用全局函数Destroy

Destroy (obj); //立即删除obj
Destroy (obj, 5.0f); //3秒之后删除obj

## 延迟创建物体，而且让它有动态的效果
**利用Invoke延迟动态创建**

Invoke()有两个参数，第一个参数是 字符串格式的方法名称，第二个参数以秒为单位的延时时间

public extern void Invoke (string methodName, float time);

表示3秒后调用fun方法

void Start(){
    Invoke ("fun", 5);
}
private void fun(){
    Debug.Log ("invokeTest");
}

## 延迟的销毁物体
**利用Destroy延迟销毁**

Destroy方法

Destroy(Object obj, float t = 0.0F);

第二个参数单位为秒,物体将在t秒后被销毁
Destroy()用法

Destroy(Object);//直接删除物体
Destroy(Object, 3);//定时删除物体 Destroy(待删除物体, 执行等待时间);
Destroy(this);//删除物体上挂载的脚本
Destroy(transform.GetComponent<createprim>());//删除某一个组件
DestroyImmediate(Object);//立马删除物体
DontDestroyOnLoad(Object);//跳转场景时不删除某物体
