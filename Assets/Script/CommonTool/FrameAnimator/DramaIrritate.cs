using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class DramaIrritate : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Borrow{ get { return Floral; } set { Floral = value; } }

	[SerializeField] private Sprite[] Floral= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Literally{ get { return Earthward; } set { Earthward = value; } }

	[SerializeField] private float Earthward= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool AfloatPortHabit{ get { return FuturePortHabit; } set { FuturePortHabit = value; } }

	[SerializeField] private bool FuturePortHabit= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Inca{ get { return Meet; } set { Meet = value; } }

	[SerializeField] private bool Meet= true;

	//动画曲线
	[SerializeField] private AnimationCurve Lvory= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Human;
	//目标SpriteRenderer组件
	private SpriteRenderer LondonIntegral;
	//当前帧索引
	private int LoyallyDramaFrown= 0;
	//下一次更新时间
	private float Boule= 0.0f;
	//当前帧率，通过曲线计算而来
	private float LoyallyLiterally= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void River()
	{
		LoyallyDramaFrown = Earthward < 0 ? Floral.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Item()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Needy()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Icon()
	{
		Needy();
		River();
	}

	//自动开启动画
	void Start()
	{
		Human = this.GetComponent<Image>();
		LondonIntegral = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Human == null && LondonIntegral == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Floral == null || Floral.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Lvory.Evaluate((float)LoyallyDramaFrown / Floral.Length);
			float curvedFramerate = curveValue * Earthward;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float Heal= FuturePortHabit ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (Heal - Boule > interval)
				{
					//执行更新操作
					AtRejoin();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void AtRejoin()
	{
		//计算新的索引
		int nextIndex = LoyallyDramaFrown + (int)Mathf.Sign(LoyallyLiterally);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Floral.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Meet == false)
			{
				LoyallyDramaFrown = Mathf.Clamp(LoyallyDramaFrown, 0, Floral.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		LoyallyDramaFrown = nextIndex % Floral.Length;
		//更新图片
		if (Human != null)
		{
			Human.sprite = Floral[LoyallyDramaFrown];
		}
		else if (LondonIntegral != null)
		{
			LondonIntegral.sprite = Floral[LoyallyDramaFrown];
		}
		//设置计时器为当前时间
		Boule = FuturePortHabit ? Time.unscaledTime : Time.time;
	}
}

