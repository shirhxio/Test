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

4. CollisionTest(OnCollisionとかの確認)
  * OnCollisionEnter()とかで他のOntriggerEnter()を引き起こしても、呼び出されるのは次のフレーム（ここあたりの呼び出し順は注意が必要かな？）
  * OnCollisionEnter()とかで他のOnTriggerEnter()とか引き起こされてても、呼び出される次のフレームまでに解消してあれば呼び出されない。（当たり前か…）

5. LightTest(Lightの使い勝手の確認中)
  * Lightによる演出の仕方の確認中

a. RollABall(はじめてのUnity)
  * Unityの公式サイトにある新しい方の「はじめてのUnity」
