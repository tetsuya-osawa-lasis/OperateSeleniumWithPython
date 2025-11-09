using System;
using System.Collections.Generic;
using OpenQA.Selenium;

// Selenium管理クラスとUserEntityクラスが同じ名前空間にあることを前提とします。
// 異なる場合は、適切なusingディレクティブを追加するか、完全修飾名を使用してください。

public class Application
{
    public void RunSeleniumProcess()
    {
        // 00-01（事前準備）

        // 「セレニウム（Selenium）管理クラス」のインスタンスを生成
        // var を使用して変数を定義します。
        var seleniumManager = new SeleniumManager();

        // 「ユーザーエンティティクラス」のリストをインスタンス生成
        var userEntityList = new List<UserEntity>();

        // 「ユーザーエンティティクラス」のインスタンスを生成 (user01用)
        var user01 = new UserEntity();

        // 「ユーザーエンティティクラス」に情報をセット (user01)
        // "" は String.Empty とします。
        user01.UserName = "user01";
        user01.Password = "password01";

        // 「ユーザーエンティティクラス」のリストに「ユーザーエンティティのインスタンス」を追加する。
        userEntityList.Add(user01);

        // 「ユーザーエンティティクラス」のインスタンスを生成 (user02用)
        var user02 = new UserEntity();

        // 「ユーザーエンティティクラス」に情報をセット (user02)
        user02.UserName = "user02";
        user02.Password = "password02";

        // 「ユーザーエンティティクラス」のリストに「ユーザーエンティティのインスタンス」を追加する。
        userEntityList.Add(user02);

        // --- ここから先の処理（特定のURLアクセスやHTML取得）は設計に記載されていないため、省略します。 ---
        // IWebDriver webDriver = null; // 例: ChromeDriverのインスタンスなどをここで生成・初期化
        // webDriver.Navigate().GoToUrl("https://example.com");
        // ... seleniumManager.GetFirstAnchorElementWithText(webDriver, "some text");
    }
}