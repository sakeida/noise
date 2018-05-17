using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endingtxt : MonoBehaviour {

	private Text messageText;
	//　表示するメッセージ
	private string message;
	//　1回のメッセージの最大文字数
	[SerializeField]
	private int maxTextLength = 90;
	//　1回のメッセージの現在の文字数
	private int textLength = 0;
	//　メッセージの最大行数
	[SerializeField]
	private int maxLine = 3;
	//　現在の行
	private int nowLine = 0;
	//　テキストスピード
	[SerializeField]
	private float textSpeed = 0.05f;
	//　経過時間
	private float elapsedTime = 0f;
	//　今見ている文字番号
	private int nowTextNum = 0;
	//　マウスクリックを促すアイコン
	private Image clickIcon;
	//　クリックアイコンの点滅秒数
	[SerializeField]
	private float clickFlashTime = 0.2f;
	//　1回分のメッセージを表示したかどうか
	private bool isOneMessage = false;
	//　メッセージをすべて表示したかどうか
	private bool isEndMessage = false;

	void Start () {
		clickIcon = transform.Find("Panel/Image").GetComponent<Image>();
		clickIcon.enabled = false;
		messageText = GetComponentInChildren<Text>();
		messageText.text = "";
		if(PlayerController.FLAG>=2)
			SetMessage ("思い出した。自分が何者かを\n"
				+ "私はこのAI達の要塞を破壊するために\n"+"人間に作られたアンドロイドだった。\n"
				+ "数年前に一部の暴走を起こしたAI達が\n"+"人間達に反旗を翻した。\n"
				+ "すぐ沈静化するかに思われたが\n"+"AI達は自らを生み出すジェネレーターで\n"+"その数を増やし戦いはこう着状態に陥った。\n"
				+ "このまま悪戯に人的資源を\n"+"浪費する戦況が続くことを恐れた人間は\n" + "私たちアンドロイドを多くの輸送船に乗せ\n"+"AI達の基地に突撃させた。\n" +
				"他のアンドロイド達がいないのをみると\n"+"ほとんどのアンドロイドは\n"
				+"基地にたどり着けたとしても\n"+"防衛システムにやられてしまったようだ。\n" +
				"私一人でもたどり着けてよかった。\n"+"これで任務を完遂出来る\n"+
				"さてそろそろこの基地の中心に行って\n"+"この戦いを終わらせよう\n"+"。。。私が自爆し基地を破壊することによって\n"+"............fin\n"

		);
		else SetMessage ("自分が何者かはまだ分からない\n" + "なぜここにいるか、ここがどこだかさえも\n"
			+ "しかし私がやらねばならないことは\n思い出した。\n"
			+ "さあここの中心部へ行こう\n"
			+ "私の思い出せた唯一の記憶に従い\n"
			+ "最後の使命を果たそう\n" + "\n" + "\n"+"............fin\n" 


		);
	}

	void Update () {
		//　メッセージが終わっていない、または設定されている
		if (isEndMessage || message == null) {
			return;
		}

		//　1回に表示するメッセージを表示していない	
		if (!isOneMessage) {

			//　テキスト表示時間を経過したら
			if (elapsedTime >= textSpeed) {
				messageText.text += message [nowTextNum];
				//　改行文字だったら行数を足す
				if (message [nowTextNum] == '\n') {
					nowLine++;
				}
				nowTextNum++;
				textLength++;
				elapsedTime = 0f;

				//　メッセージを全部表示、または行数が最大数表示された
				if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine) {
					isOneMessage = true;
				}
			}
			elapsedTime += Time.deltaTime;

			//　メッセージ表示中にマウスの左ボタンを押したら一括表示
			if (Input.GetMouseButtonDown (0)) {
				//　ここまでに表示しているテキストを代入
				var allText = messageText.text;

				//　表示するメッセージ文繰り返す
				for (var i = nowTextNum; i < message.Length; i++) {
					allText += message [i];

					if (message [i] == '\n') {
						nowLine++;
					}
					nowTextNum++;
					textLength++;

					//　メッセージがすべて表示される、または１回表示限度を超えた時
					if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine) {
						messageText.text = allText;
						isOneMessage = true;
						break;
					}
				}
			}
			//　1回に表示するメッセージを表示した
		} else {

			elapsedTime += Time.deltaTime;

			//　クリックアイコンを点滅する時間を超えた時、反転させる
			if(elapsedTime >= clickFlashTime) {
				clickIcon.enabled = !clickIcon.enabled;
				elapsedTime = 0f;
			}

			//　マウスクリックされたら次の文字表示処理
			if(Input.GetMouseButtonDown(0)) {
				Debug.Log (messageText.text.Length);
				messageText.text = "";
				nowLine = 0;
				clickIcon.enabled = false;
				elapsedTime = 0f;
				textLength = 0;
				isOneMessage = false;

				//　メッセージが全部表示されていたらゲームオブジェクト自体の削除
				if (nowTextNum >= message.Length) {
					nowTextNum = 0;
					isEndMessage = true;
					transform.GetChild (0).gameObject.SetActive (false);
					SceneManager.LoadScene ("Title");
				}
					//　それ以外はテキスト処理関連を初期化して次の文字から表示させる
				
			}
		}
	}

	void SetMessage(string message) {
		this.message = message;
	}
	//　他のスクリプトから新しいメッセージを設定
	public void SetMessagePanel(string message) {
		SetMessage (message);
		transform.GetChild (0).gameObject.SetActive (true);
		isEndMessage = false;
	}

}