# 実験用システム
##### 開発環境
Unity 2020.3.30f1

# 概要
本システムは自分の研究（作業促進現象が起きたかを検証する）における実験に用いたシステムです。
*※第三者が二次利用する場合、必ず、k098211@kansai-u.ac.jpにまで連絡をお願いします。個人で利用する分には問題ないです。*

## システムの詳細
本システムはディスプレイを二枚用いる。
１枚目のモニターにはひらがなのアナグラム問題が提示され、２枚目のディスプレイには動画（視覚刺激）が提示される。
被験者には２枚目のディスプレイを意識した状態で、アナグラム問題に取り組んでもらう。
問題提示から一定時間経過したタイミングでskipボタンが表示されるため、難しい問題をスキップすることが出来る。
回答時間は２分間で、時間を過ぎると画面が「終了です」という画面に切り替わり、spaceキーを押すことで最初の画面に戻る。

## アナグラム問題について
提示される問題は[清音ひらがな5文字のアナグラムデータベースの作成,市村健士郎ほか](https://www.jstage.jst.go.jp/article/jjpsy/88/3/88_88.16207/_article/-char/ja)を参照したものになっている。

## 取得しているデータについて
- 各問題の回答完了までにかかった秒数（回答ができず、問題をスキップした場合は、スキップまでにかかった秒数が記録される）
- マウス座標（毎秒）
２分間の回答が終了したタイミングで、CSVファイルとして取得したデータがResultファイル内に書き出される仕組みになっている。

### その他
- 初めの画面で被験者番号の入力を求められるが、適当な番号を入力してもらえれば問題ない。（書き出されるCSVファイルの名前に被験者番号が対応するだけ）
- スタート画面の次の画面で、1~9までのボタンが表示される。クリックするボタンによって提示される動画と問題の種類が異なる。
- 1=9のボタンが表示されている場合、仮に1のボタンをクリックした時の取得データは、Result/ex3/P7に出力される。
- 実験システムは計３つ制作し、その全てを本プロジェクトで管理している関係で、正しく動作しない場合がある。
- 不具合が起きた場合は、Unity上でBuildb setting内のBuild In Sceneで画面遷移を正しく設定し直すことや、Inspecter上の設定を変更する必要がある。
