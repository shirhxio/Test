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
