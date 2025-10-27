# （参考）https://qiita.com/motoki1990/items/376fc1d1f3d59c960f5c

class OSManager:

    # コンストラクタ
    def __init__(self):
        print("init:")

    # コンストラクタ（引数あり）
    # Pythonは、コンストラクタを１つしか持てないから、いったんコメントアウト
    # まぁ、やりようはあるらしいが、とりあえず今は不要
    # https://qiita.com/miyashiiii/items/9dcb2114ac0843a73fce
    #def __init__(self, val1, val2):
    #    print("init:" + val1 + ", " + val2)

    # デストラクタ
    def __del__(self):
        # デストラクタ
        print("del:デストラクタ")


    # インスタンスメソッドは、(self)が必要らしい
    def get_AAA(self) -> str:
        ret = ""

        ret = "AAA"

        return ret