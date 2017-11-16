Editor拡張でシステムアイコンを簡単に組み込む為のクラス
===================================================================

/Assets/Plugins/Editor/ に放り込みます。
すると、Editor拡張を書くときに

```
if(GUILayout.Button(am.SystemIconManager.instance.GetIconTexture(SystemIcon.IconType.Reload), GUILayout.Width(32))){
  // do something
}
```

とか簡単にアイコンボタンを出すことができる。
