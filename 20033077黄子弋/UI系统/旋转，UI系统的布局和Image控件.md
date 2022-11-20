四元数表示什么
四元数是最简单的超复数，用于表示物体的旋转，在unity中由x,y,z,w 表示四个值

如何沿世界坐标轴旋转
Quaternion smallRotate = Quaternion.Euler(v, h, 0);
transform.rotation = smallRotate * transform.rotation;

如何沿局部坐标轴旋转
transform.rotation = transform.rotation * smallRotate;

如何通过插值实现沿球面两个点的最短路径进行移动
public static Vector3 Lerp(Vector3 a, Vector3 b, float t);//其中a代表起点，b代表终点。 
public class example:MonoBehaviour{
        public Transform start;
        public  Transform  end;
        void Update(){
                transform.position = Vector3.Lerp (start.position, end.position, Time.deltaTime);
        }
}

UI系统是什么
由 Canvas 以及 各种 UI 组件组成。
UI 的显示不基于 SpriteRenderer，且UI界面是完全贴合屏幕的，不会随相机的移动而移动

谈一下你对UI系统布局的理解

Pivot是什么?
是物体的中心点，当物体旋转时会围绕着中心点旋转

Anchor Presets表示什么?
是一个可自行设置的固定点，作用是当父物体拖动，变换时，该物体会相对于锚点做相应的运动，可以进行控制缩放和UI的对齐方式

如何根据Pivot和Anchor Presets进行相对位置的设置
UGUI

Image的填充动画如何实现
void Start(){
    // 将图片类型改为Filled，360度填充，方便制作旋转动画
    image.type = Image.Type.Filled;
    image.fillMethod = Image.FillMethod.Radial360;
}
void Update(){
    // 制作一个旋转显示的动画效果，直线效果也是类似的
    // 取值在0~1之间
    image.fillAmount = fillAmount;
    fillAmount += 0.02f;
    if (fillAmount > 1){
        fillAmount = 0;
    }
}

课堂练习

沿世界坐标轴旋转
    transform.rotation = smallRotate * transform.rotation;

沿局部坐标轴旋转
    transform.rotation = transform.rotation * smallRotate;

利用插值实现旋转动态利用插值实现旋转动态
    rotationObj.transform.rotation = Quaternion.Slerp(rotationObj.transform.rotation, Quaternion.LookRotation(d - s), Time.deltaTime * 0.2f);

操作Image组件实现动画填充效果操作Image组件实现动画填充效果
    void Start(){
        // 将图片类型改为Filled，360度填充，方便制作旋转动画
        image.type = Image.Type.Filled;
        image.fillMethod = Image.FillMethod.Radial360;
    }
    void Update(){
        // 制作一个旋转显示的动画效果，直线效果也是类似的
        // 取值在0~1之间
        image.fillAmount = fillAmount;
        fillAmount += 0.02f;
        if (fillAmount > 1){
        fillAmount = 0;
        }
    }