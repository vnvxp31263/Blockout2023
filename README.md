# Blockout2023

## Unityのバージョン
Unity 2022.3.0f1

## 各ファイルの説明

### ball.cs
ボールのスクリプトです。

### bar.cs
コントロールバーのスクリプトです。

### destory.cs
ブロックのスクリプトです。

パーティクルを使用しない場合は、particleObjectの宣言とInstantiateの呼び出しをコメントアウトしてください。

### Score.cs
メインカメラのスクリプトです。

### Drawscore.cs
テキストを含むキャンバスのスクリプトです。

シリアライズフィールドのSearch TextにText (Legacy), またはText (TMP)を指定してください。

テキスト名をデフォルトから変更した場合は、変更後のテキスト名を指定してください。

### OnTouch.cs
ボタンのスクリプトです。

Onclick()の＋を押し、オブジェクトにボタンを含むキャンバスを指定してください。

次に、メソッドにDrawScore.OnClickToGame()を指定してください。

### SelfDestroy.cs
プレハブ化したパーティクルオブジェクトのスクリプトです。
