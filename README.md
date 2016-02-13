# test
practice github and test Unity

# member
* shirhxio

##TestUnity
1. Raytest(Rayの使い勝手の確認)
  * RaycastHit2Dではz軸上の手前から返してくる。
  * RaycastHit2Dは3DのCollider(Box Colliderなど)には反応しない。
  * layerMaskは対応するビットが1だと反応し、0のlayerは無視。
      （デフォルトでは-1になってるため、全layerが対象になっている。）
  * RaycastHit2Dではx,y軸上の距離は出来るが、z軸に関しては無限遠まで飛んでいる模様？
  * 今回はtagが"test"のものをDestroyする形にしたので、
        手前に他のtagのものがあったりするとそちらにヒットするためlayerなどを上手に使うべき

2. TestInstantiate(Instantiateの使い勝手の確認)
  * Instantiateの返り値をキャスト(Rigidbody)したり、as <scriptCompornent>つけたりすることでコンポーネントを受け取れる。
  * ただし、参照しておくプレハブの型などに注意。例えば、Rigidbodyとして返り値を受け取りたいなら、プレハブもRigidbodyで参照しておく必要がある。

3. AnimationTest
  * AnimationClipでtransformのrotateやらposition、Spriteのcolorをいじっている。
  * 前のタイミングからの相対的に移動させるのはできないのだろうか。

4. LightTest(Lightの使い勝手の確認中)
  * Lightによる演出の仕方の確認中

5. RollABall(はじめてのUnity)
  * Unityの公式サイトにある新しい方の「はじめてのUnity」
